using QuickCMCDemo.MVVMCross.Entities;

namespace QuickCMCDemo.MVVMCross.Messages
{
    public class I_A_Changed : MvvmCross.Plugin.Messenger.MvxMessage
    {
        public AnalogOutput? NewI_A_Status { get; }
        public I_A_Changed(object sender, AnalogOutput? newI_A_Status) : base(sender)
        {
            NewI_A_Status = newI_A_Status;
        }
    }
}