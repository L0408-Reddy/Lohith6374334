using System;

namespace SingletonPatternExample
{
    public sealed class Logger
    {
        private static Logger? _instance = null;
        private static readonly object _lock = new();

        // Private constructor ensures it cannot be instantiated externally
        private Logger()
        {
            Console.WriteLine("Logger Initialized.");
        }

        // Public static method to get the instance
        public static Logger Instance
        {
            get
            {
                // Double-check locking for thread safety
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new Logger();
                        }
                    }
                }
                return _instance;
            }
        }

        // Sample method for logging
        public void Log(string message)
        {
            Console.WriteLine($"[Log] {message}");
        }
    }
}
