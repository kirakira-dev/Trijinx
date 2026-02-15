using Trijinx.Common.Logging;
using Trijinx.HLE.HOS.Applets.Browser;
using Trijinx.HLE.HOS.Applets.Cabinet;
using Trijinx.HLE.HOS.Applets.Dummy;
using Trijinx.HLE.HOS.Applets.Error;
using Trijinx.HLE.HOS.Services.Am.AppletAE;

namespace Trijinx.HLE.HOS.Applets
{
    static class AppletManager
    {
        public static IApplet Create(AppletId applet, Horizon system)
        {
            switch (applet)
            {
                case AppletId.Controller:
                    return new ControllerApplet(system);
                case AppletId.Error:
                    return new ErrorApplet(system);
                case AppletId.PlayerSelect:
                    return new PlayerSelectApplet(system);
                case AppletId.SoftwareKeyboard:
                    return new SoftwareKeyboardApplet(system);
                case AppletId.LibAppletWeb:
                case AppletId.LibAppletShop:
                case AppletId.LibAppletOff:
                    return new BrowserApplet();
                case AppletId.MiiEdit:
                    Logger.Warning?.Print(LogClass.Application, $"Please use the MiiEdit inside File/Open Applet");
                    return new DummyApplet(system);
                case AppletId.Cabinet:
                    return new CabinetApplet(system);
            }

            Logger.Warning?.Print(LogClass.Application, $"Applet {applet} not implemented!");
            return new DummyApplet(system);
        }
    }
}
