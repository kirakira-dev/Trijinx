using System.Collections.Generic;

namespace Trijinx.Horizon.Sdk.Sf
{
    interface IServiceObject
    {
        IReadOnlyDictionary<int, CommandHandler> GetCommandHandlers();
    }
}
