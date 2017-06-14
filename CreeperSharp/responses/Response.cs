using System;
using System.Net;

namespace CreeperSharp.responses
{
    public class Response
    {
        public string Status { get; set; }
        public string EndPoint { get; set; }
        public Exception Exception { get; set; } = null;
        public HttpStatusCode StatusCode { get; set; }
    }
}
