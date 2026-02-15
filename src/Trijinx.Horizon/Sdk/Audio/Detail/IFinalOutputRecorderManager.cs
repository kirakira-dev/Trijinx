using Trijinx.Horizon.Common;
using Trijinx.Horizon.Sdk.Applet;
using Trijinx.Horizon.Sdk.Sf;

namespace Trijinx.Horizon.Sdk.Audio.Detail
{
    interface IFinalOutputRecorderManager : IServiceObject
    {
        Result OpenFinalOutputRecorder(
            out IFinalOutputRecorder recorder,
            FinalOutputRecorderParameter parameter,
            int processHandle,
            out FinalOutputRecorderParameterInternal outParameter,
            AppletResourceUserId appletResourceId);
    }
}
