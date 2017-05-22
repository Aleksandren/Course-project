//Медведский А.В. 52492 Трансляция и вычисление произвольных арифметических выражений.
//Главное окно

using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Animation;
using System.Diagnostics;

namespace Course_project
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text += "1";
        }

        private void btn_2_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text += "2";
        }

        private void btn_3_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text += "3";
        }

        private void btn_4_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text += "4";
        }

        private void btn_5_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text += "5";
        }

        private void btn_6_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text += "6";
        }

        private void btn_7_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text += "7";
        }

        private void btn_8_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text += "8";
        }

        private void btn_9_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text += "9";
        }

        private void btn_0_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text += "0";
        }

        private void btn_plus_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text += "+";
        }

        private void btn_mul_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text += "*";
        }

        private void btn_min_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text += "-";
        }

        private void btn_div_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text += "/";
        }

        private void btn_sub_1_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text += "(";
        }

        private void btn_sub_2_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text += ")";
        }

        private void btn_pow_Click(object sender, RoutedEventArgs e)
        {

            textBox.Text += "^";
        }

        private void btn_dot_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text += ",";
        }

        private void btn_equal_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text += "=" + Convert.ToString(RPN.Calculate(textBox.Text));
        }
              
        private void btn_del_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text.Length > 0)
            {
                textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
            }
        }

        private void textBox_PreviewTextInput_1(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "0123456789+-*/^ ,()".IndexOf(e.Text) < 0;
        }

         private void btnRightMenuHide_Click(object sender, RoutedEventArgs e)
         {
             ShowHideMenu("sbHideRightMenu", btnRightMenuHide, btnRightMenuShow, pnlRightMenu);
         }

         private void btnRightMenuShow_Click(object sender, RoutedEventArgs e)
         {
             ShowHideMenu("sbShowRightMenu", btnRightMenuHide, btnRightMenuShow, pnlRightMenu);
         }

        private void ShowHideMenu(string Storyboard, Button btnHide, Button btnShow, StackPanel pnl)
        {
            Storyboard sb = Resources[Storyboard] as Storyboard;
            sb.Begin(pnl);

            if (Storyboard.Contains("Show"))
            {
                btnHide.Visibility = System.Windows.Visibility.Visible;
                btnShow.Visibility = System.Windows.Visibility.Hidden;
            }
            else if (Storyboard.Contains("Hide"))
            {
                btnHide.Visibility = System.Windows.Visibility.Hidden;
                btnShow.Visibility = System.Windows.Visibility.Visible;
            }
        }

        private void ShowHelp_Click(object sender, RoutedEventArgs e)
        {
          Process.Start("Help.chm");
        }

        private void ShowTest_Click(object sender, RoutedEventArgs e)
        {
            Test test = new Test();
            test.Show();

        }
    }

}
