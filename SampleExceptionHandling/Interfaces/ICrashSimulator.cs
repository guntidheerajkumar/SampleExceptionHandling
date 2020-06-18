using System;
namespace SampleExceptionHandling
{
    public interface ICrashSimulator
    {
        void SimulateCrash(string crashIdentifier = null);

        void SimulateUnobservedTaskException(string exceptionIdentifier = null);
    }
}
