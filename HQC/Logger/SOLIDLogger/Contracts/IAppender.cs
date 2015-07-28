namespace SOLIDLogger.Contracts
{
    using System;

    public interface IAppender
    {
        ILayout Layout { get; }

        void Append(DateTime date, ReportLevel reportLevel, string msg);
    }
}
