using QuickCMCDemo.MVVMCross.Entities;

namespace QuickCMCDemo.MVVMCross.Messages
{
    public class I_C_Changed : MvvmCross.Plugin.Messenger.MvxMessage
    {
        public AnalogOutput? NewI_C_Status { get; }
        public I_C_Changed(object sender, AnalogOutput? newI_C_Status) : base(sender)
        {
            NewI_C_Status = newI_C_Status;
        }
    }
}