# Socket Drop Test Implementation Summary

## Goal
Test session recovery after a mid-session network disconnection (simulating laptop sleep/wake, network blip, etc.).

## What We Tried

### 1. Using `ss -K` (Linux socket killer)
- **Issue**: Doesn't work on WSL2 - the `SOCK_DESTROY` netlink operation isn't implemented in WSL2 kernel
- Command shows output but doesn't actually kill sockets

### 2. Using `tcpkill` (from dsniff package)
- **Installation**: `sudo apt install dsniff`
- **Sudoers**: `echo 'me ALL=(ALL) NOPASSWD: /usr/sbin/tcpkill' | sudo tee /etc/sudoers.d/99-tcpkill-nopasswd`
- **Issues**:
  - Initially used wrong interface (`eth0` instead of `lo` for localhost)
  - Even with `-i lo`, tcpkill keeps sending RST packets continuously
  - Processes get stuck and don't respond to kill signals
  - Multiple runs left zombie tcpkill processes that interfere with new tests

### 3. Final Solution: `--disconnect-after` CLI flag (IMPLEMENTED)
Added a new CLI option to the demo app that triggers a clean transport disconnect after N seconds.

## Implementation Details

### Files Modified

1. **`CliOptions.cs`** - Added new CLI option:
   ```csharp
   public int? DisconnectAfter { get; set; }

   private static readonly Option<int?> DisconnectAfterOption = new(
       name: "--disconnect-after",
       description: "Disconnect transport after N seconds (for testing reconnection)");
   ```

2. **`Program.cs`** - Pass option to DemoClient:
   ```csharp
   DemoClient.DisconnectAfterSeconds = opt.DisconnectAfter;
   ```

3. **`Support/DemoClient.cs`** - Added disconnect timer:
   ```csharp
   public static int? DisconnectAfterSeconds { get; set; }
   private bool _hasScheduledDisconnect;

   // In OnReady():
   if (DisconnectAfterSeconds.HasValue && !_hasScheduledDisconnect)
   {
       _hasScheduledDisconnect = true;
       var seconds = DisconnectAfterSeconds.Value;
       m_logger.Info($"Will disconnect transport in {seconds} seconds");
       _ = Task.Run(async () =>
       {
           await Task.Delay(TimeSpan.FromSeconds(seconds));
           m_logger.Info("Triggering scheduled disconnect");
           Stop();
       });
   }
   ```

4. **`test-scenarios.sh`** - Updated socket-drop test to use new flag:
   ```bash
   dotnet run -- recovery --client --store "$STORE_DIR" --timeout 45 --disconnect-after 10
   ```

## Usage

```bash
# Run just the socket-drop test
./test-scenarios.sh socket-drop

# Or manually test disconnect/reconnect
dotnet run -- recovery --server --store store --timeout 60 &
dotnet run -- recovery --client --store store --timeout 60 --disconnect-after 10
```

The client will:
1. Connect and establish session
2. After 10 seconds, call `Stop()` to disconnect the transport
3. Wait 10 seconds (reconnect delay)
4. Reconnect and resume session with preserved sequence numbers

## Current Blocker

**Stuck tcpkill processes from earlier testing are still running and interfering with port 2345.**

To fix: Restart WSL with `wsl --shutdown` from Windows, then restart.

## After WSL Restart

Run the socket-drop test:
```bash
cd /home/me/dev/cs/purefix-standalone-demo
./test-scenarios.sh socket-drop
```

Expected behavior:
1. Server starts
2. Client connects, exchanges messages
3. Client disconnects after 10 seconds (--disconnect-after)
4. Client waits 10 seconds, then reconnects
5. Session resumes with correct sequence numbers
6. Test verifies server sequence increased (session continued after reconnect)
