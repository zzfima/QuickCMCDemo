using MvvmCross;
using MvvmCross.Commands;
using MvvmCross.ViewModels;
using QuickCMCDemo.MVVMCross.Randomizer;
using System.Threading.Tasks;
using System.Windows;

namespace QuickCMCDemo.MVVMCross.ViewModel
{
	public sealed class CompositeViewModel : MvxViewModel
	{
		#region Fields
		private AnalogOutputsViewModel? _analogOutputsVM;
		#endregion

		#region Ctor
		public CompositeViewModel(AnalogOutputsViewModel analogOutputsVM)
		{
			AnalogOutputsVM = analogOutputsVM;

			ExitCommand = new MvxCommand(Exit);
			StartSimulationCommand = new MvxCommand(async () => await StartSimulation());
			StopSimulationCommand = new MvxCommand(async () => await StopSimulation());
		}
		#endregion

		#region Dependency Properties
		public AnalogOutputsViewModel? AnalogOutputsVM
		{
			get => _analogOutputsVM;
			set => SetProperty(ref _analogOutputsVM, value);
		}
		public IMvxCommand ExitCommand { get; }
		public IMvxCommand StartSimulationCommand { get; }
		public IMvxCommand StopSimulationCommand { get; }
		#endregion

		#region Methods
		private void Exit()
		{
			Application.Current.Shutdown();
		}

		private async Task StartSimulation()
		{
			await Mvx.IoCProvider?.Resolve<IAnalogOutputsSimulator>()?.StartSimulation();
		}

		private async Task StopSimulation()
		{
			await Mvx.IoCProvider?.Resolve<IAnalogOutputsSimulator>()?.StopSimulation();
		}
		#endregion
	}
}