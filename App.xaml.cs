using System.Diagnostics;
using M.App;

namespace GehInsBett;

public partial class App
{
    public App()
    {
        string name;
        if (Protocol.Check())
        {
            name = "gib";
        }
        else
        {
            name = "GehInsBett";
        }
        new MApp("gib").MakeAppFolder("GehInsBett");
        var processes = Process.GetProcessesByName(name);
        foreach (var process in processes)
        {
            if (process.Id != System.Environment.ProcessId)
            {
                process.Kill();
            }
        }
        BettTimer.CheckTime();
        Autostart.Create();
    }
}