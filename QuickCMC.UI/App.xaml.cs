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
        }

        private void ConfigureServices()
        {
            var instance = MvxIoCProvider.Initialize();

            //Core
            instance.ConstructAndRegisterSingleton<IMvxMessenger, MvxMessengerHub>();
            instance.ConstructAndRegisterSingleton<IAnalogOutputsRandomizer, AnalogOutputsRandomizer>();

            //ViewModels
            instance.ConstructAndRegisterSingleton(typeof(AnalogOutputsViewModel));
            instance.ConstructAndRegisterSingleton(typeof(CompositeViewModel));
        }
    }
}
