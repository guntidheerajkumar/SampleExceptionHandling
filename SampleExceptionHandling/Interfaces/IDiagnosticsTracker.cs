using System;
using System.Collections.Generic;
using System.Net.Http;

namespace SampleExceptionHandling
{
    public interface IDiagnosticsTracker
    {
        void Initialize(DiagnosticsConfiguration config);

        ICodeBlockPerformanceTracker GetCodeBlockPerformanceTracker(string callerName, string operationName,
            IDictionary<string, string> metadata = null);

        IOperationPerformanceTracker GetOperationPerformanceTracker();

        INetworkTracker GetNetworkTracker(HttpRequestMessage message);

        IErrorTracker GetErrorTracker();

        //ICrashTracker GetCrashTracker();
    }
}
