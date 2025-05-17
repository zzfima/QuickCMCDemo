using QuickCMCDemo.MVVMCross.Entities;

namespace QuickCMCDemo.MVVMCross.Messages
{
    public class V_C_NChanged : MvvmCross.Plugin.Messenger.MvxMessage
    {
        public VoltageOutput? NewV_C_NStatus { get; }
        public V_C_NChanged(object sender, VoltageOutput? newV_C_NStatus) : base(sender)
        {
            NewV_C_NStatus = newV_C_NStatus;
        }
    }
}