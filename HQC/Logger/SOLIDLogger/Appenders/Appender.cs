namespace SOLIDLogger.Appenders
{
    using System;
    using SOLIDLogger.Contracts;

    public abstract class Appender : IAppender
    {
        protected Appender(ILayout layout)
        {
            this.Layout = layout;
            this.ReportLevel = ReportLevel.Info;
        }

        public ReportLevel ReportLevel { get; set; }

        public ILayout Layout { get; private set; }

        public bool ValidReporLevel(ReportLevel userReportLevel)
        {
            bool isValidReportLevel = userReportLevel >= this.ReportLevel;
            return isValidReportLevel;
        }

        public abstract void Append(DateTime date, ReportLevel reportLevel, string msg);
    }
}
