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

			startSimulationMenu.IsEnabled = true;
			stopSimulationMenu.IsEnabled = false;

			DataContext = Mvx.IoCProvider?.Resolve<CompositeViewModel>();
		}

		private async void StartSimulation_Click(object sender, RoutedEventArgs e)
		{
			startSimulationMenu.IsEnabled = false;
			stopSimulationMenu.IsEnabled = true;

			await Mvx.IoCProvider?.Resolve<IAnalogOutputsRandomizer>()?.StartSimulation();
		}

		private async void StopSimulation_Click(object sender, RoutedEventArgs e)
		{
			startSimulationMenu.IsEnabled = true;
			stopSimulationMenu.IsEnabled = false;

			await Mvx.IoCProvider?.Resolve<IAnalogOutputsRandomizer>()?.StopSimulation();
		}

		private void Exit_Click(object sender, RoutedEventArgs e)
		{
			Application.Current.Shutdown();
		}
	}
}