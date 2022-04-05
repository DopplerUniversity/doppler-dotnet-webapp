using Microsoft.Extensions.Options;
using System.Collections.Generic;

namespace DopplerWebApp.Models
{
    public enum Logging
    {
        Trace = 0,
        Debug = 1,
        Info = 2,
        Warning = 3,
        Error = 4
    }

    public class Server
    {
        public string HostName { get; set; }
        public string Port { get; set; }
    }

    public class Doppler
    {
        public string DopplerProject { get; set; }
        public string DopplerConfig { get; set; }
        public string DopplerEnvironment { get; set; }
        public bool Debug { get; set; }
        public Logging Logging { get; set; }
        public Server Server { get; set; }
    }
}
