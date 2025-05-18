using System.Threading.Tasks;

namespace QuickCMCDemo.MVVMCross.Randomizer
{
	public interface IAnalogOutputsRandomizer
	{
		Task StartSimulation();
		Task StopSimulation();
	}
}