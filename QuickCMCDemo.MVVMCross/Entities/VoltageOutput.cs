using MvvmCross.ViewModels;

namespace QuickCMCDemo.MVVMCross.Entities
{
    public class VoltageOutput : MvxNotifyPropertyChanged
    {
        private double _magnitud;
        private double _phase;
        private double _frequency;

        public double Magnitud
        {
            get => _magnitud;
            set => SetProperty(ref _magnitud, value);
        }

        public double Phase
        {
            get => _phase;
            set => SetProperty(ref _phase, value);
        }

        public double Frequency
        {
            get => _frequency;
            set => SetProperty(ref _frequency, value);
        }
    }
}