using Trijinx.Audio.Common;
using Trijinx.Horizon.Common;
using Trijinx.Horizon.Sdk.Applet;
using Trijinx.Horizon.Sdk.Sf;
using System;

namespace Trijinx.Horizon.Sdk.Audio.Detail
{
    interface IAudioInManager : IServiceObject
    {
        Result ListAudioIns(out int count, Span<DeviceName> names);
        Result OpenAudioIn(
            out AudioOutputConfiguration outputConfig,
            out IAudioIn audioIn,
            Span<DeviceName> outName,
            AudioInputConfiguration parameter,
            AppletResourceUserId appletResourceId,
            int processHandle,
            ReadOnlySpan<DeviceName> name,
            ulong pid);
        Result ListAudioInsAuto(out int count, Span<DeviceName> names);
        Result OpenAudioInAuto(
            out AudioOutputConfiguration outputConfig,
            out IAudioIn audioIn,
            Span<DeviceName> outName,
            AudioInputConfiguration parameter,
            AppletResourceUserId appletResourceId,
            int processHandle,
            ReadOnlySpan<DeviceName> name,
            ulong pid);
        Result ListAudioInsAutoFiltered(out int count, Span<DeviceName> names);
        Result OpenAudioInProtocolSpecified(
            out AudioOutputConfiguration outputConfig,
            out IAudioIn audioIn,
            Span<DeviceName> outName,
            AudioInProtocol protocol,
            AudioInputConfiguration parameter,
            AppletResourceUserId appletResourceId,
            int processHandle,
            ReadOnlySpan<DeviceName> name,
            ulong pid);
    }
}
