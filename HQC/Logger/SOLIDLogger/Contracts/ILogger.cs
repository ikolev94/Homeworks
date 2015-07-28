namespace SOLIDLogger.Contracts
{
    using System.Collections.Generic;

    public interface ILogger
    {
        ICollection<IAppender> Appenders { get; }

        void Info(string message);

        void Warning(string message);

        void Error(string message);

        void Critical(string message);

        void Fatal(string message);
    }
}
