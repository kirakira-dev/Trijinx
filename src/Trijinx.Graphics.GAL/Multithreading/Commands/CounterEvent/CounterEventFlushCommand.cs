using Trijinx.Graphics.GAL.Multithreading.Model;
using Trijinx.Graphics.GAL.Multithreading.Resources;

namespace Trijinx.Graphics.GAL.Multithreading.Commands.CounterEvent
{
    struct CounterEventFlushCommand : IGALCommand, IGALCommand<CounterEventFlushCommand>
    {
        public readonly CommandType CommandType => CommandType.CounterEventFlush;
        private TableRef<ThreadedCounterEvent> _event;

        public void Set(TableRef<ThreadedCounterEvent> evt)
        {
            _event = evt;
        }

        public static void Run(ref CounterEventFlushCommand command, ThreadedRenderer threaded, IRenderer renderer)
        {
            command._event.Get(threaded).Base.Flush();
        }
    }
}
