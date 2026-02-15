using Trijinx.Horizon.Common;
using Trijinx.Horizon.Sdk.Account;
using Trijinx.Horizon.Sdk.Sf;
using System;
using ApplicationId = Trijinx.Horizon.Sdk.Ncm.ApplicationId;

namespace Trijinx.Horizon.Sdk.Prepo
{
    interface IPrepoService : IServiceObject
    {
        Result SaveReport(ReadOnlySpan<byte> gameRoomBuffer, ReadOnlySpan<byte> reportBuffer, ulong pid);
        Result SaveReportWithUser(Uid userId, ReadOnlySpan<byte> gameRoomBuffer, ReadOnlySpan<byte> reportBuffer, ulong pid);
        Result RequestImmediateTransmission();
        Result GetTransmissionStatus(out int status);
        Result GetSystemSessionId(out ulong systemSessionId);
        Result SaveSystemReport(ReadOnlySpan<byte> gameRoomBuffer, ApplicationId applicationId, ReadOnlySpan<byte> reportBuffer);
        Result SaveSystemReportWithUser(Uid userId, ReadOnlySpan<byte> gameRoomBuffer, ApplicationId applicationId, ReadOnlySpan<byte> reportBuffer);
        Result IsUserAgreementCheckEnabled(out bool enabled);
        Result SetUserAgreementCheckEnabled(bool enabled);
    }
}
