using Trijinx.Graphics.GAL.Multithreading.Commands.Sampler;
using Trijinx.Graphics.GAL.Multithreading.Model;

namespace Trijinx.Graphics.GAL.Multithreading.Resources
{
    class ThreadedSampler : ISampler
    {
        private readonly ThreadedRenderer _renderer;
        public ISampler Base;

        public ThreadedSampler(ThreadedRenderer renderer)
        {
            _renderer = renderer;
        }

        public unsafe void Dispose()
        {
            _renderer.New<SamplerDisposeCommand>()->Set(new TableRef<ThreadedSampler>(_renderer, this));
            _renderer.QueueCommand();
        }
    }
}
