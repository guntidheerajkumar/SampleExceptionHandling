using System;
using System.Collections.Generic;

namespace SampleExceptionHandling
{
    public interface IErrorTracker
    {
        void TrackError(Exception exception, IDictionary<string, string> metadata = null);
    }
}