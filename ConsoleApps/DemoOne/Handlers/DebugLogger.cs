namespace DemoOne.Handlers;

class DebugLogger : Logger
{
    protected override bool CanHandle(LogLevel level) 
        => level == LogLevel.Debug;

    protected override void Write(string message) 
        => Console.WriteLine("[DEBUG]: " + message);
}