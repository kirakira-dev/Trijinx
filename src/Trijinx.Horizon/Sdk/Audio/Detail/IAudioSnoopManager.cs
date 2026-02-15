using Trijinx.Horizon.Common;
using Trijinx.Horizon.Sdk.Sf;
using System;

namespace Trijinx.Horizon.Sdk.Audio.Detail
{
    interface IAudioSnoopManager : IServiceObject
    {
        Result EnableDspUsageMeasurement();
        Result DisableDspUsageMeasurement();
        Result GetDspUsage(out uint usage);

        Result GetDspStatistics(out uint statistics);
        Result GetAppletStateSummaries(Span<byte> summaries);
        Result SetDspStatisticsParameter(ReadOnlySpan<byte> parameter);
        Result GetDspStatisticsParameter(Span<byte> parameter);
    }
}
