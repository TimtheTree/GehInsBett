using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using M.Api.Config;

namespace GehInsBett
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IConfiguration _bettConfig;

        public MainWindow()
        {
            InitializeComponent();
            _bettConfig = BettTimer.Config;
        }

        private void NiceButton_OnMouseEnter(object sender, MouseEventArgs e)
        {
            NiceButton.Background = Brushes.MediumAquamarine;
        }

        private void NiceButton_OnMouseLeave(object sender, MouseEventArgs e)
        {
            NiceButton.Background = Brushes.DarkSlateGray;
        }

        private void ButtonOnClick(object sender, MouseButtonEventArgs e)
        {
            var dateTime = TimePicker.SelectedTime!.Value;
            _bettConfig.Set("hour", dateTime.Hour);
            _bettConfig.Set("minute", dateTime.Minute);
            _bettConfig.Save();
            Close();
        }
        
    }
}