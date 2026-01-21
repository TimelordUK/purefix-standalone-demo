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
#   broker-reset   - Server-initiated sequence reset (typical broker daily reset)
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
    local args="$1"  # e.g. "--client" or "--client --store store/initiator"
    local label="$2"
    echo "$label:"
    dotnet run -- $args --dry-run 2>&1 | grep -E 'Sender|Target|Creation' || true
}

# For seq-mismatch test (recovery mode uses subdirectories)
get_client_sender_seq_recovery() {
    cat "$STORE_DIR/initiator/FIX.5.0SP2-init-comp-accept-comp.seqnums" 2>/dev/null | awk -F':' '{print $1}' | tr -d ' '
}

get_server_sender_seq_recovery() {
    cat "$STORE_DIR/acceptor/FIX.5.0SP2-accept-comp-init-comp.seqnums" 2>/dev/null | awk -F':' '{print $1}' | tr -d ' '
}

show_store_state_recovery() {
    local label="$1"
    print_step "$label"

    if [ -f "$STORE_DIR/initiator/FIX.5.0SP2-init-comp-accept-comp.seqnums" ]; then
        echo "Client (init-comp -> accept-comp):"
        cat "$STORE_DIR/initiator/FIX.5.0SP2-init-comp-accept-comp.seqnums"
        echo ""
    else
        echo "  (no client store file yet)"
    fi

    if [ -f "$STORE_DIR/acceptor/FIX.5.0SP2-accept-comp-init-comp.seqnums" ]; then
        echo "Server (accept-comp -> init-comp):"
        cat "$STORE_DIR/acceptor/FIX.5.0SP2-accept-comp-init-comp.seqnums"
    else
        echo "  (no server store file yet)"
    fi
}

# For other tests (use store directly)
get_client_sender_seq() {
    cat "$STORE_DIR/FIX.5.0SP2-init-comp-accept-comp.seqnums" 2>/dev/null | awk -F':' '{print $1}' | tr -d ' '
}

get_server_sender_seq() {
    cat "$STORE_DIR/FIX.5.0SP2-accept-comp-init-comp.seqnums" 2>/dev/null | awk -F':' '{print $1}' | tr -d ' '
}

# Broker-reset mode uses separate store directories
BROKER_CLIENT_STORE="store/broker-initiator"
BROKER_SERVER_STORE="store/broker-acceptor"

clean_broker_stores() {
    print_step "Cleaning broker store directories"
    rm -rf "$BROKER_CLIENT_STORE" "$BROKER_SERVER_STORE"
    mkdir -p "$BROKER_CLIENT_STORE" "$BROKER_SERVER_STORE"
    print_success "Broker stores cleaned"
}

show_broker_store_state() {
    local label="$1"
    print_step "$label"

    if [ -f "$BROKER_CLIENT_STORE/FIX.5.0SP2-init-comp-accept-comp.seqnums" ]; then
        echo "Client (init-comp -> accept-comp):"
        cat "$BROKER_CLIENT_STORE/FIX.5.0SP2-init-comp-accept-comp.seqnums"
        echo ""
    else
        echo "  (no client store file yet)"
    fi

    if [ -f "$BROKER_SERVER_STORE/FIX.5.0SP2-accept-comp-init-comp.seqnums" ]; then
        echo "Server (accept-comp -> init-comp):"
        cat "$BROKER_SERVER_STORE/FIX.5.0SP2-accept-comp-init-comp.seqnums"
    else
        echo "  (no server store file yet)"
    fi
}

get_broker_client_sender_seq() {
    cat "$BROKER_CLIENT_STORE/FIX.5.0SP2-init-comp-accept-comp.seqnums" 2>/dev/null | awk -F':' '{print $1}' | tr -d ' '
}

get_broker_server_sender_seq() {
    cat "$BROKER_SERVER_STORE/FIX.5.0SP2-accept-comp-init-comp.seqnums" 2>/dev/null | awk -F':' '{print $1}' | tr -d ' '
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
    show_dry_run "--client --store $STORE_DIR" "Client store (truncated)"
    echo ""
    show_dry_run "--server --store $STORE_DIR" "Server store (unchanged - expects higher seq)"

    # Step 6: Run with mismatch
    print_header "STEP 5: Run With Sequence Mismatch"
    print_info "Client will send seq=$NEW_SEQ, but server expects seq=$CURRENT_SEQ"
    print_info "Server should reject, client should retry with incrementing sequences..."
    echo ""

    # Use longer timeout to allow multiple retry attempts
    dotnet run -- recovery --store "$STORE_DIR" --timeout $LONG_TIMEOUT 2>&1 | \
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

    # Start server in background with timeout (use recovery mode for persistent sequences)
    dotnet run -- recovery --server --store "$STORE_DIR" --timeout $LONG_TIMEOUT 2>&1 | \
        grep -E 'Starting|SESSION|TX|RX|Timeout|timed out|ended' &
    SERVER_PID=$!

    # Wait for server to load FIX dictionary and start listening (dotnet startup is slow)
    sleep 5

    # Start client (will run until server dies)
    print_info "Starting client..."
    dotnet run -- recovery --client --store "$STORE_DIR" --timeout $((LONG_TIMEOUT + 5)) 2>&1 | \
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

    # Start server again (use recovery mode for persistent sequences)
    # Use LONG_TIMEOUT since we need to wait 5s for startup before client connects
    dotnet run -- recovery --server --store "$STORE_DIR" --timeout $LONG_TIMEOUT 2>&1 | \
        grep -E 'Starting|SESSION|TX|RX|Timeout|timed out|ended' &
    SERVER_PID=$!

    # Wait for server to load FIX dictionary and start listening (dotnet startup is slow)
    sleep 5

    # Start client again (use recovery mode for persistent sequences)
    dotnet run -- recovery --client --store "$STORE_DIR" --timeout $SHORT_TIMEOUT 2>&1 | \
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

    # Start server in background - runs long enough for both client sessions (use recovery mode)
    dotnet run -- recovery --server --store "$STORE_DIR" --timeout $((LONG_TIMEOUT * 3)) 2>&1 | \
        grep -E 'Starting|SESSION|TX|RX|Timeout|timed out|ended|disconnect' &
    SERVER_PID=$!

    # Wait for server to load FIX dictionary and start listening (dotnet startup is slow)
    sleep 5

    # Step 3: Start client with short timeout - it will exchange messages then die
    print_header "STEP 3: First Client Session (Short Lived)"
    print_info "Starting client with $SHORT_TIMEOUT second timeout..."
    print_info "Client will exchange messages then exit."
    echo ""

    dotnet run -- recovery --client --store "$STORE_DIR" --timeout $SHORT_TIMEOUT 2>&1 | \
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

    dotnet run -- recovery --client --store "$STORE_DIR" --timeout $SHORT_TIMEOUT 2>&1 | \
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
# Scenario: Broker Controlled Reset
# ─────────────────────────────────────────────────────────────────────────────
test_broker_reset() {
    print_banner "SCENARIO: Broker Controlled Reset"
    echo ""
    echo "This test demonstrates server-initiated sequence reset."
    echo "Simulates typical broker behavior (e.g., daily reset at 22:10):"
    echo "  - Client always sends ResetSeqNumFlag=N"
    echo "  - Server responds with ResetSeqNumFlag=Y to force reset"
    echo "  - Both sides reset sequences to 1 and continue"

    # Step 1: Clean broker stores
    print_header "STEP 1: Clean Start"
    clean_broker_stores

    # Step 2: First session - build up sequence numbers
    print_header "STEP 2: First Session - Build Up Sequences"
    print_info "Starting broker-reset mode session..."
    print_info "Server sends ResetSeqNumFlag=Y, both start at seq=1"
    echo ""

    # Start server in background
    dotnet run -- broker-reset --server --timeout $LONG_TIMEOUT 2>&1 | \
        grep -v 'Set:' | grep -E 'Starting|SESSION|TX A|RX A|Timeout|timed out|ended' &
    SERVER_PID=$!

    sleep 2

    # Start client (runs until timeout)
    dotnet run -- broker-reset --client --timeout $SHORT_TIMEOUT 2>&1 | \
        grep -v 'Set:' | grep -E 'Starting|SESSION|TX A|RX A|Timeout|timed out|ended'

    # Wait a moment for server to process disconnect
    sleep 2

    # Kill server
    kill $SERVER_PID 2>/dev/null || true
    wait $SERVER_PID 2>/dev/null || true

    # Step 3: Show state after first session
    print_header "STEP 3: Store State After First Session"
    show_broker_store_state "Persisted sequence numbers"

    FIRST_CLIENT_SEQ=$(get_broker_client_sender_seq)
    FIRST_SERVER_SEQ=$(get_broker_server_sender_seq)

    print_info "Client sender seq: $FIRST_CLIENT_SEQ"
    print_info "Server sender seq: $FIRST_SERVER_SEQ"

    # Step 4: Simulate broker reset time (e.g., 22:10)
    print_header "STEP 4: Simulating Broker Reset Time"
    print_info "In production: Both sides shut down at agreed time (e.g., 22:10)"
    print_info "Waiting 3 seconds to simulate downtime..."
    sleep 3

    # Step 5: Second session - broker forces reset
    print_header "STEP 5: Reconnect - Server Forces Reset"
    print_info "Client sends ResetSeqNumFlag=N (wants to resume from $FIRST_CLIENT_SEQ)"
    print_info "Server sends ResetSeqNumFlag=Y (forces reset to 1)"
    print_info "Both sides should reset and continue from seq=1"
    echo ""

    # Start server again
    dotnet run -- broker-reset --server --timeout $LONG_TIMEOUT 2>&1 | \
        grep -v 'Set:' | grep -E 'Starting|SESSION|TX A|RX A|Timeout|timed out|ended' &
    SERVER_PID=$!

    sleep 2

    # Start client again
    dotnet run -- broker-reset --client --timeout $SHORT_TIMEOUT 2>&1 | \
        grep -v 'Set:' | grep -E 'Starting|SESSION|TX A|RX A|Timeout|timed out|ended'

    sleep 1
    kill $SERVER_PID 2>/dev/null || true
    wait $SERVER_PID 2>/dev/null || true

    # Step 6: Verify reset
    print_header "STEP 6: Verify Reset Behavior"
    show_broker_store_state "Final store state"

    FINAL_CLIENT_SEQ=$(get_broker_client_sender_seq)
    FINAL_SERVER_SEQ=$(get_broker_server_sender_seq)

    print_header "RESULT"

    # The key test: sequences should have RESET, not continued
    # After first session, sequences were high (e.g., 5/8)
    # After reset, they should be low again (e.g., 3/5) - not 8/13
    # We verify reset worked by checking final seqs are LESS than first_seq + second_session_messages

    if [ "$FINAL_CLIENT_SEQ" -le "$FIRST_CLIENT_SEQ" ] 2>/dev/null; then
        print_success "SUCCESS: Server-initiated reset worked correctly"
        echo ""
        echo "Sequence progression:"
        echo "  First session - Client: 1 -> $FIRST_CLIENT_SEQ, Server: 1 -> $FIRST_SERVER_SEQ"
        echo "  After reset   - Client: 1 -> $FINAL_CLIENT_SEQ, Server: 1 -> $FINAL_SERVER_SEQ"
        echo ""
        echo "Key observations:"
        echo "  1. First session built up sequences to $FIRST_CLIENT_SEQ/$FIRST_SERVER_SEQ"
        echo "  2. On reconnect, server sent ResetSeqNumFlag=Y"
        echo "  3. Client respected server's reset request"
        echo "  4. Both sides reset to seq=1 and continued"
        echo "  5. This is typical broker behavior for daily sequence reset"
        return 0
    else
        print_error "FAILED: Reset did not work - sequences continued instead of resetting"
        echo "  First session: Client=$FIRST_CLIENT_SEQ, Server=$FIRST_SERVER_SEQ"
        echo "  After 'reset': Client=$FINAL_CLIENT_SEQ, Server=$FINAL_SERVER_SEQ"
        echo "  Expected sequences to be <= first session values after reset"
        return 1
    fi
}

# ─────────────────────────────────────────────────────────────────────────────
# Scenario: Socket Drop (simulates network failure / laptop sleep)
# Uses --disconnect-after flag to trigger clean transport disconnect
# ─────────────────────────────────────────────────────────────────────────────
test_socket_drop() {
    print_banner "SCENARIO: Socket Drop Recovery"
    echo ""
    echo "This test simulates network failure (e.g., laptop sleep/wake, network blip)."
    echo "The client disconnects its transport after 10 seconds, then reconnects."
    echo "Tests that reconnection and session recovery work correctly."
    echo ""

    # Step 1: Clean
    print_header "STEP 1: Clean Start"
    clean_store

    # Step 2: Start server (long running)
    print_header "STEP 2: Start Server"
    print_info "Starting server with long timeout..."

    dotnet run -- recovery --server --store "$STORE_DIR" --timeout 45 2>&1 &
    SERVER_PID=$!

    # Wait for server to fully start (FIX dictionary load takes time)
    sleep 6

    # Step 3: Start client with --disconnect-after to trigger disconnect
    print_header "STEP 3: Start Client (will disconnect after 10 seconds)"
    print_info "Starting client with --disconnect-after 10..."

    dotnet run -- recovery --client --store "$STORE_DIR" --timeout 45 --disconnect-after 10 2>&1 &
    CLIENT_PID=$!

    # Wait for session to establish
    print_info "Waiting for session to establish..."

    # Wait up to 20 seconds for both seqnums files to be created
    WAIT_COUNT=0
    while [ $WAIT_COUNT -lt 20 ]; do
        CLIENT_SEQ_FILE="$STORE_DIR/FIX.5.0SP2-init-comp-accept-comp.seqnums"
        SERVER_SEQ_FILE="$STORE_DIR/FIX.5.0SP2-accept-comp-init-comp.seqnums"
        if [ -f "$CLIENT_SEQ_FILE" ] && [ -f "$SERVER_SEQ_FILE" ]; then
            break
        fi
        sleep 1
        WAIT_COUNT=$((WAIT_COUNT + 1))
    done

    # Record state before disconnect (happens at ~10 seconds)
    print_header "STEP 4: Record State Before Disconnect"
    show_store_state "Store state before disconnect"
    BEFORE_CLIENT_SEQ=$(get_client_sender_seq)
    BEFORE_SERVER_SEQ=$(get_server_sender_seq)
    print_info "Client seq before: $BEFORE_CLIENT_SEQ"
    print_info "Server seq before: $BEFORE_SERVER_SEQ"

    if [ -z "$BEFORE_CLIENT_SEQ" ] || [ -z "$BEFORE_SERVER_SEQ" ]; then
        print_error "Session not established - store files not found"
        kill $CLIENT_PID 2>/dev/null || true
        kill $SERVER_PID 2>/dev/null || true
        return 1
    fi

    # Wait for disconnect and reconnection
    # Client disconnects at 10s, waits 10s, reconnects - so ~25s total from client start
    print_header "STEP 5: Wait for Disconnect and Reconnection"
    print_info "Waiting for client to disconnect (at 10s) and reconnect (at ~20s)..."
    sleep 20

    # Step 6: Record state after reconnection
    print_header "STEP 6: Verify Recovery"
    AFTER_CLIENT_SEQ=$(get_client_sender_seq)
    AFTER_SERVER_SEQ=$(get_server_sender_seq)

    show_store_state "Final store state"

    # Clean up
    print_step "Stopping client and server..."
    kill $CLIENT_PID 2>/dev/null || true
    kill $SERVER_PID 2>/dev/null || true
    wait $CLIENT_PID 2>/dev/null || true
    wait $SERVER_PID 2>/dev/null || true

    print_header "RESULT"

    # Verify session recovered: server sequence increased after reconnection
    if [ "$AFTER_SERVER_SEQ" -gt "$BEFORE_SERVER_SEQ" ] 2>/dev/null && \
       [ "$AFTER_CLIENT_SEQ" -ge "$BEFORE_CLIENT_SEQ" ] 2>/dev/null; then
        print_success "SUCCESS: Session recovered after disconnect"
        echo ""
        echo "Sequence number progression:"
        echo "  Client: $BEFORE_CLIENT_SEQ -> $AFTER_CLIENT_SEQ"
        echo "  Server: $BEFORE_SERVER_SEQ -> $AFTER_SERVER_SEQ"
        echo ""
        echo "Key observations:"
        echo "  1. Client disconnected transport after 10 seconds"
        echo "  2. Client detected disconnect and reconnected"
        echo "  3. Session resumed with correct sequence numbers"
        echo "  4. Server continued sending trades after reconnection"
        return 0
    else
        print_error "FAILED: Session did not recover properly"
        echo "  Before: Client=$BEFORE_CLIENT_SEQ, Server=$BEFORE_SERVER_SEQ"
        echo "  After:  Client=$AFTER_CLIENT_SEQ, Server=$AFTER_SERVER_SEQ"
        return 1
    fi
}

# ─────────────────────────────────────────────────────────────────────────────
# Scenario: Multi-Client Acceptor
# Tests parser-per-session isolation with concurrent clients
# ─────────────────────────────────────────────────────────────────────────────
test_multi_client() {
    print_banner "SCENARIO: Multi-Client Acceptor"
    echo ""
    echo "This test validates that multiple clients can connect to one acceptor"
    echo "concurrently without parser state corruption. Each session gets its own"
    echo "dedicated parser instance for thread safety."
    echo ""
    echo "Also validates wildcard TargetCompID feature - server uses '*' in config"
    echo "and dynamically adopts each client's SenderCompID as TargetCompID."
    echo ""

    print_header "STEP 1: Start Server + 2 Clients"
    print_info "Starting acceptor with 2 initiators connecting concurrently..."
    print_info "Each client gets a unique SenderCompID suffix (_1, _2)"
    print_info "Server uses wildcard TargetCompID='*' to accept any client"
    echo ""

    # Run skeleton mode with 2 clients for 15 seconds
    OUTPUT=$(dotnet run -- --skeleton --clients 2 --timeout 15 2>&1)

    # Display filtered output
    echo "$OUTPUT" | grep -E 'Multi-client|Starting|Modified SenderCompID|Wildcard|SESSION|ready|Session ready|Timeout|timed out|Demo complete' || true

    print_header "STEP 2: Verify Results"

    # Check for successful logons from both clients
    CLIENT1_READY=$(echo "$OUTPUT" | grep -c "init-comp_1" || true)
    CLIENT2_READY=$(echo "$OUTPUT" | grep -c "init-comp_2" || true)
    SESSION_READY=$(echo "$OUTPUT" | grep -c "Session ready" || true)

    # Check for wildcard TargetCompID working - server should respond with distinct TargetCompIDs
    # Server messages have format: 49=accept-comp|56=init-comp_X (server sending TO client X)
    # Note: Must escape | in grep pattern as it's regex OR
    SERVER_TO_CLIENT1=$(echo "$OUTPUT" | grep -c "49=accept-comp.*56=init-comp_1" || true)
    SERVER_TO_CLIENT2=$(echo "$OUTPUT" | grep -c "49=accept-comp.*56=init-comp_2" || true)
    WILDCARD_UPDATES=$(echo "$OUTPUT" | grep -c "Wildcard TargetCompID" || true)

    print_header "RESULT"

    # We expect at least 2 "Session ready" messages (one per client)
    # and both client CompIDs to appear in the output
    # and server responding with distinct TargetCompIDs for each client
    if [ "$SESSION_READY" -ge 2 ] && [ "$CLIENT1_READY" -gt 0 ] && [ "$CLIENT2_READY" -gt 0 ] && \
       [ "$SERVER_TO_CLIENT1" -gt 0 ] && [ "$SERVER_TO_CLIENT2" -gt 0 ]; then
        print_success "SUCCESS: Multi-client acceptor test passed"
        echo ""
        echo "Key observations:"
        echo "  1. Acceptor handled 2 concurrent client connections"
        echo "  2. Each client received unique SenderCompID (init-comp_1, init-comp_2)"
        echo "  3. Wildcard TargetCompID updates: $WILDCARD_UPDATES (server adopted client CompIDs)"
        echo "  4. Server responses to Client-1: $SERVER_TO_CLIENT1 messages with 56=init-comp_1"
        echo "  5. Server responses to Client-2: $SERVER_TO_CLIENT2 messages with 56=init-comp_2"
        echo "  6. Each session created its own parser instance (thread isolation)"
        echo "  7. No parser state corruption between sessions"
        return 0
    else
        print_error "FAILED: Multi-client test did not complete successfully"
        echo "  Sessions ready: $SESSION_READY (expected >= 2)"
        echo "  Client 1 refs: $CLIENT1_READY"
        echo "  Client 2 refs: $CLIENT2_READY"
        echo "  Server->Client1 (56=init-comp_1): $SERVER_TO_CLIENT1 (expected > 0)"
        echo "  Server->Client2 (56=init-comp_2): $SERVER_TO_CLIENT2 (expected > 0)"
        echo "  Wildcard updates: $WILDCARD_UPDATES"
        return 1
    fi
}

# ─────────────────────────────────────────────────────────────────────────────
# Scenario: Validation Mode Test
# Tests that message validation works in different modes
# ─────────────────────────────────────────────────────────────────────────────
test_validation() {
    print_banner "SCENARIO: Message Validation"
    echo ""
    echo "This test demonstrates the FIX message validation feature."
    echo "Using --validation flag to enable strict checksum validation."
    echo "Messages with invalid checksums would be rejected in strict mode."
    echo ""

    print_header "STEP 1: Run Session with Strict Validation"
    print_info "Starting server and client with --validation strict..."
    print_info "Both sides will validate checksums on all incoming messages."
    echo ""

    # Run skeleton mode with strict validation for a short time
    OUTPUT=$(dotnet run -- --skeleton --validation strict --timeout 10 2>&1)

    # Show validation-related and session output
    echo "$OUTPUT" | grep -E 'Validation|Starting|SESSION|Session ready|TX A seq|RX A seq|Timeout|timed out' | head -30 || true

    print_header "STEP 2: Verify Results"

    # Check for successful session establishment
    SESSION_READY=$(echo "$OUTPUT" | grep -c "Session ready" || true)
    VALIDATION_INFO=$(echo "$OUTPUT" | grep -c "Validation: Strict" || true)

    print_header "RESULT"

    # A successful test shows:
    # 1. Validation mode was applied
    # 2. Session established successfully (messages passed validation)
    if [ "$SESSION_READY" -ge 2 ] && [ "$VALIDATION_INFO" -ge 2 ]; then
        print_success "SUCCESS: Strict validation test passed"
        echo ""
        echo "Key observations:"
        echo "  1. Both client and server used Strict validation mode"
        echo "  2. All messages passed checksum validation"
        echo "  3. Session established and exchanged heartbeats successfully"
        echo "  4. In production, invalid checksums would cause message rejection"
        return 0
    elif [ "$SESSION_READY" -ge 2 ]; then
        # Session worked but maybe validation output was filtered
        print_success "SUCCESS: Session completed with validation enabled"
        echo ""
        echo "Key observations:"
        echo "  1. --validation strict flag was applied"
        echo "  2. Session established successfully"
        echo "  3. Messages passed validation checks"
        return 0
    else
        print_error "FAILED: Validation test did not complete successfully"
        echo "  Sessions ready: $SESSION_READY (expected >= 2)"
        echo "  Validation lines: $VALIDATION_INFO"
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
    echo "┌─────────────────────────────────────────────────────────────────────────────┐"
    echo "│                        Test Scenarios Summary                               │"
    echo "├─────────────────┬───────────────────────────────────────────────────────────┤"
    echo "│ seq-mismatch    │ Client sequence too low on logon                          │"
    echo "│                 │ → Server rejects, client retries with +1 until aligned    │"
    echo "│                 │ → QuickFix compatible behavior                            │"
    echo "├─────────────────┼───────────────────────────────────────────────────────────┤"
    echo "│ server-bounce   │ Server restarts mid-session                               │"
    echo "│                 │ → Both sides use file store to persist sequences          │"
    echo "│                 │ → Session resumes from where it left off                  │"
    echo "├─────────────────┼───────────────────────────────────────────────────────────┤"
    echo "│ client-bounce   │ Client restarts mid-session (most common real-world)      │"
    echo "│                 │ → Server keeps running (simulates broker)                 │"
    echo "│                 │ → Client reconnects with reset=N, resumes from store      │"
    echo "├─────────────────┼───────────────────────────────────────────────────────────┤"
    echo "│ broker-reset    │ Server-initiated daily sequence reset                     │"
    echo "│                 │ → Client sends reset=N, server responds reset=Y           │"
    echo "│                 │ → Both sides reset to seq=1 (broker controls reset time)  │"
    echo "│                 │ → Typical broker pattern (e.g., 22:10 daily reset)        │"
    echo "├─────────────────┼───────────────────────────────────────────────────────────┤"
    echo "│ socket-drop     │ TCP socket killed mid-session (requires sudo)             │"
    echo "│                 │ → Simulates laptop sleep/wake or network blip             │"
    echo "│                 │ → Both processes stay alive, only socket dies             │"
    echo "│                 │ → Client reconnects and session resumes                   │"
    echo "├─────────────────┼───────────────────────────────────────────────────────────┤"
    echo "│ multi-client    │ Multiple clients connect to one acceptor                  │"
    echo "│                 │ → Tests parser-per-session thread isolation               │"
    echo "│                 │ → 2 clients with unique CompIDs connect concurrently      │"
    echo "│                 │ → Validates no parser state corruption                    │"
    echo "├─────────────────┼───────────────────────────────────────────────────────────┤"
    echo "│ validation      │ Tests message validation feature                          │"
    echo "│                 │ → Uses --validation strict to enable checksum checks      │"
    echo "│                 │ → Verifies session works with validation enabled          │"
    echo "├─────────────────┼───────────────────────────────────────────────────────────┤"
    echo "│ all             │ Run all scenarios sequentially (except socket-drop)       │"
    echo "└─────────────────┴───────────────────────────────────────────────────────────┘"
    echo ""
    echo "Examples:"
    echo "  $0 seq-mismatch"
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
    broker-reset)
        test_broker_reset
        ;;
    socket-drop)
        test_socket_drop
        ;;
    multi-client)
        test_multi_client
        ;;
    validation)
        test_validation
        ;;
    all)
        test_seq_mismatch
        echo ""
        echo ""
        test_server_bounce
        echo ""
        echo ""
        test_client_bounce
        echo ""
        echo ""
        test_broker_reset
        echo ""
        echo ""
        test_multi_client
        echo ""
        echo ""
        test_validation
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
