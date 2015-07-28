namespace SOLIDLogger
{
    using System;
    using System.Collections.Generic;

    using SOLIDLogger.Contracts;

    public class Logger : ILogger
    {
        public Logger(params IAppender[] appenders)
        {
            this.Appenders = appenders;
        }

        public ICollection<IAppender> Appenders { get; private set; }

        public void Info(string msg)
        {
            this.LogHandler(msg, ReportLevel.Info);
        }

        public void Warning(string msg)
        {
            this.LogHandler(msg, ReportLevel.Warning);
        }

        public void Critical(string msg)
        {
            this.LogHandler(msg, ReportLevel.Critical);
        }

        public void Error(string msg)
        {
            this.LogHandler(msg, ReportLevel.Error);
        }

        public void Fatal(string msg)
        {
            this.LogHandler(msg, ReportLevel.Fatal);
        }

        private void LogHandler(string msg, ReportLevel reportLevel)
        {
            foreach (var appender in this.Appenders)
            {
                appender.Append(DateTime.Now, reportLevel, msg);
            }
        }
    }
}
