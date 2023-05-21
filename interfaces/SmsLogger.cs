namespace interfaces;

public class SmsLogger : ILogger
{
    public void writeLog()
    {
        // throw new NotImplementedException();
        Console.WriteLine("Logs on sms.");
    }
}