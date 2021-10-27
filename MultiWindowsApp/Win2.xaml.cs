using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace MultyWindowApp
{
    /// <summary>
    /// Interaction logic for Win2.xaml
    /// </summary>
    public partial class Win2 : Window
    {
        int timerLeft;
        DispatcherTimer dt = new DispatcherTimer();

        public Win2()
        {
            InitializeComponent();
        }

        public Win2(string FirstName, string SecondName)
        {
            InitializeComponent();

            Label_FirstName.Content = FirstName;
            Label_SecondName.Content = SecondName;

            timerLeft = 5;
            Button_Exit.Content = $"Выход ({timerLeft})";

        }

        private void Button_Exit_Click(object sender, RoutedEventArgs e)
        {
            EndApp();
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
                Button_Exit.Content = $"Выход ({timerLeft})";
            }
            else
            {
                EndApp();
            }
        }

        private void EndApp()
        {
            dt.Stop();
            Button_Exit.Content = $"Выход...";
            Close();
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            dt.Start();
        }


    }
}
