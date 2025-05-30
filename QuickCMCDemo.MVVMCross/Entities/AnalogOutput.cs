namespace QuickCMCDemo.MVVMCross.Entities
{
    public class AnalogOutput
    {
        public AnalogOutput(double magnitude, double phase, double frequency)
        {
            Magnitude = magnitude;
            Phase = phase;
            Frequency = frequency;
        }

        public double Magnitude { get; set; }
        public double Phase { get; set; }
        public double Frequency { get; set; }
    }
}