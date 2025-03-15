namespace DemoOne.Handlers;

class ErrorLogger : Logger
{
    protected override bool CanHandle(LogLevel level) 
        => level == LogLevel.Error;

    protected override void Write(string message) 
        => Console.WriteLine("[ERROR]: " + message);
}
