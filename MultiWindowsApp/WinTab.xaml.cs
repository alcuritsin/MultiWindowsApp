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
    /// <summary>
    /// Interaction logic for WinTab.xaml
    /// </summary>
    public partial class WinTab : Window
    {
        double _income;
        double _expenses;

        public WinTab()
        {
            InitializeComponent();
            _income = 0;
            _expenses = 0;

            TextBlock_Income.Text = "0,00";
            TextBlock_Expenses.Text = "0,00";
            TextBlock_Budget.Text = "0,00";
            TextBox_Sum.Text = "0,00";
        }

        private void Button_AddIncome_Click(object sender, RoutedEventArgs e)
        {
            _income += Convert.ToDouble(TextBox_Sum.Text);
            TextBox_Sum.Text = "0,00";
            Budget();
        }

        private void Button_AddExpenses_Click(object sender, RoutedEventArgs e)
        {
            _expenses += Convert.ToDouble(TextBox_Sum.Text);
            TextBox_Sum.Text = "0,00";
            Budget();
        }

        private void Budget()
        {
            TextBlock_Budget.Text = (_income - _expenses).ToString();
            TextBlock_Income.Text = _income.ToString();
            TextBlock_Expenses.Text = _expenses.ToString();
        }
    }
}
