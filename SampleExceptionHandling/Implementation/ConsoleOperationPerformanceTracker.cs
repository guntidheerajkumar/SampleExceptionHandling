using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace SampleExceptionHandling
{
    public class ConsoleOperationPerformanceTracker : IOperationPerformanceTracker
    {
        private readonly IDictionary<string, Stopwatch> _stopwatches = new Dictionary<string, Stopwatch>();

        public void OperationStarted(string operationName)
        {
            Console.WriteLine($"Operation Started: {operationName}");

            //ONLY for debug   
            // There isn't really any point running the stopwatch if we aren't logging, this is also a way
            // to ensure this doesn't accidentally get left switched on if we use this tracker in a release build.
            _stopwatches[operationName] = new Stopwatch();
            _stopwatches[operationName].Start();
        }

        public void OperationEnded(string operationName)
        {
            var stopwatch = default(Stopwatch);

            _stopwatches.TryGetValue(operationName, out stopwatch);
            stopwatch?.Stop();

            var logOutput = new string[]
            {
                $"Operation Ended: {operationName}",
                $"Performance: {stopwatch?.ElapsedMilliseconds}ms"
            };

            Console.WriteLine(logOutput);
        }
    }
}
