using Microsoft.Win32;

namespace GehInsBett;

public static class Protocol
{
    internal static bool Check()
    {
        try
        {
            return Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Classes\mpm\shell\open\command") != null;
        }
        catch
        {
            return false;
        }
    }
}