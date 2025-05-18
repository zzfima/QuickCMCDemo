using System.Threading.Tasks;

namespace QuickCMCDemo.MVVMCross.Randomizer
{
	public interface IAnalogOutputsSimulator
	{
		Task StartSimulation();
		Task StopSimulation();
	}
}