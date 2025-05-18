using System;
using System.Threading.Tasks;
using MvvmCross.Plugin.Messenger;
using QuickCMCDemo.MVVMCross.Entities;
using QuickCMCDemo.MVVMCross.Messages;

namespace QuickCMCDemo.MVVMCross.Randomizer
{
	public class AnalogOutputsRandomizer : IAnalogOutputsRandomizer
	{
		private readonly IMvxMessenger _messenger;
		private bool _isSimulationRun = false;

		public AnalogOutputsRandomizer(IMvxMessenger messenger)
		{
			_messenger = messenger;
		}

		public async Task StartSimulation()
		{
			Random random = new();
			_isSimulationRun = true;

			while (_isSimulationRun)
			{
				await Task.Factory.StartNew(() =>
				{
					//VOLTAGE
					_messenger?.Publish(new V_A_NChanged(this, new(random.NextDouble() * 10 + 40, random.NextDouble() * 120, random.NextDouble())));
					_messenger?.Publish(new V_B_NChanged(this, new(random.NextDouble() * 10 + 40, random.NextDouble() * 120, random.NextDouble())));
					_messenger?.Publish(new V_C_NChanged(this, new(random.NextDouble() * 10 + 40, random.NextDouble() * 120, random.NextDouble())));

					//AMPERAGE
					_messenger?.Publish(new I_A_Changed(this, new(random.NextDouble() * 10 + 40, random.NextDouble() * 120, random.NextDouble())));
					_messenger?.Publish(new I_B_Changed(this, new(random.NextDouble() * 10 + 40, random.NextDouble() * 120, random.NextDouble())));
					_messenger?.Publish(new I_C_Changed(this, new(random.NextDouble() * 10 + 40, random.NextDouble() * 120, random.NextDouble())));

					//Analog Input Mode
					Array analogInputModeValues = Enum.GetValues(typeof(AnalogInputMode));
					AnalogInputMode randomAnalogInputMode = (AnalogInputMode)analogInputModeValues?.GetValue(random.Next(analogInputModeValues.Length));
					_messenger?.Publish(new AnalogInputModeChanged(this, randomAnalogInputMode));
				});

				await Task.Delay(2000);
			}
		}

		public async Task StopSimulation()
		{
			await Task.Factory.StartNew(() =>
			{
				_isSimulationRun = false;
			});
		}
	}
}
