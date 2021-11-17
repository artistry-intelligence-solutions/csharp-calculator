using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

// https://www.youtube.com/watch?v=ERZtoIEd5VU&ab_channel=ShaunHalverson

namespace Calculator
{
    public partial class Form1 : Form
    {
        string first = "";
        string second = "";
        string history = "";
        char function;
        double result = 0.0;
        string userInput = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "1";
            historyDisplay.Text = history + " " + userInput;
            calculatorDisplay.Text += userInput;
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "2";
            historyDisplay.Text = history + " " + userInput;
            calculatorDisplay.Text += userInput;
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "3";
            historyDisplay.Text = history + " " + userInput;
            calculatorDisplay.Text += userInput;
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "4";
            historyDisplay.Text = history + " " + userInput;
            calculatorDisplay.Text += userInput;
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "5";
            historyDisplay.Text = history + " " + userInput;
            calculatorDisplay.Text += userInput;
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "6";
            historyDisplay.Text = history + " " + userInput;
            calculatorDisplay.Text += userInput;
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "7";
            historyDisplay.Text = history + " " + userInput;
            calculatorDisplay.Text += userInput;
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "8";
            historyDisplay.Text = history + " " + userInput;
            calculatorDisplay.Text += userInput;
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "9";
            historyDisplay.Text = history + " " + userInput;
            calculatorDisplay.Text += userInput;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            first = "";
            history = "";
            second = "";
            history = "";
            userInput = "";
            result = 0.0;
            calculatorDisplay.Text = "0";
            historyDisplay.Text = history;
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            function = '/';
            first = userInput;
            history = userInput;
            history = history + " " + "÷" + " ";
            historyDisplay.Text = history;
            userInput = "";
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            function = '*';
            first = userInput;
            history = userInput;
            history = history + " " + "x" + " ";
            historyDisplay.Text = history;
            userInput = "";
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            function = '+';
            first = userInput;
            history = userInput;
            history = history + " " + "+" + " ";
            historyDisplay.Text = history;
            userInput = "";
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            function = '-';
            first = userInput;
            history = userInput;
            history = history + " " + "-" + " ";
            historyDisplay.Text = history;
            userInput = "";
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            second = userInput;
            historyDisplay.Text = historyDisplay.Text + " " + "=" + " ";
            double firstNum, secondNum;
            firstNum = Convert.ToDouble(first);
            secondNum = Convert.ToDouble(second);

            // Plus
            if (function == '+')
            {
                result = firstNum + secondNum;
                historyDisplay.Text = historyDisplay.Text + result.ToString();
                calculatorDisplay.Text = result.ToString();
            }
            // Minus
            else if (function == '-')
            {
                result = firstNum - secondNum;
                historyDisplay.Text = historyDisplay.Text + result.ToString();
                calculatorDisplay.Text = result.ToString();
            }
            // Divide
            else if (function == '/')
            {
                if (secondNum == '0')
                {
                    calculatorDisplay.Text = "impossible calculation";
                } else
                {
                    result = firstNum / secondNum;
                    historyDisplay.Text = historyDisplay.Text + result.ToString();
                    calculatorDisplay.Text = result.ToString();
                }
            }
            // Multiply
            else if (function == '*')
            {
                result = firstNum * secondNum;
                historyDisplay.Text = historyDisplay.Text + result.ToString();
                calculatorDisplay.Text = result.ToString();
            }
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += ".";
            historyDisplay.Text = history + " " + userInput;
            calculatorDisplay.Text += userInput;
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "0";
            historyDisplay.Text = history + " " + userInput;
            calculatorDisplay.Text += userInput;
        }

        private void FormBackground(object sender, PaintEventArgs e)
        {
            Graphics mgraphics = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(224, 77, 97), 1);

            Rectangle area = new Rectangle(0, 0, this.Width - 1, this.Height - 1);

            LinearGradientBrush lgb = new LinearGradientBrush(area, Color.FromArgb(103, 43, 100), Color.FromArgb(224, 77, 97), LinearGradientMode.ForwardDiagonal);
            mgraphics.FillRectangle(lgb, area);
            mgraphics.DrawRectangle(pen, area);
        }
    }
}
