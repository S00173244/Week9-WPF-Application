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

namespace Week9
{

   
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        int scoreTotal = 0;
        int scoreCount = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            int score = int.Parse(txt_score.Text);
            scoreTotal += score;
            scoreCount++;

            txt_sTotal.Text = scoreTotal.ToString();
            txt_sCount.Text = scoreCount.ToString();
            txt_average.Text = (scoreTotal / scoreCount).ToString();

            txt_score.Focus();

        }

        private void btn_clear_Click(object sender, RoutedEventArgs e)
        {
            scoreTotal = 0;
            scoreCount = 0;
            txt_score.Text = 0.ToString();
            txt_sTotal.Text = 0.ToString();
            txt_sCount.Text = 0.ToString();
            txt_average.Text = 0.ToString();

            txt_score.Focus();
        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
