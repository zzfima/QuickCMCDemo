using System.Windows;
using MvvmCross.Base;
using MvvmCross.IoC;
using MvvmCross.Plugin.Messenger;
using QuickCMCDemo.MVVMCross.Randomizer;
using QuickCMCDemo.MVVMCross.ViewModel;

namespace QuickCMCDemo.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static IMvxIoCProvider? IoCProvider => MvxSingleton<IMvxIoCProvider>.Instance;

        public App()
        {
            ConfigureServices();

            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
            //System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("de"); 
        }

        private void ConfigureServices()
        {
            var instance = MvxIoCProvider.Initialize();

            //Core
            instance.ConstructAndRegisterSingleton<IMvxMessenger, MvxMessengerHub>();
            instance.ConstructAndRegisterSingleton<IAnalogOutputsSimulator, AnalogOutputsSimulator>();

            //ViewModels
            instance.ConstructAndRegisterSingleton(typeof(AnalogOutputsViewModel));
            instance.ConstructAndRegisterSingleton(typeof(CompositeViewModel));
        }
    }
}
