using System.Windows;
using MvvmCross;
using QuickCMCDemo.MVVMCross.Randomizer;
using QuickCMCDemo.MVVMCross.ViewModel;

namespace QuickCMCDemo.UI
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
            Mvx.IoCProvider?.Resolve<IAnalogOutputsRandomizer>()?.Randomize();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}