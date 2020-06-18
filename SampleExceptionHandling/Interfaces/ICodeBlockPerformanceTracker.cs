using System;
namespace SampleExceptionHandling
{
    public interface ICodeBlockPerformanceTracker : IDisposable
    {
        void AddMetadata(string key, string value);
    }
}