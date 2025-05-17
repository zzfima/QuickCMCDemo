using System;
using MvvmCross.Plugin.Messenger;
using MvvmCross.ViewModels;
using QuickCMCDemo.MVVMCross.Entities;
using QuickCMCDemo.MVVMCross.Messages;

namespace QuickCMCDemo.MVVMCross.ViewModel
{
    public sealed class CompositeViewModel : MvxViewModel
    {
        #region Fields
        private AnalogOutputsViewModel? _analogOutputsVM;
        private readonly IMvxMessenger _messenger;
        #endregion

        #region Ctor
        public CompositeViewModel(IMvxMessenger messenger, AnalogOutputsViewModel analogOutputsVM)
        {
            _messenger = messenger;
            AnalogOutputsVM = analogOutputsVM;
        }
        #endregion

        public void Simulate()
        {
            Random random = new();
            _messenger?.Publish(new V_A_NChanged(this, new VoltageOutput()
            {
                Frequency = random.NextDouble() * 10 + 40,
                Phase = random.NextDouble() * 120,
                Magnitud = random.NextDouble()
            }));

            _messenger?.Publish(new V_B_NChanged(this, new VoltageOutput()
            {
                Frequency = random.NextDouble() * 10 + 40,
                Phase = random.NextDouble() * 120,
                Magnitud = random.NextDouble()
            }));

            _messenger?.Publish(new V_C_NChanged(this, new VoltageOutput()
            {
                Frequency = random.NextDouble() * 10 + 40,
                Phase = random.NextDouble() * 120,
                Magnitud = random.NextDouble()
            }));
        }

        #region Dependency Properties
        public AnalogOutputsViewModel? AnalogOutputsVM
        {
            get => _analogOutputsVM;
            set => SetProperty(ref _analogOutputsVM, value);
        }
        #endregion
    }
}