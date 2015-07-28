namespace Logger
{
    using SOLIDLogger;
    using SOLIDLogger.Appenders;
    using SOLIDLogger.Layouts;

    public class Program
    {
        public static void Main()
        {
            var simpleLayout = new SimpleLayout();
            var jsonLayout = new JsonLayout();

            // var myLayout = new SoftUniLayout();
            var consoleAppender = new ConsoleAppender(simpleLayout);
            consoleAppender.ReportLevel = ReportLevel.Error;
            consoleAppender.ReportLevel = ReportLevel.Error;
            var fileAppender = new FileAppendder(jsonLayout, "../../Log.txt");
            fileAppender.ReportLevel = ReportLevel.Error;
            var logger = new Logger(consoleAppender, fileAppender);

            logger.Error("Error parsing JSON.");
            logger.Warning("User John successfully registered");
            logger.Info("Everything seems fine");
            logger.Warning("Warning: ping is too high - disconnect imminent");
            logger.Error("Error parsing request");
            logger.Critical("No connection string found in App.config");
            logger.Fatal("mscorlib.dll does not respond");
            fileAppender.Close();
        }
    }
}
