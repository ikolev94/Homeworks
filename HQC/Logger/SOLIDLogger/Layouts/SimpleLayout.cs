namespace SOLIDLogger.Layouts
{
    using System;

    using SOLIDLogger.Contracts;

    public class SimpleLayout : ILayout
    {
        public string LayoutMaker(DateTime date, ReportLevel reportLevel, string msg)
        {
            return string.Format("{0} - {1} - {2}", date, reportLevel, msg);
        }
    }
}
