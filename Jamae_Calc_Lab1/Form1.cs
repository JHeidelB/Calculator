using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jamae_Calc_Lab1
{
    public partial class Form1 : Form
    {
        string userInput = string.Empty;
        string firstOperation = string.Empty;
        string secondOperation = string.Empty;
        char operationType;
        double results = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void zero_Click(object sender, EventArgs e)
        {
            inputandoutput.Text = string.Empty;
            userInput += "0";
            inputandoutput.Text = userInput;
        }

        private void one_Click(object sender, EventArgs e)
        {
            inputandoutput.Text = string.Empty;
            userInput += "1";
            inputandoutput.Text = userInput;
        }

        private void two_Click(object sender, EventArgs e)
        {
            inputandoutput.Text = string.Empty;
            userInput += "2";
            inputandoutput.Text = userInput;
        }

        private void three_Click(object sender, EventArgs e)
        {
            inputandoutput.Text = string.Empty;
            userInput += "3";
            inputandoutput.Text = userInput;
        }

        private void four_Click(object sender, EventArgs e)
        {
            inputandoutput.Text = string.Empty;
            userInput += "4";
            inputandoutput.Text = userInput;
        }

        private void five_Click(object sender, EventArgs e)
        {
            inputandoutput.Text = string.Empty;
            userInput += "5";
            inputandoutput.Text = userInput;
        }

        private void six_Click(object sender, EventArgs e)
        {
            inputandoutput.Text = string.Empty;
            userInput += "6";
            inputandoutput.Text = userInput;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            inputandoutput.Text = string.Empty;
            userInput += "7";
            inputandoutput.Text = userInput;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            inputandoutput.Text = string.Empty;
            userInput += "8";
            inputandoutput.Text = userInput;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            inputandoutput.Text = string.Empty;
            userInput += "9";
            inputandoutput.Text = userInput;
        }

        private void period_Click(object sender, EventArgs e)
        {
            inputandoutput.Text = string.Empty;
            userInput += ".";
            inputandoutput.Text = userInput;
        }

        private void addition_Click(object sender, EventArgs e)
        {
            firstOperation = userInput;
            userInput = string.Empty;
            operationType = '+';
        }

        private void subtract_Click(object sender, EventArgs e)
        {
            firstOperation = userInput;
            userInput = string.Empty;
            operationType = '-';
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            firstOperation = userInput;
            userInput = string.Empty;
            operationType = '*';
        }

        private void divide_Click(object sender, EventArgs e)
        {
            firstOperation = userInput;
            userInput = string.Empty;
            operationType = '/';
        }

        private void xpowery_Click(object sender, EventArgs e)
        {
            firstOperation = userInput;
            userInput = string.Empty;
            operationType = 'A';
        }

        private void clearentry_Click(object sender, EventArgs e)
        {
            userInput = string.Empty;
            inputandoutput.Text = "";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            userInput = string.Empty;
            firstOperation = string.Empty;
            secondOperation = string.Empty;
            inputandoutput.Text = string.Empty;
            results = 0.0;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (userInput.Length == 0)
            {
                
            }
            else
            {
                inputandoutput.Text = string.Empty;
                userInput = userInput.Remove(userInput.Length - 1, 1);
                inputandoutput.Text = userInput;
            }
        }

        private void Sqrt_Click(object sender, EventArgs e)
        {
            double numb;
            double.TryParse(userInput, out numb);
            inputandoutput.Text = string.Empty;
            numb = Math.Sqrt(numb);
            userInput = numb.ToString();
            inputandoutput.Text = userInput;
        }

        private void xsquared_Click(object sender, EventArgs e)
        {
            double numb;
            double.TryParse(userInput, out numb);
            inputandoutput.Text = string.Empty;
            numb = numb * numb;
            userInput = numb.ToString();
            inputandoutput.Text = userInput;
        }

        private void onedividedbyx_Click(object sender, EventArgs e)
        {
            double numb;
            double.TryParse(userInput, out numb);
            inputandoutput.Text = string.Empty;
            numb = 1 / numb;
            userInput = numb.ToString();
            inputandoutput.Text = userInput;
        }

        private void positiveornegative_Click(object sender, EventArgs e)
        {
            double numb;
            double.TryParse(userInput, out numb);
            inputandoutput.Text = string.Empty;
            numb = numb * -1;
            userInput = numb.ToString();
            inputandoutput.Text = userInput;
        }

        private void equals_Click(object sender, EventArgs e)
        {
            secondOperation = userInput;
            double numb;
            double numbnumb;
            double.TryParse(firstOperation, out numb);
            double.TryParse(secondOperation, out numbnumb);
            if (operationType == '+')
            {
                results = numb + numbnumb;
            }
            else if (operationType == '-')
            {
                results = numb - numbnumb;
            }
            else if (operationType == '*')
            {
                results = numb * numbnumb;
            }
            else if (operationType == '/')
            {
                if (numbnumb != 0)
                {
                    results = numb / numbnumb;
                }
                else
                {

                }
            }
            else if (operationType == 'A')
            {
                results = Math.Pow(numb, numbnumb);
            }
            inputandoutput.Text = results.ToString();
            userInput = results.ToString();
        }


    }
}
