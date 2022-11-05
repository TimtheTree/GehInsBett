using System;
using System.Diagnostics;
using System.Timers;
using Timer = System.Timers.Timer;

namespace GehInsBett;

public static class BettTimer
{
    public static void CheckTime()
    {
        var timer = new Timer(TimeSpan.FromMinutes(1));
        timer.Start();
        timer.Elapsed += TimerOnElapsed;
    }

    private static void TimerOnElapsed(object? sender, ElapsedEventArgs e)
    {
        if (DateTime.Now.Hour == 22 && DateTime.Now.Minute == 0)
        {
            Process.Start("shutdown.exe", "/s /t 0 /c 'Geh ins Bett!'");
        }
    }
}