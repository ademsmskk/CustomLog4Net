using log4net;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public partial class Loggers
    {
        private readonly ILog Log;

        public Loggers()
        {
            log4net.Config.XmlConfigurator.Configure();
            this.Log = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        }

        public Loggers(string name)
        {
            log4net.Config.XmlConfigurator.Configure();
            this.Log = log4net.LogManager.GetLogger(name);

        }

        public Loggers(string name, FileInfo configFile)
        {
            log4net.Config.XmlConfigurator.Configure(configFile);
            this.Log = log4net.LogManager.GetLogger(name);
        }



        [DebuggerStepThrough()]
        public void LogDebug(string message)
        {
            this.Log.Debug(message);
        }
        [DebuggerStepThrough()]
        public void LogDebug(string message, FileLogTitles fileLogTitle)
        {

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append(message);
            strBuilder.Append("--");
            strBuilder.Append(fileLogTitle.ToDesctiption());


            this.Log.Error(strBuilder);

        }

        public void LogDebug(string message, Exception ex)
        {
            this.Log.Debug(message, ex);
        }

        void LogDebug(string message, FileLogTitles fileLogTitle, Exception ex)
        {

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append(fileLogTitle.ToString());
            strBuilder.Append(message);

            this.Log.Debug(strBuilder, ex);
        }

    }
}
