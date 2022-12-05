using System;
using System.IO;

namespace GehInsBett;

public static class Autostart
{
    public static void Create()
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