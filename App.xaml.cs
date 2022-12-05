using M.App;

namespace GehInsBett;

public partial class App
{
    public App()
    {
        new MApp("gib").MakeAppFolder("GehInsBett");
        BettTimer.CheckTime();
        Autostart.Create();
    }
}