using LibHac.Bcat;
using Trijinx.Horizon.Common;
using Trijinx.Horizon.Sdk.Sf;
using System;

namespace Trijinx.Horizon.Sdk.Bcat
{
    internal interface IDeliveryCacheStorageService : IServiceObject
    {
        Result CreateDirectoryService(out IDeliveryCacheDirectoryService service);
        Result CreateFileService(out IDeliveryCacheFileService service);
        Result EnumerateDeliveryCacheDirectory(out int count, Span<DirectoryName> directoryNames);
    }
}
