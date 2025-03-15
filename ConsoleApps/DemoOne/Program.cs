using System;
using DemoOne.Handler;
using DemoOne.Handlers;

class Program
{
    static void Main()
    {
        Logger debugLogger = new DebugLogger();
        Logger infoLogger = new InfoLogger();
        Logger errorLogger = new ErrorLogger();

        debugLogger.SetNext(infoLogger);
        infoLogger.SetNext(errorLogger);

        debugLogger.LogMessage("This is a debug message", LogLevel.Debug);
        debugLogger.LogMessage("This is an info message", LogLevel.Info);
        debugLogger.LogMessage("This is an error message", LogLevel.Error);
    }
}
