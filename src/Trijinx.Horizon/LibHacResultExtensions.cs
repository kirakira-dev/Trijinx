using Trijinx.Horizon.Common;

namespace Trijinx.Horizon
{
    public static class LibHacResultExtensions
    {
        extension(LibHac.Result libHacResult)
        {
            public Result Horizon => new((int)libHacResult.Module, (int)libHacResult.Description);
        }
    }
}
