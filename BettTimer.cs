using System;
using System.Diagnostics;
using System.Timers;
using M.Api.Config;
using M.App;
using Timer = System.Timers.Timer;

namespace GehInsBett;

public static class BettTimer
{
    public static IConfiguration Config { get; } = MApp.Instance.DefaultConfig;
    static BettTimer()
    {
    }

    public static void CheckTime()
    {
        var timer = new Timer(TimeSpan.FromMinutes(1));
        timer.Start();
        timer.Elapsed += TimerOnElapsed;
    }

    private static void TimerOnElapsed(object? sender, ElapsedEventArgs e)
    {
        if (DateTime.Now.Hour == Config.GetInt("hour") && DateTime.Now.Minute == Config.GetInt("minute"))
        {
            Process.Start("shutdown.exe", "/s /t 0");
        }
    }
}