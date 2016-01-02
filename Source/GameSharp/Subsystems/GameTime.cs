using System;
using System.Diagnostics;

static class GameTime
{
    static Stopwatch stopwatch = Stopwatch.StartNew();
    static TimeSpan previous = TimeSpan.Zero;

    public static TimeSpan Elapsed
    {
        get
        {
            return stopwatch.Elapsed;
        }
    }

    public static TimeSpan Step { get; private set; }

    public static void Update()
    {
        Step = Elapsed - previous;
        previous = Elapsed;
    }
}
