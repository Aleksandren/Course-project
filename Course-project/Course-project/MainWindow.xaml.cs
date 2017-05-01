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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            HowWindow HowWindow = new HowWindow();
            HowWindow.Show();
            Hide();
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

    }
    class RPN
    {
        //Метод Calculate принимает выражение в виде строки и возвращает результат, в своей работе использует другие методы класса
        static public double Calculate(string input)
        {
            string output = GetExpression(input); //Преобразовываем выражение в постфиксную запись
            double result = Counting(output); //Решаем полученное выражение
            return result; 
        }

        //Метод, преобразующий входную строку с выражением в постфиксную запись
        static private string GetExpression(string input)
        {
            string output = string.Empty; 
            Stack<char> operStack = new Stack<char>(); 

            for (int i = 0; i < input.Length; i++) 
            {
                if (IsDelimeter(input[i]))
                    continue; 

                if (Char.IsDigit(input[i])) 
                {
                    while (!IsDelimeter(input[i]) && !IsOperator(input[i]))
                    {
                        output += input[i]; 
                        i++; 

                        if (i == input.Length) break; 
                    }

                    output += " "; 
                    i--; 
                }

              
                if (IsOperator(input[i])) 
                {
                    if (input[i] == '(') 
                        operStack.Push(input[i]);
                    else if (input[i] == ')') 
                    {
                        char s = operStack.Pop();
                        while (s != '(')
                        {
                            output += s.ToString() + ' ';
                            s = operStack.Pop();
                        }
                    }
                    else 
                    {
                        if (operStack.Count > 0) 
                            if (GetPriority(input[i]) <= GetPriority(operStack.Peek())) 
                                output += operStack.Pop().ToString() + " "; 

                        operStack.Push(char.Parse(input[i].ToString())); 

                    }
                }
            }

                     while (operStack.Count > 0)
                output += operStack.Pop() + " ";

            return output; 
        }

        static private double Counting(string input)
        {
            double result = 0; 
            Stack<double> temp = new Stack<double>(); 

            for (int i = 0; i < input.Length; i++) 
            {
                if (Char.IsDigit(input[i]))
                {
                    string a = string.Empty;

                    while (!IsDelimeter(input[i]) && !IsOperator(input[i])) 
                    {
                        a += input[i]; 
                        i++;
                        if (i == input.Length) break;
                    }
                    temp.Push(double.Parse(a)); 
                    i--;
                }
                else if (IsOperator(input[i])) 
                {
                  
                    double a = temp.Pop();
                    double b = temp.Pop();

                    switch (input[i]) 
                    {
                        case '+': result = b + a; break;
                        case '-': result = b - a; break;
                        case '*': result = b * a; break;
                        case '/': result = b / a; break;
                        case '^': result = double.Parse(Math.Pow(double.Parse(b.ToString()), double.Parse(a.ToString())).ToString()); break;

                    }
                    temp.Push(result); 
                }
            }
            return temp.Peek(); 
        }

        //Метод возвращает true, если проверяемый символ - разделитель ("пробел" или "равно")
        static private bool IsDelimeter(char c)
        {
            if ((" =".IndexOf(c) != -1))
                return true;
            return false;
        }

        //Метод возвращает true, если проверяемый символ - оператор
        static private bool IsOperator(char с)
        {
            if (("+-/*^()".IndexOf(с) != -1))
                return true;
            return false;
        }
        //Метод возвращает приоритет оператора
        static private byte GetPriority(char s)
        {
            switch (s)
            {
                case '(': return 0;
                case ')': return 0;
                case '+': return 1;
                case '-': return 1;
                case '*': return 2;
                case '/': return 2;
                case '^': return 3;
                default: return 6;
            }
        }
     }
}
