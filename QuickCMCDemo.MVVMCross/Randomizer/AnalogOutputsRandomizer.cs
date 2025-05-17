using System;
using MvvmCross.Plugin.Messenger;
using QuickCMCDemo.MVVMCross.Entities;
using QuickCMCDemo.MVVMCross.Messages;
using QuickCMCDemo.MVVMCross.ViewModel;

namespace QuickCMCDemo.MVVMCross.Randomizer
{
    public class AnalogOutputsRandomizer : IAnalogOutputsRandomizer
    {
        private readonly IMvxMessenger _messenger;

        public AnalogOutputsRandomizer(IMvxMessenger messenger)
        {
            _messenger = messenger;
        }

        public void Randomize()
        {
            Random random = new();

            //VOLTAGE
            _messenger?.Publish(new V_A_NChanged(this, new AnalogOutput()
            {
                Frequency = random.NextDouble() * 10 + 40,
                Phase = random.NextDouble() * 120,
                Magnitud = random.NextDouble()
            }));

            _messenger?.Publish(new V_B_NChanged(this, new AnalogOutput()
            {
                Frequency = random.NextDouble() * 10 + 40,
                Phase = random.NextDouble() * 120,
                Magnitud = random.NextDouble()
            }));

            _messenger?.Publish(new V_C_NChanged(this, new AnalogOutput()
            {
                Frequency = random.NextDouble() * 10 + 40,
                Phase = random.NextDouble() * 120,
                Magnitud = random.NextDouble()
            }));

            //AMPERAGE
            _messenger?.Publish(new I_A_Changed(this, new AnalogOutput()
            {
                Frequency = random.NextDouble() * 10 + 40,
                Phase = random.NextDouble() * 120,
                Magnitud = random.NextDouble()
            }));

            _messenger?.Publish(new I_B_Changed(this, new AnalogOutput()
            {
                Frequency = random.NextDouble() * 10 + 40,
                Phase = random.NextDouble() * 120,
                Magnitud = random.NextDouble()
            }));

            _messenger?.Publish(new I_C_Changed(this, new AnalogOutput()
            {
                Frequency = random.NextDouble() * 10 + 40,
                Phase = random.NextDouble() * 120,
                Magnitud = random.NextDouble()
            }));

            //Analog Input Mode
            Array analogInputModeValues = Enum.GetValues(typeof(AnalogInputMode));
            AnalogInputMode randomAnalogInputMode = (AnalogInputMode)analogInputModeValues.GetValue(random.Next(analogInputModeValues.Length));
            _messenger?.Publish(new AnalogInputModeChanged(this, randomAnalogInputMode));
        }
    }
}
