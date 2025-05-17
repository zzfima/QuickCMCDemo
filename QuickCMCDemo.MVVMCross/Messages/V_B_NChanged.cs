using QuickCMCDemo.MVVMCross.Entities;

namespace QuickCMCDemo.MVVMCross.Messages
{
    public class V_B_NChanged : MvvmCross.Plugin.Messenger.MvxMessage
    {
        public VoltageOutput? NewV_B_NStatus { get; }
        public V_B_NChanged(object sender, VoltageOutput? newV_B_NStatus) : base(sender)
        {
            NewV_B_NStatus = newV_B_NStatus;
        }
    }
}