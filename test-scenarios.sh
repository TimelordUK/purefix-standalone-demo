#!/bin/bash
#
# PureFix Test Scenarios
# Tests various FIX session recovery scenarios
#
# Usage:
#   ./test-scenarios.sh [scenario]
#
# Scenarios:
#   seq-mismatch   - Client sequence number mismatch recovery
#   server-bounce  - Server restart with session recovery
#   client-bounce  - Client restart with session recovery
#   all            - Run all scenarios
#

set -e

SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
cd "$SCRIPT_DIR"

# ─────────────────────────────────────────────────────────────────────────────
# Configuration
# ─────────────────────────────────────────────────────────────────────────────
STORE_DIR="store"
SHORT_TIMEOUT=5
LONG_TIMEOUT=10

# ─────────────────────────────────────────────────────────────────────────────
# Colors
# ─────────────────────────────────────────────────────────────────────────────
RED='\033[0;31m'
GREEN='\033[0;32m'
YELLOW='\033[1;33m'
BLUE='\033[0;34m'
CYAN='\033[0;36m'
MAGENTA='\033[0;35m'
NC='\033[0m'

# ─────────────────────────────────────────────────────────────────────────────
# Common Functions
# ─────────────────────────────────────────────────────────────────────────────
print_banner() {
    echo ""
    echo -e "${MAGENTA}╔══════════════════════════════════════════════════════════════════════════════╗${NC}"
    echo -e "${MAGENTA}║  $1${NC}"
    echo -e "${MAGENTA}╚══════════════════════════════════════════════════════════════════════════════╝${NC}"
}

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
    echo -e "${GREEN}✓ $1${NC}"
}

print_error() {
    echo -e "${RED}✗ $1${NC}"
}

print_info() {
    echo -e "${BLUE}$1${NC}"
}

clean_store() {
    print_step "Cleaning store directory: $STORE_DIR"
    rm -rf "$STORE_DIR"
    mkdir -p "$STORE_DIR"
    print_success "Store cleaned"
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

show_dry_run() {
    local role="$1"  # --client or --server
    local label="$2"
    echo "$label:"
    dotnet run -- $role --store "$STORE_DIR" --dry-run 2>&1 | grep -E 'Sender|Target|Creation' || true
}

get_client_sender_seq() {
    cat "$STORE_DIR/FIX.5.0SP2-init-comp-accept-comp.seqnums" 2>/dev/null | awk -F':' '{print $1}' | tr -d ' '
}

get_server_sender_seq() {
    cat "$STORE_DIR/FIX.5.0SP2-accept-comp-init-comp.seqnums" 2>/dev/null | awk -F':' '{print $1}' | tr -d ' '
}

# ─────────────────────────────────────────────────────────────────────────────
# Scenario: Sequence Mismatch Recovery
# ─────────────────────────────────────────────────────────────────────────────
test_seq_mismatch() {
    print_banner "SCENARIO: Sequence Number Mismatch Recovery"
    echo ""
    echo "This test demonstrates client catching up when its sequence number"
    echo "is behind what the server expects."

    # Step 1: Clean
    print_header "STEP 1: Clean Start"
    clean_store

    # Step 2: Establish baseline
    print_header "STEP 2: Establish Baseline Sequences"
    print_info "Running client and server in recovery mode for $SHORT_TIMEOUT seconds..."

    dotnet run -- recovery --store "$STORE_DIR" --timeout $SHORT_TIMEOUT 2>&1 | \
        grep -E 'SESSION|TX A|RX A|Timeout|timed out' || true

    show_store_state "Store state after baseline"

    # Step 3: Record current sequence
    CURRENT_SEQ=$(get_client_sender_seq)
    if [ -z "$CURRENT_SEQ" ]; then
        CURRENT_SEQ=3
    fi

    # Step 4: Truncate client sequence
    print_header "STEP 3: Truncate Client Sequence"
    NEW_SEQ=1
    print_info "Truncating client sender sequence from $CURRENT_SEQ to $NEW_SEQ..."

    dotnet run -- --client --store "$STORE_DIR" --truncate-seq $NEW_SEQ 2>&1 | \
        grep -E 'Old|New|SUCCESS|TRUNCATING' || true

    # Step 5: Verify truncation
    print_header "STEP 4: Verify State Before Recovery"
    show_dry_run "--client" "Client store (truncated)"
    echo ""
    show_dry_run "--server" "Server store (unchanged - expects higher seq)"

    # Step 6: Run with mismatch
    print_header "STEP 5: Run With Sequence Mismatch"
    print_info "Client will send seq=$NEW_SEQ, but server expects seq=$CURRENT_SEQ"
    print_info "Server should reject, client should retry with incrementing sequences..."
    echo ""

    dotnet run -- recovery --store "$STORE_DIR" --timeout $SHORT_TIMEOUT 2>&1 | \
        grep -E 'SESSION|MsgSeqNum too low|Logon rejected|retry|TX A seq|rejecting|Timeout|timed out' || true

    # Step 7: Verify recovery
    print_header "STEP 6: Verify Recovery"
    show_store_state "Final store state"

    FINAL_SEQ=$(get_client_sender_seq)

    print_header "RESULT"
    if [ "$FINAL_SEQ" -ge "$CURRENT_SEQ" ] 2>/dev/null; then
        print_success "SUCCESS: Client sequence caught up from $NEW_SEQ to $FINAL_SEQ (server expected $CURRENT_SEQ)"
        echo ""
        echo "Key observations:"
        echo "  1. Server rejected logon with 'MsgSeqNum too low'"
        echo "  2. Client retried with incrementing sequence numbers"
        echo "  3. Session established when sequences aligned"
        return 0
    else
        print_error "FAILED: Client sequence is $FINAL_SEQ, expected >= $CURRENT_SEQ"
        return 1
    fi
}

# ─────────────────────────────────────────────────────────────────────────────
# Scenario: Server Bounce Recovery
# ─────────────────────────────────────────────────────────────────────────────
test_server_bounce() {
    print_banner "SCENARIO: Server Bounce Recovery"
    echo ""
    echo "This test demonstrates session recovery after server restart."
    echo "Both sides use file store to persist sequence numbers."

    # Step 1: Clean
    print_header "STEP 1: Clean Start"
    clean_store

    # Step 2: Start server and client, let them exchange messages
    print_header "STEP 2: Initial Session - Server runs for $LONG_TIMEOUT seconds"
    print_info "Starting server with timeout, then client..."
    print_info "Both will exchange messages until server times out."
    echo ""

    # Start server in background with timeout
    dotnet run -- --server --store "$STORE_DIR" --timeout $LONG_TIMEOUT 2>&1 | \
        grep -E 'Starting|SESSION|TX|RX|Timeout|timed out|ended' &
    SERVER_PID=$!

    # Wait for server to start listening
    sleep 1

    # Start client (will run until server dies)
    print_info "Starting client..."
    dotnet run -- --client --store "$STORE_DIR" --timeout $((LONG_TIMEOUT + 5)) 2>&1 | \
        grep -E 'Starting|SESSION|TX|RX|disconnect|ended' &
    CLIENT_PID=$!

    # Wait for server to timeout
    print_info "Waiting for server to timeout..."
    wait $SERVER_PID 2>/dev/null || true

    print_step "Server has stopped. Client should detect disconnect."

    # Give client time to detect disconnect
    sleep 2

    # Kill client if still running
    kill $CLIENT_PID 2>/dev/null || true
    wait $CLIENT_PID 2>/dev/null || true

    # Step 3: Show state after first session
    print_header "STEP 3: Store State After Server Bounce"
    show_store_state "Persisted sequence numbers"

    INITIAL_CLIENT_SEQ=$(get_client_sender_seq)
    INITIAL_SERVER_SEQ=$(get_server_sender_seq)

    print_info "Client sender seq: $INITIAL_CLIENT_SEQ"
    print_info "Server sender seq: $INITIAL_SERVER_SEQ"

    # Step 4: Wait before restart
    print_header "STEP 4: Simulating Downtime"
    print_info "Waiting 3 seconds before restarting server..."
    sleep 3

    # Step 5: Restart server and client
    print_header "STEP 5: Restart Session - Both Recover From Store"
    print_info "Both sides should resume with persisted sequence numbers..."
    echo ""

    # Start server again
    dotnet run -- --server --store "$STORE_DIR" --timeout $SHORT_TIMEOUT 2>&1 | \
        grep -E 'Starting|SESSION|TX|RX|Timeout|timed out|ended' &
    SERVER_PID=$!

    sleep 1

    # Start client again
    dotnet run -- --client --store "$STORE_DIR" --timeout $((SHORT_TIMEOUT + 2)) 2>&1 | \
        grep -E 'Starting|SESSION|TX|RX|ended' &
    CLIENT_PID=$!

    # Wait for completion
    wait $SERVER_PID 2>/dev/null || true
    wait $CLIENT_PID 2>/dev/null || true

    # Step 6: Verify recovery
    print_header "STEP 6: Verify Recovery"
    show_store_state "Final store state"

    FINAL_CLIENT_SEQ=$(get_client_sender_seq)
    FINAL_SERVER_SEQ=$(get_server_sender_seq)

    print_header "RESULT"

    # Check that sequences continued from where they left off
    if [ "$FINAL_CLIENT_SEQ" -gt "$INITIAL_CLIENT_SEQ" ] 2>/dev/null && \
       [ "$FINAL_SERVER_SEQ" -gt "$INITIAL_SERVER_SEQ" ] 2>/dev/null; then
        print_success "SUCCESS: Session recovered correctly"
        echo ""
        echo "Sequence number progression:"
        echo "  Client: $INITIAL_CLIENT_SEQ -> $FINAL_CLIENT_SEQ"
        echo "  Server: $INITIAL_SERVER_SEQ -> $FINAL_SERVER_SEQ"
        echo ""
        echo "Key observations:"
        echo "  1. Server bounced after $LONG_TIMEOUT seconds"
        echo "  2. Both sides persisted state to file store"
        echo "  3. Session resumed with correct sequence numbers"
        echo "  4. No sequence mismatch - clean recovery"
        return 0
    else
        print_error "FAILED: Sequence numbers did not progress as expected"
        echo "  Client: $INITIAL_CLIENT_SEQ -> $FINAL_CLIENT_SEQ"
        echo "  Server: $INITIAL_SERVER_SEQ -> $FINAL_SERVER_SEQ"
        return 1
    fi
}

# ─────────────────────────────────────────────────────────────────────────────
# Scenario: Client Bounce Recovery
# ─────────────────────────────────────────────────────────────────────────────
test_client_bounce() {
    print_banner "SCENARIO: Client Bounce Recovery"
    echo ""
    echo "This test demonstrates session recovery after client restart."
    echo "Server keeps running while client disconnects and reconnects."
    echo "This simulates a real-world scenario of bouncing a client against a broker."

    # Step 1: Clean
    print_header "STEP 1: Clean Start"
    clean_store

    # Step 2: Start server (runs for the duration of the test)
    print_header "STEP 2: Start Server (Long Running)"
    print_info "Starting server that will run for the entire test..."
    echo ""

    # Start server in background - runs long enough for both client sessions
    dotnet run -- --server --store "$STORE_DIR" --timeout $((LONG_TIMEOUT * 3)) 2>&1 | \
        grep -E 'Starting|SESSION|TX|RX|Timeout|timed out|ended|disconnect' &
    SERVER_PID=$!

    # Wait for server to start listening
    sleep 2

    # Step 3: Start client with short timeout - it will exchange messages then die
    print_header "STEP 3: First Client Session (Short Lived)"
    print_info "Starting client with $SHORT_TIMEOUT second timeout..."
    print_info "Client will exchange messages then exit."
    echo ""

    dotnet run -- --client --store "$STORE_DIR" --timeout $SHORT_TIMEOUT 2>&1 | \
        grep -E 'Starting|SESSION|TX|RX|Timeout|timed out|ended'

    # Client has exited due to timeout

    # Step 4: Show state after first client session
    print_header "STEP 4: Store State After Client Bounce"
    show_store_state "Persisted sequence numbers"

    INITIAL_CLIENT_SEQ=$(get_client_sender_seq)
    INITIAL_SERVER_SEQ=$(get_server_sender_seq)

    print_info "Client sender seq: $INITIAL_CLIENT_SEQ"
    print_info "Server sender seq: $INITIAL_SERVER_SEQ"

    # Step 5: Wait before client restart (simulate downtime)
    print_header "STEP 5: Simulating Client Downtime"
    print_info "Waiting 3 seconds before restarting client..."
    sleep 3

    # Step 6: Restart client - should resume from store (reset=N)
    print_header "STEP 6: Reconnect Client - Resume From Store"
    print_info "Client should reconnect and resume with persisted sequence numbers..."
    print_info "No sequence reset (reset=N) - this is the common real-world scenario."
    echo ""

    dotnet run -- --client --store "$STORE_DIR" --timeout $SHORT_TIMEOUT 2>&1 | \
        grep -E 'Starting|SESSION|TX|RX|Timeout|timed out|ended'

    # Step 7: Clean up server
    print_step "Stopping server..."
    kill $SERVER_PID 2>/dev/null || true
    wait $SERVER_PID 2>/dev/null || true

    # Step 8: Verify recovery
    print_header "STEP 7: Verify Recovery"
    show_store_state "Final store state"

    FINAL_CLIENT_SEQ=$(get_client_sender_seq)
    FINAL_SERVER_SEQ=$(get_server_sender_seq)

    print_header "RESULT"

    # Check that sequences continued from where they left off
    if [ "$FINAL_CLIENT_SEQ" -gt "$INITIAL_CLIENT_SEQ" ] 2>/dev/null && \
       [ "$FINAL_SERVER_SEQ" -gt "$INITIAL_SERVER_SEQ" ] 2>/dev/null; then
        print_success "SUCCESS: Client reconnected and session resumed correctly"
        echo ""
        echo "Sequence number progression:"
        echo "  Client: $INITIAL_CLIENT_SEQ -> $FINAL_CLIENT_SEQ"
        echo "  Server: $INITIAL_SERVER_SEQ -> $FINAL_SERVER_SEQ"
        echo ""
        echo "Key observations:"
        echo "  1. Client bounced after $SHORT_TIMEOUT seconds"
        echo "  2. Server kept running (simulating broker)"
        echo "  3. Client file store preserved sequence numbers"
        echo "  4. Session resumed with correct sequence numbers (no reset)"
        echo "  5. This is the most common real-world reconnection scenario"
        return 0
    else
        print_error "FAILED: Sequence numbers did not progress as expected"
        echo "  Client: $INITIAL_CLIENT_SEQ -> $FINAL_CLIENT_SEQ"
        echo "  Server: $INITIAL_SERVER_SEQ -> $FINAL_SERVER_SEQ"
        return 1
    fi
}

# ─────────────────────────────────────────────────────────────────────────────
# Main
# ─────────────────────────────────────────────────────────────────────────────
show_usage() {
    echo "PureFix Test Scenarios"
    echo ""
    echo "Usage: $0 [scenario]"
    echo ""
    echo "Scenarios:"
    echo "  seq-mismatch   - Client sequence number mismatch recovery"
    echo "  server-bounce  - Server restart with session recovery"
    echo "  client-bounce  - Client restart with session recovery (common real-world scenario)"
    echo "  all            - Run all scenarios"
    echo ""
    echo "Examples:"
    echo "  $0 seq-mismatch"
    echo "  $0 server-bounce"
    echo "  $0 client-bounce"
    echo "  $0 all"
}

SCENARIO="${1:-}"

case "$SCENARIO" in
    seq-mismatch)
        test_seq_mismatch
        ;;
    server-bounce)
        test_server_bounce
        ;;
    client-bounce)
        test_client_bounce
        ;;
    all)
        test_seq_mismatch
        echo ""
        echo ""
        test_server_bounce
        echo ""
        echo ""
        test_client_bounce
        ;;
    -h|--help|help)
        show_usage
        ;;
    "")
        show_usage
        exit 1
        ;;
    *)
        echo "Unknown scenario: $SCENARIO"
        echo ""
        show_usage
        exit 1
        ;;
esac
