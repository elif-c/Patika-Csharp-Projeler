namespace interfaces;

public class LogManager
{
    public ILogger _logger;

    public LogManager(ILogger logger)
    {
        _logger = logger;
    }

    public void WriteLog()
    {
        _logger.writeLog();
    }

}
