using LibHac.Bcat;
using Trijinx.Horizon.Common;
using Trijinx.Horizon.Sdk.Sf;
using System;

namespace Trijinx.Horizon.Sdk.Bcat
{
    internal interface IDeliveryCacheDirectoryService : IServiceObject
    {
        Result GetCount(out int count);
        Result Open(DirectoryName directoryName);
        Result Read(out int entriesRead, Span<DeliveryCacheDirectoryEntry> entriesBuffer);
    }
}
