namespace DemoOne.Handlers;

abstract class Logger
{
    protected Logger? NextLogger;

    public void SetNext(Logger nextLogger)
    {
        NextLogger = nextLogger;
    }

    public void LogMessage(string message, LogLevel level)
    {
        if (CanHandle(level))
        {
            Write(message);
        }
        NextLogger?.LogMessage(message, level);
    }

    protected abstract bool CanHandle(LogLevel level);
    protected abstract void Write(string message);
}