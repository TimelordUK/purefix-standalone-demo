# Soak test script - runs server and client in skeleton mode with logging

Write-Host "Stopping any existing instances..."
Get-Process -Name "TradeCaptureDemo" -ErrorAction SilentlyContinue | Stop-Process -Force -ErrorAction SilentlyContinue
Start-Sleep -Seconds 1

Write-Host "Starting server..."
$serverProcess = Start-Process -FilePath "dotnet" -ArgumentList "run", "--", "--skeleton", "--server", "--log" -PassThru -NoNewWindow

Start-Sleep -Seconds 2

Write-Host "Starting client..."
$clientProcess = Start-Process -FilePath "dotnet" -ArgumentList "run", "--", "--skeleton", "--client", "--log" -PassThru -NoNewWindow

Write-Host ""
Write-Host "Soak test running:"
Write-Host "  Server PID: $($serverProcess.Id)"
Write-Host "  Client PID: $($clientProcess.Id)"
Write-Host "  Logs: $PWD\bin\Debug\net9.0\logs\"
Write-Host ""
Write-Host "Press Ctrl+C to stop both..."

# Handle Ctrl+C gracefully
$null = Register-EngineEvent -SourceIdentifier PowerShell.Exiting -Action {
    if (-not $serverProcess.HasExited) { $serverProcess.Kill() }
    if (-not $clientProcess.HasExited) { $clientProcess.Kill() }
}

try {
    # Wait for either process to exit
    while (-not $serverProcess.HasExited -and -not $clientProcess.HasExited) {
        Start-Sleep -Milliseconds 500
    }
}
finally {
    # Cleanup
    if (-not $serverProcess.HasExited) {
        Write-Host "Stopping server..."
        $serverProcess.Kill()
    }
    if (-not $clientProcess.HasExited) {
        Write-Host "Stopping client..."
        $clientProcess.Kill()
    }
}
