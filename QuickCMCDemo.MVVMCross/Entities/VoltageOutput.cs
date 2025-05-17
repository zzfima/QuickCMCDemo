using MvvmCross.ViewModels;

namespace QuickCMCDemo.MVVMCross.Entities
{
    public class VoltageOutput : MvxViewModel
    {
        public float? _magnitud;
        public float? _phase;
        public float? _frequency;

        public float? Magnitud
        {
            get => _magnitud;
            set => SetProperty(ref _magnitud, value);
        }

        public float? Phase
        {
            get => _phase;
            set => SetProperty(ref _phase, value);
        }

        public float? Frequency
        {
            get => _frequency;
            set => SetProperty(ref _frequency, value);
        }
    }
}