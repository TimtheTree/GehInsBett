using System;
using System.IO;

namespace GehInsBett;

public static class Autostart
{
    public static void Create()
    {
        if (Protocol.Check())
        {
            CreateMpm();
        }
        else
        {
            CreateUniversal();
        }
    }
    public static void CreateMpm()
    {
        var startUpDir = Environment.GetFolderPath(Environment.SpecialFolder.Startup);

        using var writer = new StreamWriter($"{startUpDir}\\GehInsBett.url");
        writer.WriteLine("[InternetShortcut]");
        writer.WriteLine("URL=mpm:\"gib\"");
        writer.WriteLine("IconIndex=0");
        var app = System.Reflection.Assembly.GetExecutingAssembly().Location.Replace("dll", "exe");
        var icon = app.Replace('\\', '/');
        writer.WriteLine("IconFile=" + icon);
    }

    public static void CreateUniversal()
    {
        var startUpDir = Environment.GetFolderPath(Environment.SpecialFolder.Startup);

        using var writer = new StreamWriter($"{startUpDir}\\GehInsBett.url");
        var app = System.Reflection.Assembly.GetExecutingAssembly().Location.Replace("dll", "exe");
        writer.WriteLine("[InternetShortcut]");
        writer.WriteLine("URL=file:///" + app);
        writer.WriteLine("IconIndex=0");
        var icon = app.Replace('\\', '/');
        writer.WriteLine("IconFile=" + icon);
    }
}