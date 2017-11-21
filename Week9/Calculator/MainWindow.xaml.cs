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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_calculate_Click(object sender, RoutedEventArgs e)
        {
            txt_result.Text = String.Format("{0:#########0.0000}", Calculate(Decimal.Parse(txt_operand1.Text), txt_operator.Text, Decimal.Parse(txt_operand2.Text)));
        }

        private decimal Calculate(decimal operand1,string operator1,decimal operand2)
        {


            if (operator1 == "+") return operand1 + operand2;
            else if (operator1 == "%") return operand1 % operand2;
            else if (operator1 == "*") return operand1 * operand2;
            else if (operator1 == "-") return operand1 - operand2;
            else if (operator1 == "/") return operand1 / operand2;
            return 0;

        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

       

        private void txt_operand1_TextChanged(object sender, TextChangedEventArgs e)
        {
            txt_result.Text = "";
        }

        private void txt_operator_TextChanged(object sender, TextChangedEventArgs e)
        {
            txt_result.Text = "";
        }

        private void txt_operand2_TextChanged(object sender, TextChangedEventArgs e)
        {
            txt_result.Text = "";
        }
    }
}
