//houssem.dellai@ieee.org 
//+216 95 325 964 

using System;
using System.Windows;
using System.Windows.Controls;

namespace MyCalculatorv1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            tb.Text += b.Content.ToString();
        }

        private void Result_click(object sender, RoutedEventArgs e)
        {
            try
            {
                result();
            }
            catch (Exception exc)
            {
                tb.Text = "Error!";
            }
        }

        private void result()
        {
            String op;
            int iOp = 0;
            if (tb.Text.Contains("+"))
            {
                iOp = tb.Text.IndexOf("+");
            }
            else if (tb.Text.Contains("-"))
            {
                iOp = tb.Text.IndexOf("-");
            }
            else if (tb.Text.Contains("*"))
            {
                iOp = tb.Text.IndexOf("*");
            }
            else if (tb.Text.Contains("/"))
            {
                iOp = tb.Text.IndexOf("/");
            }
            else
            {
                //error
            }

            op = tb.Text.Substring(iOp, 1);
            double op1 = Convert.ToDouble(tb.Text.Substring(0, iOp));
            double op2 = Convert.ToDouble(tb.Text.Substring(iOp + 1, tb.Text.Length - iOp - 1));

            if (op == "+")
            {
                tb.Text += "=" + (this.tambah(op1,op2));
            }
            else if (op == "-")
            {
                tb.Text += "=" + (this.kurang(op1,op2));
            }
            else if (op == "*")
            {
                tb.Text += "=" + (this.kali(op1,op2));
            }
            else
            {
                tb.Text += "=" + (this.bagi(op1,op2));
            }
        }

        private void Off_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Del_Click(object sender, RoutedEventArgs e)
        {
            tb.Text = "";
        }

        private void R_Click(object sender, RoutedEventArgs e)
        {
            if (tb.Text.Length > 0)
            {
                tb.Text = tb.Text.Substring(0, tb.Text.Length - 1);
            }
        }

        public double tambah(double oprand1, double operand2)
        {
            return oprand1 + operand2;
        }
        public double kurang(double operand1, double operand2)
        {
            return operand1 - operand2;
        }
        public double bagi(double operand1, double operand2)
        {
            if (operand2 != 0)
            {
                return operand1 /(double) operand2;
            }
            else if (operand2 == 0 && operand1 < 0)
            {
                return double.NegativeInfinity;
            }
            else
            {
                return double.PositiveInfinity;
            }
        }
        public double kali(double operand1, double operand2)
        {
            return operand1 * operand2;
        }
    }
}
