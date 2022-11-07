using System.Windows;

namespace GehInsBett
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var bettConfig = BettTimer.Config;
            bettConfig.Set("hour", 22);
            bettConfig.Set("minute", 0);
        }
    }
}