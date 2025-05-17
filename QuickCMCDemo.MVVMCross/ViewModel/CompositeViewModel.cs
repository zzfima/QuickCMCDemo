using MvvmCross.ViewModels;

namespace RedisClient.MVVMCross.ViewModel
{
    public sealed class CompositeViewModel : MvxViewModel
    {
        #region Fields
        private AnalogOutputsViewModel? _analogOutputsVM;
        #endregion

        #region Ctor
        public CompositeViewModel(AnalogOutputsViewModel analogOutputsVM)
        {
            AnalogOutputsVM = analogOutputsVM;
        }
        #endregion

        public void StartSimulation()
        {

        }

        #region Dependency Properties
        public AnalogOutputsViewModel? AnalogOutputsVM
        {
            get => _analogOutputsVM;
            set => SetProperty(ref _analogOutputsVM, value);
        }
        #endregion
    }
}
