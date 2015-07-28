namespace SOLIDLogger.Layouts
{
    using System;
    using System.Text;
    using SOLIDLogger.Contracts;

    public class JsonLayout : ILayout
    {
        public string LayoutMaker(DateTime date, ReportLevel reportLevel, string msg)
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine("{");
            output.AppendLine(string.Format("  \"text\" : \"{0}\"", date));
            output.AppendLine(string.Format("  \"level\" : \"{0}\"", reportLevel));
            output.AppendLine(string.Format("  \"date\" : \"{0}\"", msg));
            output.AppendLine("}");

            return output.ToString();
        }
    }
}
