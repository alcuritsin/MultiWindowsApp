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

namespace MultyWindowApp
{
    public partial class Win : Window
    {
        public Win()
        {
            InitializeComponent();
        }

        private void Button_NextStep_Click(object sender, RoutedEventArgs e)
        {
            var win2 = new Win2(TextBox_FirstName.Text, TextBox_SecondName.Text);

            win2.Show();
            Close();
        }
    }
}
