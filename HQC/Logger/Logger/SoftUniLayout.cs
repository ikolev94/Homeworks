namespace Logger
{
    using System;
    using System.Text;

    using SOLIDLogger;
    using SOLIDLogger.Contracts;

    public class SoftUniLayout : ILayout
    {
        public string LayoutMaker(DateTime date, ReportLevel reportLevel, string msg)
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine(string.Format("{0} SoftUni {0}", new string('*', 18)));
            output.AppendLine(string.Format("  \"text\" : \"{0}\"", date));
            output.AppendLine(string.Format("  \"level\" : \"{0}\"", reportLevel));
            output.AppendLine(string.Format("  \"date\" : \"{0}\"", msg));
            return output.ToString();
        }
    }
}
