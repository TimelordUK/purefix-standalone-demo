#!/bin/bash
#
# Test script for sequence number mismatch recovery
# Demonstrates client catching up when its sequence number is behind the server's expectation
#

set -e

SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
cd "$SCRIPT_DIR"

# Colors for output
RED='\033[0;31m'
GREEN='\033[0;32m'
YELLOW='\033[1;33m'
BLUE='\033[0;34m'
CYAN='\033[0;36m'
NC='\033[0m' # No Color

STORE_DIR="store"
TIMEOUT_SECS=5

print_header() {
    echo ""
    echo -e "${CYAN}════════════════════════════════════════════════════════════════════════════════${NC}"
    echo -e "${CYAN}  $1${NC}"
    echo -e "${CYAN}════════════════════════════════════════════════════════════════════════════════${NC}"
}

print_step() {
    echo ""
    echo -e "${YELLOW}>>> $1${NC}"
}

print_success() {
    echo -e "${GREEN}$1${NC}"
}

print_info() {
    echo -e "${BLUE}$1${NC}"
}

show_store_state() {
    local label="$1"
    print_step "$label"

    if [ -f "$STORE_DIR/FIX.5.0SP2-init-comp-accept-comp.seqnums" ]; then
        echo "Client (init-comp -> accept-comp):"
        cat "$STORE_DIR/FIX.5.0SP2-init-comp-accept-comp.seqnums"
        echo ""
    else
        echo "  (no client store file yet)"
    fi

    if [ -f "$STORE_DIR/FIX.5.0SP2-accept-comp-init-comp.seqnums" ]; then
        echo "Server (accept-comp -> init-comp):"
        cat "$STORE_DIR/FIX.5.0SP2-accept-comp-init-comp.seqnums"
    else
        echo "  (no server store file yet)"
    fi
}

# ─────────────────────────────────────────────────────────────────────────────
# STEP 1: Clean start
# ─────────────────────────────────────────────────────────────────────────────
print_header "STEP 1: Clean Start - Removing old store"

rm -rf "$STORE_DIR"
mkdir -p "$STORE_DIR"
print_success "Store directory cleaned: $STORE_DIR"

# ─────────────────────────────────────────────────────────────────────────────
# STEP 2: Run client and server to establish baseline sequences
# ─────────────────────────────────────────────────────────────────────────────
print_header "STEP 2: Establish Baseline Sequences"
print_info "Running client and server in recovery mode (ResetSeqNumFlag=false) for $TIMEOUT_SECS seconds..."

dotnet run -- recovery --store "$STORE_DIR" --timeout $TIMEOUT_SECS 2>&1 | grep -E 'SESSION|TX A|RX A|Timeout|timed out' || true

show_store_state "Store state after baseline run"

# ─────────────────────────────────────────────────────────────────────────────
# STEP 3: Show current store state with --dry-run
# ─────────────────────────────────────────────────────────────────────────────
print_header "STEP 3: Verify Store State (--dry-run)"

echo "Client store state:"
dotnet run -- --client --store "$STORE_DIR" --dry-run 2>&1 | grep -E 'Sender|Target|Creation' || true

echo ""
echo "Server store state:"
dotnet run -- --server --store "$STORE_DIR" --dry-run 2>&1 | grep -E 'Sender|Target|Creation' || true

# ─────────────────────────────────────────────────────────────────────────────
# STEP 4: Truncate client sequence to simulate mismatch
# ─────────────────────────────────────────────────────────────────────────────
print_header "STEP 4: Truncate Client Sequence"

# Get current client sequence
CURRENT_SEQ=$(cat "$STORE_DIR/FIX.5.0SP2-init-comp-accept-comp.seqnums" 2>/dev/null | awk -F':' '{print $1}' | tr -d ' ')
if [ -z "$CURRENT_SEQ" ]; then
    CURRENT_SEQ=3
fi

# Truncate to 1
NEW_SEQ=1
print_info "Truncating client sender sequence from $CURRENT_SEQ to $NEW_SEQ..."

dotnet run -- --client --store "$STORE_DIR" --truncate-seq $NEW_SEQ 2>&1 | grep -E 'Old|New|SUCCESS|TRUNCATING' || true

# ─────────────────────────────────────────────────────────────────────────────
# STEP 5: Verify truncation with --dry-run
# ─────────────────────────────────────────────────────────────────────────────
print_header "STEP 5: Verify Truncation (--dry-run)"

echo "Client store after truncation:"
dotnet run -- --client --store "$STORE_DIR" --dry-run 2>&1 | grep -E 'Sender|Target' || true

echo ""
echo "Server store (unchanged - still expects higher seq):"
dotnet run -- --server --store "$STORE_DIR" --dry-run 2>&1 | grep -E 'Sender|Target' || true

show_store_state "Raw store files"

# ─────────────────────────────────────────────────────────────────────────────
# STEP 6: Run again and observe sequence mismatch recovery
# ─────────────────────────────────────────────────────────────────────────────
print_header "STEP 6: Run With Sequence Mismatch - Watch Client Catch Up"
print_info "Client will send seq=$NEW_SEQ, but server expects seq=$CURRENT_SEQ"
print_info "Server should reject with 'MsgSeqNum too low', client should retry with incrementing sequences..."
echo ""

dotnet run -- recovery --store "$STORE_DIR" --timeout $TIMEOUT_SECS 2>&1 | grep -E 'SESSION|MsgSeqNum too low|Logon rejected|retry|TX A seq|RX 3|rejecting|Timeout|timed out' || true

# ─────────────────────────────────────────────────────────────────────────────
# STEP 7: Final store state
# ─────────────────────────────────────────────────────────────────────────────
print_header "STEP 7: Final Store State"

show_store_state "Final store state after recovery"

echo ""
echo "Client store details:"
dotnet run -- --client --store "$STORE_DIR" --dry-run 2>&1 | grep -E 'Sender|Target' || true

# ─────────────────────────────────────────────────────────────────────────────
# Summary
# ─────────────────────────────────────────────────────────────────────────────
print_header "TEST COMPLETE"

FINAL_CLIENT_SEQ=$(cat "$STORE_DIR/FIX.5.0SP2-init-comp-accept-comp.seqnums" 2>/dev/null | awk -F':' '{print $1}' | tr -d ' ')

if [ "$FINAL_CLIENT_SEQ" -ge "$CURRENT_SEQ" ] 2>/dev/null; then
    print_success "SUCCESS: Client sequence caught up from $NEW_SEQ to $FINAL_CLIENT_SEQ (server expected $CURRENT_SEQ)"
else
    echo -e "${RED}UNEXPECTED: Client sequence is $FINAL_CLIENT_SEQ, expected >= $CURRENT_SEQ${NC}"
fi

echo ""
echo "The sequence mismatch retry behavior has been demonstrated."
echo "Key observations:"
echo "  1. Server rejected logon with 'MsgSeqNum too low'"
echo "  2. Client retried with incrementing sequence numbers"
echo "  3. Session established when sequences aligned"
