using DemoOne.Handlers;

namespace DemoOne.Handler;

class InfoLogger : Logger
{
    protected override bool CanHandle(LogLevel level) 
        => level == LogLevel.Info;

    protected override void Write(string message) 
        => Console.WriteLine("[INFO]: " + message);
}