using System;

namespace interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            FileLogger fileLogger = new FileLogger();
            fileLogger.WriteLog();

            SmsLogger smsLogger = new();
            smsLogger.WriteLog();

            DatabaseLogger databaseLogger = new();
            databaseLogger.WriteLog();

            LogManager logManager = new LogManager(new FileLogger());
            logManager.WriteLog();
        }
    }
}
