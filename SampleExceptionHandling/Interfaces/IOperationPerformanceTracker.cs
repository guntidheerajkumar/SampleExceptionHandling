using System;
namespace SampleExceptionHandling
{
    public interface IOperationPerformanceTracker
    {
        void OperationStarted(string operationName);

        void OperationEnded(string operationName);
    }
}