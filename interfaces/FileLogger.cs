namespace interfaces;

public class FileLogger : ILogger
{
    public void writeLog()
    {
        Console.WriteLine("Logs on file.");
    }
}