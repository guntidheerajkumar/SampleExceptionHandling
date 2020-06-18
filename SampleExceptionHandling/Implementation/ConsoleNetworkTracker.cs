using System;
using System.Net.Http;

namespace SampleExceptionHandling
{
    public class ConsoleNetworkTracker : INetworkTracker
    {
        private readonly HttpRequestMessage _message;

        public ConsoleNetworkTracker(HttpRequestMessage message)
        {
            _message = message;

            var logOutput = new string[]
            {
                $"Tracking HTTP request: {_message.RequestUri}",
                $"Method: {_message.Method}"
            };

            Console.WriteLine(logOutput);
        }

        public void TrackResponse(Exception exception) =>
            Console.WriteLine($"Finished tracking HTTP request: {_message.RequestUri}", exception);

        public void TrackResponse(HttpResponseMessage response)
        {
            var logOutput = new string[]
            {
                $"Finished tracking HTTP request: {response.RequestMessage.RequestUri}",
                $"Method: {response.RequestMessage.Method}",
                $"Response code: {response.StatusCode}"
            };

            Console.WriteLine(logOutput);
        }
    }
}
