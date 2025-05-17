using System.Windows;
using MvvmCross;
using RedisClient.MVVMCross.ViewModel;

namespace QuickCMC.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = Mvx.IoCProvider?.Resolve<CompositeViewModel>();
        }

        private void StartSimulation_Click(object sender, RoutedEventArgs e)
        {
            Mvx.IoCProvider?.Resolve<CompositeViewModel>()?.Simulate();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}