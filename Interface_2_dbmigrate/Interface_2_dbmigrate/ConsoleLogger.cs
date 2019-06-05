using System;

namespace Interface_2_dbmigrate
{
    public class ConsoleLogger : Ilogger
    {
        public void LogError(string message)
        {
            Msg(message, false);
        }
        public void LogInfo(string message)
        {
            Msg(message, true);
        }
        private void Msg(string message, bool type)
        {
        if (type)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(message);
            }
        else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(message);
            }
        }

    }
}
