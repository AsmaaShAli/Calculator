using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calculator_test
{
    public partial class Calc_form : Form
    {
        public Calc_form()
        {
            InitializeComponent();
        }

        double x, y;
        double result = 0;
        char function = '0';
        bool firstInput_afterFunction = false;
        bool equal_flag = false;
        bool plus_minus_flag = false;
        double Memory = 0;
        string[] equation = new string[3];

        void clear_all()
        {
            x = 0;
            y = 0;
            result = 0;
            function = '0';
            firstInput_afterFunction = false;
            equal_flag = false;
            plus_minus_flag = false;
            Memory = 0;
            Screen.Text = "";
            screen2.Text = "";
            point.Enabled = true;
            clear_equation();

        }
        void clear_equation()
        {
            for (int i = 0; i < equation.Length; i++)
                equation[i] = null;
        }
        void printToScreen(string s)
        {
            if (firstInput_afterFunction || equal_flag )
            {
                Screen.Text = "";
                firstInput_afterFunction = false;
                equal_flag = false;
                
            }
            Screen.Text += s;

        }

        void determineFunction(char f)
        {
            function = f;
            x = Convert.ToDouble(Screen.Text);

            if (firstInput_afterFunction)
            {
                screen2.Text = screen2.Text.Remove(screen2.Text.Length - 2, 2);
                screen2.Text = screen2.Text.Insert(screen2.Text.Length, function.ToString() + " ");
                equation[1] = function.ToString();
            }
            else
            {
                screen2.Text += x.ToString() + " " + function.ToString() + " ";


                firstInput_afterFunction = true;
                point.Enabled = true;

                if (equation[0] == null)
                {
                    equation[0] = x.ToString();
                    equation[1] = function.ToString();
                }
                else
                {
                    equation[2] = x.ToString();
                    perform_equation();
                }
            }
        }

        void perform_equation()
        {
            char temp_f;
            x = Convert.ToDouble(equation[0]);
            temp_f = Convert.ToChar(equation[1]);
            y = Convert.ToDouble(equation[2]);

            perform_function(x, y, temp_f);
            Screen.Text = result.ToString();

            equation[0] = result.ToString();
            equation[1] = function.ToString();

        }
        void perform_function( double x,  double y,  char f)
        {
                switch (f)
                {
                    case '+':
                        result = x + y;
                        break;
                    case '-':
                        result = x - y;
                        break;
                    case '*':
                        result = x * y;
                        break;
                    case '/':
                        result = x / y;
                        break;

                }
            
        }

        double Percentage(double x, double p)
        {
            double result = 0;
            result = (p * x) / 100;
            return result;
        }

        bool checkNotZero(double x)
        {
            if (x == 0)
                return false;
            else
                return true;
        }

        double reciproc_function(double x)
        {
            double r = 1 / x;
            return r;
        }

        private void one_Click(object sender, EventArgs e)
        {
            printToScreen("1");         
        }

        private void two_Click(object sender, EventArgs e)
        {
            printToScreen("2"); 
        }

        private void three_Click(object sender, EventArgs e)
        {
            printToScreen("3"); 
        }

        private void four_Click(object sender, EventArgs e)
        {
            printToScreen("4"); 
        }

        private void five_Click(object sender, EventArgs e)
        {
            printToScreen("5"); 
        }

        private void six_Click(object sender, EventArgs e)
        {
            printToScreen("6"); 
        }

        private void seven_Click(object sender, EventArgs e)
        {
            printToScreen("7"); 
        }

        private void eight_Click(object sender, EventArgs e)
        {
            printToScreen("8"); 
        }

        private void nine_Click(object sender, EventArgs e)
        {
            printToScreen("9"); 
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (Screen.Text !="" && !equal_flag && !firstInput_afterFunction)
                printToScreen("0"); 
        }

        private void point_Click(object sender, EventArgs e)
        {
            if (Screen.Text == ""|| firstInput_afterFunction )
                printToScreen("0."); 
            else
                printToScreen(".");

            point.Enabled = false;
        }

        private void plus_Click(object sender, EventArgs e)
        {
            determineFunction('+'); 
        }

        private void minus_Click(object sender, EventArgs e)
        {
            determineFunction('-');
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            determineFunction('*');
        }

        private void divide_Click(object sender, EventArgs e)
        {
            determineFunction('/');
        }



        private void plus_minus_Click(object sender, EventArgs e)
        {
            if (!plus_minus_flag)
            {
                plus_minus_flag = true;
                Screen.Text = Screen.Text.Insert(0, "-");
            }
            else
            {
                plus_minus_flag = false;
                Screen.Text = Screen.Text.Remove(0, 1);
            }
        }

        private void back_spc_Click(object sender, EventArgs e)
        {
            if (Screen.Text.Length > 0 && !equal_flag && !firstInput_afterFunction)
            {
                if (Screen.Text[Screen.Text.Length - 1] == '.')
                    point.Enabled = true;

                Screen.Text = Screen.Text.Remove(Screen.Text.Length - 1, 1);
            }
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            double square_root = Convert.ToDouble(Screen.Text);
            square_root = Math.Sqrt(square_root);
            Screen.Text = square_root.ToString();
            firstInput_afterFunction = true;
        }

        private void percent_Click(object sender, EventArgs e)
        {
            if (function != '0')
            {
                double r = Percentage(x, Convert.ToDouble(Screen.Text));
                Screen.Text = r.ToString();
            }
            else
            {
                Screen.Text = "0";
                firstInput_afterFunction = true;
            }
        }

        private void reciproc_Click(object sender, EventArgs e)
        {
            if (checkNotZero(Convert.ToDouble(Screen.Text)))
            {
                Screen.Text = reciproc_function(Convert.ToDouble(Screen.Text)).ToString();
                firstInput_afterFunction = true;
            }
            else
                Screen.Text = "You cannot divide by ZERO";
        }

        private void m_store_Click(object sender, EventArgs e)
        {
            if (Screen.Text != "" )
                Memory = Convert.ToDouble(Screen.Text);
        }

        private void memory_Click(object sender, EventArgs e)
        {
            Screen.Text = Memory.ToString();
        }

        private void m_clear_Click(object sender, EventArgs e)
        {
            Memory = 0;
        }

        private void m_plus_Click(object sender, EventArgs e)
        {
            if (Screen.Text != "")
                Memory = Memory + Convert.ToDouble(Screen.Text);
        }

        private void m_minus2_Click(object sender, EventArgs e)
        {
            if (Screen.Text != "")
                Memory = Memory + Convert.ToDouble(Screen.Text);
        }

        private void c_entry_Click(object sender, EventArgs e)
        {
            if (function != '0')
            {
                firstInput_afterFunction = true;
                if (!point.Enabled)
                    point.Enabled = true;
            }
            Screen.Text = "";
            
        }

        private void clear_Click(object sender, EventArgs e)
        {
            clear_all();
        }

        private void equal_Click(object sender, EventArgs e)
        {
            y = Convert.ToDouble(Screen.Text);
            if (function == '/' && y == 0)
                Screen.Text = "You cannot divide by ZERO!";
            else
            {
                if (result != 0)
                    perform_function(result, y, function);
                else
                    perform_function(x, y, function);

                Screen.Text = result.ToString();
            }
            equal_flag = true;
            screen2.Text = "";
            result = 0;
            clear_equation();

        }
        private void Calc_form_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad0:
                    e.Handled = true;
                    zero.PerformClick();
                    break;

                case Keys.NumPad1:
                    e.Handled = true;
                    one.PerformClick();
                    break;

                case Keys.NumPad2:
                    e.Handled = true;
                    two.PerformClick();
                    break;

                case Keys.NumPad3:
                    e.Handled = true;
                    three.PerformClick();
                    break;

                case Keys.NumPad4:
                    e.Handled = true;
                    four.PerformClick();
                    break;

                case Keys.NumPad5:
                    e.Handled = true;
                    five.PerformClick();
                    break;

                case Keys.NumPad6:
                    e.Handled = true;
                    six.PerformClick();
                    break;

                case Keys.NumPad7:
                    e.Handled = true;
                    seven.PerformClick();
                    break;

                case Keys.NumPad8:
                    e.Handled = true;
                    eight.PerformClick();
                    break;

                case Keys.NumPad9:
                    e.Handled = true;
                    nine.PerformClick();
                    break;

                case Keys.Add:
                    e.Handled = true;
                    plus.PerformClick();
                    break;

                case Keys.Divide:
                    e.Handled = true;
                    divide.PerformClick();
                    break;

                case Keys.Subtract:
                    e.Handled = true;
                    minus.PerformClick();
                    break;

                case Keys.Multiply:
                    e.Handled = true;
                    multiply.PerformClick();
                    break;

                case Keys.Back:
                    e.Handled = true;
                    back_spc.PerformClick();
                    break;

                case Keys.Enter:
                    e.Handled = true;
                    equal.PerformClick();
                    break;
            }


        }

    }
}
