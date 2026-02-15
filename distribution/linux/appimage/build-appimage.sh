#!/bin/sh
set -eu

ROOTDIR="$(readlink -f "$(dirname "$0")")"/../../../
cd "$ROOTDIR"

BUILDDIR=${BUILDDIR:-publish}
OUTDIR=${OUTDIR:-publish_appimage}

rm -rf AppDir
mkdir -p AppDir/usr/bin

cp distribution/linux/Trijinx.desktop AppDir/Trijinx.desktop
cp distribution/linux/appimage/AppRun AppDir/AppRun
cp distribution/misc/Logo.svg AppDir/Trijinx.svg


cp -r "$BUILDDIR"/* AppDir/usr/bin/

# Ensure necessary bins are set as executable
chmod +x AppDir/AppRun AppDir/usr/bin/Trijinx*

mkdir -p "$OUTDIR"

appimagetool -n --comp zstd --mksquashfs-opt -Xcompression-level --mksquashfs-opt 21 \
    AppDir "$OUTDIR"/Trijinx.AppImage
