#!/bin/bash

# Soak test script - runs server and client in skeleton mode with logging

echo "Stopping any existing instances..."
pkill -f "TradeCaptureDemo" 2>/dev/null || true
sleep 1

echo "Starting server..."
dotnet run -- --skeleton --server --log &
SERVER_PID=$!

sleep 2

echo "Starting client..."
dotnet run -- --skeleton --client --log &
CLIENT_PID=$!

echo ""
echo "Soak test running:"
echo "  Server PID: $SERVER_PID"
echo "  Client PID: $CLIENT_PID"
echo "  Logs: $(pwd)/bin/Debug/net9.0/logs/"
echo ""
echo "Press Ctrl+C to stop both..."

# Wait for either to exit
wait $SERVER_PID $CLIENT_PID
