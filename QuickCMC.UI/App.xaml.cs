using System.Windows;
using MvvmCross.Base;
using MvvmCross.IoC;
using MvvmCross.Plugin.Messenger;
using RedisClient.MVVMCross.ViewModel;

namespace QuickCMC.UI
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
        }

        private void ConfigureServices()
        {
            var instance = MvxIoCProvider.Initialize();

            //Core
            instance.ConstructAndRegisterSingleton<IMvxMessenger, MvxMessengerHub>();

            //ViewModels
            instance.ConstructAndRegisterSingleton(typeof(AnalogOutputsViewModel));
            instance.ConstructAndRegisterSingleton(typeof(CompositeViewModel));
        }
    }
}
