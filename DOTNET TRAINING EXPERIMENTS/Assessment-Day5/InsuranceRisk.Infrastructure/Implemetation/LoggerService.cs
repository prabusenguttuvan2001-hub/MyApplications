using InsuranceRisk.Infrastructure.Logging;
using System;

namespace InsuranceRisk.Infrastructure.Implemetation
{
    public class LoggerService : ILoggerService
    {
        public void LogInfo(string message)
        {
            Console.WriteLine("INFO: " + message);
        }

        public void LogError(string message)
        {
            Console.WriteLine("ERROR: " + message);
        }
    }
}
