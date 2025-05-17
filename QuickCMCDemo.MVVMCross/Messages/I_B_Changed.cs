using QuickCMCDemo.MVVMCross.Entities;

namespace QuickCMCDemo.MVVMCross.Messages
{
    public class I_B_Changed : MvvmCross.Plugin.Messenger.MvxMessage
    {
        public AnalogOutput? NewI_B_Status { get; }
        public I_B_Changed(object sender, AnalogOutput? newI_B_Status) : base(sender)
        {
            NewI_B_Status = newI_B_Status;
        }
    }
}