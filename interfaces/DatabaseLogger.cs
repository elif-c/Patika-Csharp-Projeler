namespace interfaces;

public class DatabaseLogger : ILogger 
{
    public void writeLog()
    {
        Console.WriteLine("Logs on database.");
    }
}