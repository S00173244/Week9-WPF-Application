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

namespace Factorial
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
            decimal factorial = 1;
            for (int i = 1; i <= int.Parse(txt_number.Text); i++)
            {
                factorial *= i;
            }

            
            txt_factorial.Text = String.Format("{0: ###,###}", factorial.ToString());
            

        }
    }
}
