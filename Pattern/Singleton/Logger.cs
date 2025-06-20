namespace DesignPatternsDemo.Singleton
{
    /// <summary>
    /// Singleton Logger class. Only one instance exists throughout the application.
    /// </summary>
    public sealed class Logger
    {
        private static readonly Logger _instance = new Logger();
        private static readonly object _lock = new object();
        private Logger() { }
        public static Logger Instance => _instance;

        /// <summary>
        /// Logs a message to the console (for demo purposes).
        /// </summary>
        public void Log(string message)
        {
            Console.WriteLine($"[Singleton Logger] {DateTime.Now}: {message}");
        }
    }
}
