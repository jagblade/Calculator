using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class MainForm : Form
    {

        CalculatorOperations currentOperation = CalculatorOperations.None;
        bool shouldOverrideDigits = true;
        bool shouldOverrideDigitsCE = false;
        decimal previousNumber = 0;
        string decimalSeparator = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;

        public MainForm()
        {
            InitializeComponent();

            btnDigit0.Tag = 0;
            btnDigit1.Tag = 1;
            btnDigit2.Tag = 2;
            btnDigit3.Tag = 3;
            btnDigit4.Tag = 4;
            btnDigit5.Tag = 5;
            btnDigit6.Tag = 6;
            btnDigit7.Tag = 7;
            btnDigit8.Tag = 8;
            btnDigit9.Tag = 9;


            //ensure that the buttons cannot be focused so that pressing Enter on the keyboard won't press them
            btnDigit0.TabStop = false;
            btnDigit1.TabStop = false;
            btnDigit2.TabStop = false;
            btnDigit3.TabStop = false;
            btnDigit4.TabStop = false;
            btnDigit5.TabStop = false;
            btnDigit6.TabStop = false;
            btnDigit7.TabStop = false;
            btnDigit8.TabStop = false;
            btnDigit9.TabStop = false;
            btnDecimalSeparator.TabStop = false;
            btnPlus.TabStop = false;
            btnMinus.TabStop = false;
            btnMul.TabStop = false;
            btnDiv.TabStop = false;
            btnClear.TabStop = false;
            btnClear.TabStop = false;
            btnClearCurrent.TabStop = false;
            txtDigits.TabStop = false;
            //the = button will be focused
            btnCalculate.TabStop = true;

            btnDigit0.Click += InputDigit;
            btnDigit1.Click += InputDigit;
            btnDigit2.Click += InputDigit;
            btnDigit3.Click += InputDigit;
            btnDigit4.Click += InputDigit;
            btnDigit5.Click += InputDigit;
            btnDigit6.Click += InputDigit;
            btnDigit7.Click += InputDigit;
            btnDigit8.Click += InputDigit;
            btnDigit9.Click += InputDigit;

            btnDecimalSeparator.Text = decimalSeparator;
        }

        void InputDigit(object sender, EventArgs e)
        {
            int digit = (int)((Button)sender).Tag;
            AddInput(digit.ToString());

            //move the focus to the = button so if the user presses enter on the keyboard the right action will occur
            btnCalculate.Focus();
        }

        private void InputDecimalSeparator(object sender, EventArgs e)
        {
            AddDecimalSeparator();
            btnCalculate.Focus();
        }

        private void AddDecimalSeparator()
        {
            if (!txtDigits.Text.Contains(decimalSeparator))
            {
                AddInput(decimalSeparator);
            }
        }

        private void AddInput(string input)
        {
            if (shouldOverrideDigitsCE)
            {
                txtDigits.Text = input;
                shouldOverrideDigitsCE = false;
                shouldOverrideDigits = false;
            }
            else if (shouldOverrideDigits)
            {
                previousNumber = Decimal.Parse(txtDigits.Text);
                txtDigits.Text = input;
                shouldOverrideDigits = false;
            }
            else
            {
                txtDigits.Text += input;
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            InputOperation(CalculatorOperations.Addition);
            btnCalculate.Focus();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            InputOperation(CalculatorOperations.Subtraction);
            btnCalculate.Focus();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            InputOperation(CalculatorOperations.Multiplication);
            btnCalculate.Focus();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            InputOperation(CalculatorOperations.Division);
            btnCalculate.Focus();
        }

        private void InputOperation(CalculatorOperations operation)
        {
            try
            {
                if (!shouldOverrideDigits)
                {
                    Calculate();
                }

                currentOperation = operation;
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Cannot divide by zero");
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (shouldOverrideDigits)
                {
                    Calculate();
                }
                else
                {
                    decimal currentNumber = Decimal.Parse(txtDigits.Text);
                    Calculate();
                    previousNumber = currentNumber;
                }
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Cannot divide by zero");
            }
        }

        private decimal Calculate()
        {
            decimal currentNumber = Decimal.Parse(txtDigits.Text);
            decimal result;
            switch (currentOperation)
            {
                case CalculatorOperations.None:
                    {
                        result = currentNumber;
                    } break;
                case CalculatorOperations.Addition:
                    {
                        result = previousNumber + currentNumber;
                    } break;
                case CalculatorOperations.Subtraction:
                    {
                        result = previousNumber - currentNumber;
                    } break;
                case CalculatorOperations.Multiplication:
                    {
                        result = previousNumber * currentNumber;
                    } break;
                case CalculatorOperations.Division:
                    {
                        result = previousNumber / currentNumber;
                    } break;
                default:
                        throw new Exception("Unexpected operation type");
            }
            shouldOverrideDigits = true;
            txtDigits.Text = result.ToString();
            return result;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            btnCalculate.Focus();
        }

        private void Clear()
        {
            shouldOverrideDigits = true;
            shouldOverrideDigitsCE = false;
            previousNumber = 0;
            currentOperation = CalculatorOperations.None;
            txtDigits.Text = "0";
        }

        private void btnClearCurrent_Click(object sender, EventArgs e)
        {
            shouldOverrideDigitsCE = true;
            txtDigits.Text = "0";
            btnCalculate.Focus();
        }

        #region Keyboard Input

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            //this method intercepts key presses for digits so that the user
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                AddInput(e.KeyChar.ToString());
            }
            else if (e.KeyChar.ToString() == decimalSeparator)
            {
                AddDecimalSeparator();
            }
            else if (e.KeyChar == '+')
            {
                InputOperation(CalculatorOperations.Addition);
            }
            else if (e.KeyChar == '-')
            {
                InputOperation(CalculatorOperations.Subtraction);
            }
            else if (e.KeyChar == '*')
            {
                InputOperation(CalculatorOperations.Multiplication);
            }
            else if (e.KeyChar == '/')
            {
                InputOperation(CalculatorOperations.Division);
            }
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Clear();
                e.Handled = true;
            }
        }

        #endregion

    }
}
