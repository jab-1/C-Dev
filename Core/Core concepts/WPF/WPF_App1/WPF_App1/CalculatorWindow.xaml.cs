using Calculator_Model;
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

namespace WPF_App1
{
    /// <summary>
    /// Interaction logic for CalculatorWindow.xaml
    /// </summary>
    public partial class CalculatorWindow : Window
    {
        private Calculator _calulator;
        public CalculatorWindow()
        {
            _calulator = new Calculator();
            InitializeComponent();
        }

        private void tbxNum1_TextChanged(object sender, TextChangedEventArgs e)
        {
            var success = double.TryParse(tbxNum1.Text, out double num1);
            if (success)
            {
                _calulator.Num1 = num1;
            }
            else
            {
                lblResult.Content = "Invalid input";
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult confirm = MessageBox.Show("You sure you wanna add that stuff?", "Confirmation", MessageBoxButton.YesNo);
            if (confirm == MessageBoxResult.Yes)
            {
                lblResult.Content = _calulator.Add();
            }
            else if (confirm == MessageBoxResult.No)
            {
                lblResult.Content = "No adding";
            }

        }

        private void tbxNum2_TextChanged(object sender, TextChangedEventArgs e)
        {
            var success = double.TryParse(tbxNum2.Text.Trim(), out double num2);
            if (success)
            {
                _calulator.Num2 = num2;
            }
            else
            {
                lblResult.Content = "Invalid input";
            }
        }
    }
}