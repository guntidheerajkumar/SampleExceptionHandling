using System;
using System.Net.Http;

namespace SampleExceptionHandling
{
    public interface INetworkTracker
    {
        void TrackResponse(HttpResponseMessage response);

        void TrackResponse(Exception exception);
    }
}