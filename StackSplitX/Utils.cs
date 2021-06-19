using StardewModdingAPI;

namespace StackSplitX
{
    public static class Log
        {
        private static IMonitor Monitor;
        public static void Init(IMod mod) {
            Log.Monitor = mod.Monitor;
            }
        public static void Error(string msg) => Monitor.Log(msg, LogLevel.Error);
        public static void Warn(string msg) => Monitor.Log(msg, LogLevel.Warn);
        public static void Info(string msg) => Monitor.Log(msg, LogLevel.Info);
        public static void Debug(string msg) => Monitor.Log(msg, LogLevel.Debug);
        public static void Trace(string msg) => Monitor.Log(msg, LogLevel.Trace);
        public static void TraceIfD(string msg) {
#if DEBUG
            Trace(msg);
#endif
            }
        }
}
