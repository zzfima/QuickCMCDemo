using MvvmCross.Plugin.Messenger;
using MvvmCross.ViewModels;
using QuickCMCDemo.MVVMCross.Entities;

namespace RedisClient.MVVMCross.ViewModel
{
    public sealed class AnalogOutputsViewModel : MvxViewModel
    {
        #region Fields
        private IMvxMessenger? _messenger;
        private VoltageOutput? _v_a_n;
        private VoltageOutput? _v_b_n;
        private VoltageOutput? _v_c_n;
        #endregion

        #region Ctor
        public AnalogOutputsViewModel(IMvxMessenger messenger)
        {
            _messenger = messenger;
        }
        #endregion

        #region Properties
        public VoltageOutput? V_A_N
        {
            get => _v_a_n;
            set => SetProperty(ref _v_a_n, value);
        }

        public VoltageOutput? V_B_N
        {
            get => _v_b_n;
            set => SetProperty(ref _v_b_n, value);
        }

        public VoltageOutput? V_C_N
        {
            get => _v_c_n;
            set => SetProperty(ref _v_c_n, value);
        }
        #endregion
    }
}
