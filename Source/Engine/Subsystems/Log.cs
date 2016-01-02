using System;
using System.IO;

static class Log
{
    static StreamWriter streamWriter = null;
        
    public static void Init(string fileName)
    {
        streamWriter = new StreamWriter(fileName);
        streamWriter.AutoFlush = true;
        WriteLine("Opened log file " + Path.GetFullPath(fileName));
    }
        
    public static void WriteRaw(string message)
    {
        streamWriter.Write(message);
    }
        
    public static void WriteLine(string message)
    {
        var timestamp = DateTime.Now.ToString("G");
        streamWriter.WriteLine("[" + timestamp + "] " + message);
    }
}
