using System;
using System.Collections.Generic;
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
        private MvxSubscriptionToken? _token_I_A_Changed;
        private MvxSubscriptionToken? _token_I_B_Changed;
        private MvxSubscriptionToken? _token_I_C_Changed;
        private MvxSubscriptionToken? _token_AnalogInputModeChanged;

        private AnalogOutput? _v_a_n;
        private AnalogOutput? _v_b_n;
        private AnalogOutput? _v_c_n;

        private AnalogOutput? _i_a;
        private AnalogOutput? _i_b;
        private AnalogOutput? _i_c;

        private List<AnalogInputMode>? _allAnalogInputModes = new();
        private AnalogInputMode? _seletcedAnalogInputMode;
        #endregion

        #region Ctor
        public AnalogOutputsViewModel(IMvxMessenger messenger)
        {
            Array analogInputModeValues = Enum.GetValues(typeof(AnalogInputMode));
            foreach (var value in analogInputModeValues)
            {
                AllAnalogInputModes.Add((AnalogInputMode)value);
            }

            //VOLTAGE
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

            //AMPERAGE
            _token_I_A_Changed = messenger?.Subscribe<I_A_Changed>((res) =>
            {
                I_A = res.NewI_A_Status;
            });

            _token_I_B_Changed = messenger?.Subscribe<I_B_Changed>((res) =>
            {
                I_B = res.NewI_B_Status;
            });

            _token_I_C_Changed = messenger?.Subscribe<I_C_Changed>((res) =>
            {
                I_C = res.NewI_C_Status;
            });

            //ANALOG INPUT MODE
            _token_AnalogInputModeChanged = messenger?.Subscribe<AnalogInputModeChanged>((res) =>
            {
                SeletcedAnalogInputMode = res.NewAnalogInputModeStatus;
            });
        }
        #endregion

        #region Properties

        //VOLTAGE
        public AnalogOutput? V_A_N
        {
            get => _v_a_n;
            set => SetProperty(ref _v_a_n, value);
        }

        public AnalogOutput? V_B_N
        {
            get => _v_b_n;
            set => SetProperty(ref _v_b_n, value);
        }

        public AnalogOutput? V_C_N
        {
            get => _v_c_n;
            set => SetProperty(ref _v_c_n, value);
        }

        //AMPERAGE
        public AnalogOutput? I_A
        {
            get => _i_a;
            set => SetProperty(ref _i_a, value);
        }
        public AnalogOutput? I_B
        {
            get => _i_b;
            set => SetProperty(ref _i_b, value);
        }
        public AnalogOutput? I_C
        {
            get => _i_c;
            set => SetProperty(ref _i_c, value);
        }

        //ANALOG INPUT MODE
        public List<AnalogInputMode>? AllAnalogInputModes
        {
            get => _allAnalogInputModes;
            set => SetProperty(ref _allAnalogInputModes, value);
        }

        public AnalogInputMode? SeletcedAnalogInputMode
        {
            get => _seletcedAnalogInputMode;
            set => SetProperty(ref _seletcedAnalogInputMode, value);
        }
        #endregion
    }
}