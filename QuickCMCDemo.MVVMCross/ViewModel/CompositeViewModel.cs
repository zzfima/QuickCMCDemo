using System;
using System.Threading.Tasks;
using MvvmCross.Plugin.Messenger;
using MvvmCross.ViewModels;
using RedisClient.MVVMCross.Messages;

namespace RedisClient.MVVMCross.ViewModel
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
            Random _random = new();
            _messenger?.Publish(new V_A_NChanged(this, new QuickCMCDemo.MVVMCross.Entities.VoltageOutput()
            {
                Frequency = _random.Next(1, 1000),
                Phase = _random.Next(1, 1000),
                Magnitud = _random.Next(1, 1000),
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
