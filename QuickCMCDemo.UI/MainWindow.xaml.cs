using MvvmCross;
using QuickCMCDemo.MVVMCross.ViewModel;
using System.Windows;

namespace QuickCMCDemo.UI
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			DataContext = Mvx.IoCProvider?.Resolve<CompositeViewModel>();
		}
	}
}