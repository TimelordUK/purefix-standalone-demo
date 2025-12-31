#!/bin/bash
#
# Generate self-signed certificates for TLS testing
# Requires: openssl
#

set -e

SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
CERT_DIR="$SCRIPT_DIR/Data/certs"
PASSWORD="${1:-jspurefix}"

echo "================================================"
echo "  PureFix TLS Certificate Generator"
echo "================================================"
echo ""
echo "Output directory: $CERT_DIR"
echo "Password: $PASSWORD"
echo ""

# Check for openssl
if ! command -v openssl &> /dev/null; then
    echo "ERROR: openssl is not installed or not in PATH"
    exit 1
fi

# Create directories
mkdir -p "$CERT_DIR/ca" "$CERT_DIR/server" "$CERT_DIR/client"

echo "Generating CA certificate..."
openssl genrsa -des3 -passout "pass:$PASSWORD" -out "$CERT_DIR/ca/ca.key" 4096 2>/dev/null
openssl req -new -x509 -days 365 -key "$CERT_DIR/ca/ca.key" -out "$CERT_DIR/ca/ca.crt" \
    -passin "pass:$PASSWORD" \
    -subj "/C=US/ST=State/L=City/O=PureFix Demo CA/CN=localhost" 2>/dev/null

echo "Generating server certificate..."
openssl genrsa -out "$CERT_DIR/server/server.key" 4096 2>/dev/null
openssl req -new -key "$CERT_DIR/server/server.key" -out "$CERT_DIR/server/server.csr" \
    -subj "/C=US/ST=State/L=City/O=PureFix Demo/CN=localhost" 2>/dev/null
openssl x509 -req -days 365 -passin "pass:$PASSWORD" \
    -in "$CERT_DIR/server/server.csr" \
    -CA "$CERT_DIR/ca/ca.crt" -CAkey "$CERT_DIR/ca/ca.key" \
    -set_serial 01 -out "$CERT_DIR/server/server.crt" 2>/dev/null
rm "$CERT_DIR/server/server.csr"

echo "Generating client certificate..."
openssl genrsa -out "$CERT_DIR/client/client.key" 4096 2>/dev/null
openssl req -new -key "$CERT_DIR/client/client.key" -out "$CERT_DIR/client/client.csr" \
    -subj "/C=US/ST=State/L=City/O=PureFix Demo/CN=client" 2>/dev/null
openssl x509 -req -days 365 -passin "pass:$PASSWORD" \
    -in "$CERT_DIR/client/client.csr" \
    -CA "$CERT_DIR/ca/ca.crt" -CAkey "$CERT_DIR/ca/ca.key" \
    -set_serial 02 -out "$CERT_DIR/client/client.crt" 2>/dev/null
rm "$CERT_DIR/client/client.csr"

echo "Converting to PFX format (required by .NET)..."
openssl pkcs12 -export -out "$CERT_DIR/server/server.pfx" \
    -inkey "$CERT_DIR/server/server.key" \
    -in "$CERT_DIR/server/server.crt" \
    -passout "pass:$PASSWORD" 2>/dev/null

openssl pkcs12 -export -out "$CERT_DIR/client/client.pfx" \
    -inkey "$CERT_DIR/client/client.key" \
    -in "$CERT_DIR/client/client.crt" \
    -passout "pass:$PASSWORD" 2>/dev/null

echo ""
echo "================================================"
echo "  Certificates generated successfully!"
echo "================================================"
echo ""
echo "Files created:"
echo "  $CERT_DIR/ca/ca.crt"
echo "  $CERT_DIR/server/server.pfx"
echo "  $CERT_DIR/client/client.pfx"
echo ""
echo "Usage:"
echo "  dotnet run -- --tls --skeleton --timeout 10"
echo ""
echo "Note: Password for PFX files is '$PASSWORD'"
echo "      (configure in Data/Session/test-*-tls.json if changed)"
