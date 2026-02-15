using Trijinx.Horizon.Arp;
using Trijinx.Horizon.Audio;
using Trijinx.Horizon.Bcat;
using Trijinx.Horizon.Friends;
using Trijinx.Horizon.Hshl;
using Trijinx.Horizon.Ins;
using Trijinx.Horizon.Lbl;
using Trijinx.Horizon.LogManager;
using Trijinx.Horizon.MmNv;
using Trijinx.Horizon.Ngc;
using Trijinx.Horizon.Ovln;
using Trijinx.Horizon.Prepo;
using Trijinx.Horizon.Psc;
using Trijinx.Horizon.Ptm;
using Trijinx.Horizon.Sdk.Arp;
using Trijinx.Horizon.Srepo;
using Trijinx.Horizon.Usb;
using Trijinx.Horizon.Wlan;
using System.Collections.Generic;
using System.Threading;

namespace Trijinx.Horizon
{
    public class ServiceTable
    {
        private int _readyServices;
        private int _totalServices;

        private readonly ManualResetEvent _servicesReadyEvent = new(false);

        public IReader ArpReader { get; internal set; }
        public IWriter ArpWriter { get; internal set; }

        public IEnumerable<ServiceEntry> GetServices(HorizonOptions options)
        {
            List<ServiceEntry> entries = [];

            void RegisterService<T>(string name) where T : IService
            {
                entries.Add(new ServiceEntry(T.Main, this, options, name));
            }

            RegisterService<ArpMain>("arp");
            RegisterService<AudioMain>("audio");
            RegisterService<BcatMain>("bcat");
            RegisterService<FriendsMain>("friends");
            RegisterService<HshlMain>("hshl");
            RegisterService<HwopusMain>("hwopus"); // TODO: Merge with audio once we can start multiple threads.
            RegisterService<InsMain>("ins");
            RegisterService<LblMain>("lbl");
            RegisterService<LmMain>("lm");
            RegisterService<MmNvMain>("mmnv");
            RegisterService<NgcMain>("ngc");
            RegisterService<OvlnMain>("ovln");
            RegisterService<PrepoMain>("prepo");
            RegisterService<PscMain>("psc");
            RegisterService<SrepoMain>("srepo");
            RegisterService<TsMain>("ts");
            RegisterService<UsbMain>("usb");
            RegisterService<WlanMain>("wlan");

            _totalServices = entries.Count;

            return entries;
        }

        internal void SignalServiceReady()
        {
            if (Interlocked.Increment(ref _readyServices) == _totalServices)
            {
                _servicesReadyEvent.Set();
            }
        }

        public void WaitServicesReady()
        {
            _servicesReadyEvent.WaitOne();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _servicesReadyEvent.Dispose();
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }
    }
}
