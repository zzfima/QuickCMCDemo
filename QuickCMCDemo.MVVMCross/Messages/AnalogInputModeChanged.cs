﻿using QuickCMCDemo.MVVMCross.Entities;

namespace QuickCMCDemo.MVVMCross.Messages
{
    public class AnalogInputModeChanged : MvvmCross.Plugin.Messenger.MvxMessage
    {
        public AnalogInputMode? NewAnalogInputModeStatus { get; }
        public AnalogInputModeChanged(object sender, AnalogInputMode? newAnalogInputModeStatus) : base(sender)
        {
            NewAnalogInputModeStatus = newAnalogInputModeStatus;
        }
    }
}