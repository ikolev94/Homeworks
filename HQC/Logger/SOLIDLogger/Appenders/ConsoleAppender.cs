namespace SOLIDLogger.Appenders
{
    using System;

    using SOLIDLogger.Contracts;

    public class ConsoleAppender : Appender
    {
        public ConsoleAppender(ILayout layout)
            : base(layout)
        {
        }

        public override void Append(DateTime date, ReportLevel reportLevel, string msg)
        {
            if (this.ValidReporLevel(reportLevel))
            {
                string output = this.Layout.LayoutMaker(date, reportLevel, msg);
                Console.WriteLine(output);
            }
        }
    }
}
