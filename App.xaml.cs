using M.App;

namespace GehInsBett;

public partial class App
{
    public App()
    {
        BettTimer.CheckTime();
        new MApp("gib");
    }
}