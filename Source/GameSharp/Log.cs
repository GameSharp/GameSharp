using System;
using System.IO;

namespace GameSharp
{
    public static class Log
    {
        private static StreamWriter streamWriter = null;
        
        private static string Timestamp
        {
            get
            {
                return DateTime.Now.ToString("G");
            }
        }

        public static void Open(string fileName)
        {
            if (streamWriter != null)
                Close();
            streamWriter = new StreamWriter(fileName);
            streamWriter.AutoFlush = true;
            WriteLine("Opened log file " + Path.GetFullPath(fileName));
        }
        
        public static void Close()
        {
            if (streamWriter != null)
            {
                streamWriter.Dispose();
                streamWriter = null;
            }
        }
        
        public static void WriteRaw(string message)
        {
            streamWriter.Write(message);
        }
        
        public static void WriteLine(string message)
        {
            streamWriter.WriteLine("[" + Timestamp + "] " + message);
        }
    }
}
