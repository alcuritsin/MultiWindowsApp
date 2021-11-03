using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace MultyWindowApp
{
    public partial class MainWindow : Window
    {
        int timerLeft;
        DispatcherTimer dt;
        public MainWindow()
        {
            InitializeComponent();
            timerLeft = 0;
            Lable_timer.Content = $"Timer: {timerLeft} sec.";
            dt = new DispatcherTimer();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dt.Interval = new TimeSpan(0, 0, 1);
            dt.Tick += new EventHandler(dispatcherTimer_Tick);
        }

        private void dispatcherTimer_Tick(object? sender, EventArgs e)
        {
            if (timerLeft > 0)
            {
                timerLeft--;
                Lable_timer.Content = $"Timer: {timerLeft} sec.";
            }
            else
            {
                dt.Stop();
                Lable_timer.Content = $"Show new window...";
            
                var win = new WinTab();

                win.Show();
                Close();
            }
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            dt.Start();
        }

    }
}
