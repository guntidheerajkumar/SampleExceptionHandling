using System;
using System.Collections.Generic;

namespace SampleExceptionHandling
{
    public class ConsoleErrorTracker : IErrorTracker
    {
        public void TrackError(Exception exception, IDictionary<string, string> metadata = null) =>
            Console.WriteLine("Error reported to Error Tracker", exception);
    }
}