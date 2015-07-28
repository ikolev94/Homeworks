namespace SOLIDLogger.Contracts
{
    using System;

    public interface ILayout
    {
        string LayoutMaker(DateTime date, ReportLevel reportLevel, string msg);
    }
}
