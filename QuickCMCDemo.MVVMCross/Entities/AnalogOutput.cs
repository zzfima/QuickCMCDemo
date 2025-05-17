using MvvmCross.ViewModels;

namespace QuickCMCDemo.MVVMCross.Entities
{
    public class AnalogOutput : MvxNotifyPropertyChanged
    {
        public double Magnitud { get; set; }
        public double Phase { get; set; }
        public double Frequency { get; set; }
    }
}