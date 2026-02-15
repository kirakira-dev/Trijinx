using Trijinx.HLE.HOS.Ipc;
using Trijinx.HLE.HOS.Kernel.Process;
using Trijinx.HLE.HOS.Kernel.Threading;
using Trijinx.Memory;
using System.IO;

namespace Trijinx.HLE.HOS
{
    class ServiceCtx
    {
        public Switch Device { get; }
        public KProcess Process { get; }
        public IVirtualMemoryManager Memory { get; }
        public KThread Thread { get; }
        public KThread CallerThread { get; }
        public IpcMessage Request { get; }
        public IpcMessage Response { get; }
        public BinaryReader RequestData { get; }
        public BinaryWriter ResponseData { get; }

        public ServiceCtx(
            Switch device,
            KProcess process,
            IVirtualMemoryManager memory,
            KThread thread,
            KThread callerThread,
            IpcMessage request,
            IpcMessage response,
            BinaryReader requestData,
            BinaryWriter responseData)
        {
            Device = device;
            Process = process;
            Memory = memory;
            Thread = thread;
            CallerThread = callerThread;
            Request = request;
            Response = response;
            RequestData = requestData;
            ResponseData = responseData;
        }
    }
}
