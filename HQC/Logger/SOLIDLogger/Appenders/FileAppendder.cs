namespace SOLIDLogger.Appenders
{
    using System;
    using System.IO;
    using SOLIDLogger.Contracts;

    public class FileAppendder : Appender
    {
        private readonly StreamWriter writer;

        public FileAppendder(ILayout layout, string path)
            : base(layout)
        {
            this.writer = new StreamWriter(path);
        }

        public void Close()
        {
            this.writer.Close();
        }

        public override void Append(DateTime date, ReportLevel reportLevel, string msg)
        {
            if (this.ValidReporLevel(reportLevel))
            {
                string output = this.Layout.LayoutMaker(date, reportLevel, msg);
                this.writer.Write(output);
            }
        }
    }
}
