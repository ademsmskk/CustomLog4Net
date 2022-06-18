using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace ConsoleUI
{
    class Program
    {

        static void Main(string[] args)
        {
            log4net.GlobalContext.Properties["GetProperty"] = FileLogTitles.WebApiLoggingMiddleware;
            Loggers loggers = new Loggers();
            loggers.LogDebug("custom", FileLogTitles.HealthCheckController);
            loggers.LogDebug("message", FileLogTitles.BsnApiProvider);
            loggers.LogDebug("Just message");
            loggers.LogDebug("Message", FileLogTitles.HealthCheckController);
            Console.ReadLine();

        }
    }
}
