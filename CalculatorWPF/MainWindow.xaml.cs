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

namespace CalculatorWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double number1;
        double number2;
        char operate;
        double result = 0;
        string lastOperation = "";
        double value;

        public MainWindow()
        {
            InitializeComponent();
        }

        public void ClickButton(object sender, RoutedEventArgs e)
        {
            if(result == 0)
            {
                Button button = (Button)sender;
                valueTextBox.Text += button.Content.ToString();
                number2 = Double.Parse(valueTextBox.Text);
            }
            else
            {
                result = 0;
                valueTextBox.Clear();
            }           
        }
        

        public void ClickSumButton(object sender, RoutedEventArgs e)
        {
            if(valueTextBox.Text != "")
            {
                number1 = Convert.ToDouble(valueTextBox.Text);
                operate = '+';
                valueTextBox.Clear();
                string tempLabel = number1.ToString() + " " + operate;
                firstOperationLabel.Content = tempLabel;
            }
            
        }

        public void DivideClick(object sender, RoutedEventArgs e)
        {
            if (valueTextBox.Text != "")
            {
                number1 = Convert.ToDouble(valueTextBox.Text);
                operate = '/';
                valueTextBox.Clear();
                string tempLabel = number1.ToString() + " " + operate;
                firstOperationLabel.Content = tempLabel;
            }
 
        }

        public void MultiplyButton(object sender, RoutedEventArgs e)
        {   
            if(valueTextBox.Text != "")
            {
                number1 = Convert.ToDouble(valueTextBox.Text);
                operate = '*';
                valueTextBox.Clear();
                string tempLabel = number1.ToString() + " " + operate;
                firstOperationLabel.Content = tempLabel;
            }
            
        }

        public void SubstractButton(object sender, RoutedEventArgs e)
        {
            if (valueTextBox.Text != "")
            {
                number1 = Convert.ToDouble(valueTextBox.Text);
                operate = '-';
                valueTextBox.Clear();
                string tempLabel = number1.ToString() + " " + operate;
                firstOperationLabel.Content = tempLabel;
            }
            

        }

        public void EqualsClick(object sender, RoutedEventArgs e)
        {
            if (valueTextBox.Text != "")
            {
                switch (operate)
                {
                    case '+':
                        result = number1 + number2;
                        lastOperation = number1.ToString() + " " + operate + " " + number2.ToString();
                        break;
                    case '-':
                        result = number1 - number2;
                        lastOperation = number1.ToString() + " " + operate + " " + number2.ToString();
                        break;
                    case '/':
                        result = number1 / number2;
                        lastOperation = number1.ToString() + " " + operate + " " + number2.ToString();
                        break;
                    case '*':
                        result = number1 * number2;
                        lastOperation = number1.ToString() + " " + operate + " " + number2.ToString();
                        break;
                    case '%':
                        result = number1 % number2;
                        lastOperation = number1.ToString() + " " + operate + " " + number2.ToString();
                        break;
                    default:
                        valueTextBox.Clear();
                        break;
                }

                lastOperationLabel.Content = lastOperation.ToString();
                number1 = result;
                firstOperationLabel.Content = "";
                valueTextBox.Text = result.ToString();
            }
            


        }

 
        public void ClearFirstVar(object sender, RoutedEventArgs e)
        {   
          
                number2 = 0;
                result = 0;
                valueTextBox.Clear();
            
           
        }

        public void ClearAllVar(object sender,RoutedEventArgs e)
        {
            
                number1 = 0;
                number2 = 0;
                result = 0;
                firstOperationLabel.Content = "";
                valueTextBox.Clear();
            
         
        }

        private void BackDigitButton(object sender, RoutedEventArgs e)
        {                         
                    string flag = valueTextBox.Text.ToString();
                    flag = flag.Substring(0, flag.Length - 1);
                    valueTextBox.Text = flag;                   
        }

        private void PercentageButton(object sender, RoutedEventArgs e)
        {
            if (valueTextBox.Text != "")
            {
                double temp;
                if (number2 != 0)
                {
                    temp = number2 / 100.0;
                    number2 = temp;
                }
                else if (number1 != 0)
                {
                    temp = number1 / 100.0;
                    number1 = temp;
                }
                else
                {
                    temp = 0;
                }

                value = temp;
                valueTextBox.Text = value.ToString();
            }
            
        }

        private void ChangeDirectionButton(object sender, RoutedEventArgs e)
        {
            if(valueTextBox.Text != "")
            {
                double var = Convert.ToDouble(valueTextBox.Text);
                var *= -1;
                valueTextBox.Text = var.ToString();
            }
        }

        private void SqrtButton(object sender, RoutedEventArgs e)
        {

            if(valueTextBox.Text != "")
            {
                long var = Convert.ToInt64(valueTextBox.Text);
                double value = Math.Sqrt(var);
                valueTextBox.Text = value.ToString();
            }
        }

        private void ExponentiationButton(object sender, RoutedEventArgs e)
        {
            if(valueTextBox.Text != "")
            {
                double value = Convert.ToDouble(valueTextBox.Text);
                value *= value;
                valueTextBox.Text = value.ToString();
            }
        }

        private void ModOperationButton(object sender, RoutedEventArgs e)
        {
            if(valueTextBox.Text != "")
            {
                

                number1 = Convert.ToDouble(valueTextBox.Text);
                operate = '%';
                valueTextBox.Clear();
                string tempLabel = number1.ToString() + " " + operate;
                firstOperationLabel.Content = tempLabel;


            }
        }

        private void InverseButton(object sender, RoutedEventArgs e)
        {
            if(valueTextBox.Text != "")
            {
                double val = Convert.ToDouble(valueTextBox.Text);

                val = 1/val;

                valueTextBox.Text = val.ToString();
            }
        }

        private void RoundUpButton(object sender, RoutedEventArgs e)
        {
           

            if (valueTextBox.Text != "")
            {
                double val = Convert.ToDouble(valueTextBox.Text);

                val = Math.Ceiling(val);

                valueTextBox.Text = val.ToString();
            }
        }

        private void RoundDownButton(object sender, RoutedEventArgs e)
        {
            if (valueTextBox.Text != "")
            {
                double val = Convert.ToDouble(valueTextBox.Text);

                val = Math.Floor(val);

                valueTextBox.Text = val.ToString();
            }
        }

        private void LogButton(object sender, RoutedEventArgs e)
        {
            
            double val = Convert.ToDouble(valueTextBox.Text);
            if(valueTextBox.Text != "")
            {
                int counter = 0;
                for (int i = 10; i < 1000000; i *= 10)
                {
                    counter++;
                    if (i == Convert.ToInt32(val))
                    {
                        valueTextBox.Text = counter.ToString();
                    }
                }
            }
            
        }
    }
}
