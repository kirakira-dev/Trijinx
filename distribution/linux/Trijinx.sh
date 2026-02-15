#!/bin/sh

SCRIPT_DIR=$(dirname "$(realpath "$0")")

if [ -f "$SCRIPT_DIR/Trijinx.Headless.SDL3" ]; then
    TRIJINX_BIN="Trijinx.Headless.SDL3"
fi

if [ -f "$SCRIPT_DIR/Trijinx" ]; then
    TRIJINX_BIN="Trijinx"
fi

if [ -z "$TRIJINX_BIN" ]; then
    exit 1
fi

COMMAND="env LANG=C.UTF-8 DOTNET_EnableAlternateStackCheck=1"

if command -v gamemoderun > /dev/null 2>&1; then
    COMMAND="$COMMAND gamemoderun"
fi

exec $COMMAND "$SCRIPT_DIR/$TRIJINX_BIN" "$@"
