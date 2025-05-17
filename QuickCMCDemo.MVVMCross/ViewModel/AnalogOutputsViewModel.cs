using MvvmCross.Plugin.Messenger;
using MvvmCross.ViewModels;
using QuickCMCDemo.MVVMCross.Entities;
using QuickCMCDemo.MVVMCross.Messages;

namespace QuickCMCDemo.MVVMCross.ViewModel
{
    public sealed class AnalogOutputsViewModel : MvxViewModel
    {
        #region Fields
        private MvxSubscriptionToken? _token_V_A_NChanged;
        private MvxSubscriptionToken? _token_V_B_NChanged;
        private MvxSubscriptionToken? _token_V_C_NChanged;
        private VoltageOutput? _v_a_n;
        private VoltageOutput? _v_b_n;
        private VoltageOutput? _v_c_n;
        #endregion

        #region Ctor
        public AnalogOutputsViewModel(IMvxMessenger messenger)
        {
            _token_V_A_NChanged = messenger?.Subscribe<V_A_NChanged>((res) =>
            {
                V_A_N = res.NewV_A_NStatus;
            });

            _token_V_B_NChanged = messenger?.Subscribe<V_B_NChanged>((res) =>
            {
                V_B_N = res.NewV_B_NStatus;
            });

            _token_V_C_NChanged = messenger?.Subscribe<V_C_NChanged>((res) =>
            {
                V_C_N = res.NewV_C_NStatus;
            });
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