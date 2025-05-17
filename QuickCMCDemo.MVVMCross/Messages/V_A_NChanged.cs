using QuickCMCDemo.MVVMCross.Entities;

namespace QuickCMCDemo.MVVMCross.Messages
{
    public class V_A_NChanged : MvvmCross.Plugin.Messenger.MvxMessage
    {
        public AnalogOutput? NewV_A_NStatus { get; }
        public V_A_NChanged(object sender, AnalogOutput? newV_A_NStatus) : base(sender)
        {
            NewV_A_NStatus = newV_A_NStatus;
        }
    }
}