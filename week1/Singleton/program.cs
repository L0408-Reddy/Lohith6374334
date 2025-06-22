
using System;

namespace SingletonPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger1 = Logger.Instance;
            Logger logger2 = Logger.Instance;

            logger1.Log("This is the first log message.");
            logger2.Log("This is the second log message.");

            // Check if both instances are the same
            Console.WriteLine($"Are both loggers the same instance? {ReferenceEquals(logger1, logger2)}");
        }
    }
}
