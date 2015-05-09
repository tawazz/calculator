using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calculator
{
    public partial class Calculator : Form
    {
        private double numHolder1;// holds first number
        private double numHolder2;// holds 2nd number
        private bool hasDecimal = false;  // checks for decimal
        private bool inputStatus = true;// checks for numbers in text box
        private string calFunc;// operater for + - * and /
        private bool noNonNums=false;//prevents non numbers from being entered

        public Calculator()
        {
            InitializeComponent();
            clear_Click(new object(), EventArgs.Empty);
            label1.Text = " " + numHolder1.ToString(); 
        }

        private void b0_Click(object sender, EventArgs e)
        {
            if (inputStatus)
            {
                if (input.Text.Length > 0)//prevents 0 from being first number
                {
                    input.Text += b0.Text;
                }
                else
                {
                    errorProvider1.SetError(input, "0 must not be first number");
                }
            }
        }

        private void b1_Click(object sender, EventArgs e)
        {
            if (inputStatus)
            {
                //when input status is true
                input.Text += b1.Text;
            }
            else
            {
                // if input status is false
                input.Text = b1.Text;
                // change input status to true
                inputStatus = true;
            }
        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (inputStatus)
            {
                //when input status is true
                input.Text += b2.Text;
            }
            else
            {
                // if input status is false
                input.Text = b2.Text;
                // change input status to true
                inputStatus = true;
            }
        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (inputStatus)
            {
                //when input status is true
                input.Text += b3.Text;
            }
            else
            {
                // if input status is false
                input.Text = b3.Text;
                // change input status to true
                inputStatus = true;
            }
        }

        private void b4_Click(object sender, EventArgs e)
        {
            if (inputStatus)
            {
                //when input status is true
                input.Text += b4.Text;
            }
            else
            {
                // if input status is false
                input.Text = b4.Text;
                // change input status to true
                inputStatus = true;
            }
        }

        private void b5_Click(object sender, EventArgs e)
        {
            if (inputStatus)
            {
                //when input status is true
                input.Text += b5.Text;
            }
            else
            {
                // if input status is false
                input.Text = b5.Text;
                // change input status to true
                inputStatus = true;
            }
        }

        private void b6_Click(object sender, EventArgs e)
        {
            if (inputStatus)
            {
                //when input status is true
                input.Text += b6.Text;
            }
            else
            {
                // if input status is false
                input.Text = b6.Text;
                // change input status to true
                inputStatus = true;
            }
        }

        private void b7_Click(object sender, EventArgs e)
        {
            if (inputStatus)
            {
                //when input status is true
                input.Text += b7.Text;
            }
            else
            {
                // if input status is false
                input.Text = b7.Text;
                // change input status to true
                inputStatus = true;
            }
        }

        private void b8_Click(object sender, EventArgs e)
        {
            if (inputStatus)
            {
                //when input status is true
                input.Text += b8.Text;
            }
            else
            {
                // if input status is false
                input.Text = b8.Text;
                // change input status to true
                inputStatus = true;
            }
        }

        private void b9_Click(object sender, EventArgs e)
        {
            if (inputStatus)
            {
                //when input status is true
                input.Text += b9.Text;
            }
            else
            {
                // if input status is false
                input.Text = b9.Text;
                // change input status to true
                inputStatus = true;
            }
        }

        private void comma_Click(object sender, EventArgs e)
        {
            if (inputStatus)
            {
                // when input status is true
                if (!hasDecimal)
                {
                    // check if there is a decimal or not
                    if (input.Text.Length != 0)
                    {
                        // check if there is more than one number
                        if (input.Text != "0")
                        {
                            // check is the first number is not 0
                            input.Text += comma.Text;
                            hasDecimal = true;
                        }
                    }
                    else
                    {
                        input.Text = "0.";
                        hasDecimal = true;
                    }
                }
            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            if (input.Text.Length != 0)
            {
                if (calFunc == String.Empty)
                {
                    try
                    {
                        numHolder1 = System.Double.Parse(input.Text);// strores num in variable
                    }
                    catch (FormatException exp) { MessageBox.Show("an error occured"+ exp); }
                    input.Text = String.Empty;// clears the input
                }
                else
                {
                    calTotals();
                    input.Text = String.Empty;// clears the input
                }
                calFunc = "add";
                hasDecimal = false;
            }
        }
        /**
         * function clears all variables values
         * */
        private void clear_Click(object sender, EventArgs e)
        {
            input.Text = string.Empty;
            numHolder1 = 0;
            numHolder2 = 0;
            calFunc = string.Empty;
            hasDecimal = false;
            label1.Text = string.Empty;
        }
        /**
         * function perfoms subtraction
         * */
        private void subtract_Click(object sender, EventArgs e)
        {
            if (input.Text.Length != 0)
            {
                if (calFunc == String.Empty)
                {
                    try
                    {
                        numHolder1 = System.Double.Parse(input.Text);// strores num in variable
                    }
                    catch (FormatException exp) { MessageBox.Show("an error occured "+ exp); }
                    input.Text = String.Empty;// clears the input
                }
                else
                {
                    calTotals();
                    input.Text = String.Empty;// clears the input
                }
                calFunc = "subtract";
                hasDecimal = false;
            }
        }
        /**
         * function perfoms multiplication
         * */
        private void multiply_Click(object sender, EventArgs e)
        {
            if (input.Text.Length != 0)
            {
                if (calFunc == String.Empty)
                {
                    try
                    {
                        numHolder1 = System.Double.Parse(input.Text);// strores num in variable
                    }
                    catch (FormatException exp) { MessageBox.Show("an error occured " + exp); }
                    input.Text = String.Empty;// clears the input

                }
                else
                {
                    calTotals();
                    input.Text = String.Empty;// clears the input
                }
                calFunc = "multiply";
                hasDecimal = false;
            }
        }
        /**
         * function perfoms divison
         * */
        private void devide_Click(object sender, EventArgs e)
        {
            if (input.Text.Length != 0)
            {
                if (calFunc == String.Empty)
                {
                    try
                    {
                        numHolder1 = System.Double.Parse(input.Text);// strores num in variable
                    }
                    catch (FormatException exp) { MessageBox.Show("an error occured " + exp); }
                    input.Text = String.Empty;// clears the input'
                }
                else
                {
                    calTotals();
                    input.Text = String.Empty;// clears the input
                }
                calFunc = "devide";
                hasDecimal = false;
            }
        }
        /**
         * function calculates the total based on the calculation functiom +- x /
         * */
        private void calTotals()
        {
            numHolder2 = System.Double.Parse(input.Text);
            switch (calFunc)
            {
                case "add":
                    numHolder1 = numHolder1 + numHolder2;
                    break;
                case "subtract":
                    numHolder1 = numHolder1 - numHolder2;
                    break;
                case "multiply":
                    numHolder1 = numHolder1 * numHolder2;
                    break;
                case "devide":
                    numHolder1 = numHolder1 / numHolder2;
                    break;

            }
            input.Text = numHolder1.ToString();
            inputStatus = true;
        }
        /**
         * function clears the text box
         * */
        private void ce_Click(object sender, EventArgs e)
        {
            input.Text = string.Empty;
            hasDecimal = false;
        }
        /**
         * function displays result of calculations
         * */
        private void bEquals_Click(object sender, EventArgs e)
        {
            if (input.Text.Length != 0)
            {
                
                    calTotals();
                    calFunc = string.Empty;
                    hasDecimal = false;
            }
        }
        /**
         * function to input negative numbers
         * */
        private void neg_Click(object sender, EventArgs e)
        {
            if (input.Text.Length != 0)
            {
                if (numHolder1 == 0)
                {
                    double temp = Convert.ToDouble(input.Text);
                    input.Text = (temp * -1).ToString();
                }
                else
                {
                    input.Text = (numHolder1 * -1).ToString();
                }

            }
            else
            {
                input.Text = "-" + input.Text;
            }
        }
        /**
         * function handle keyboard events.
         * function only allow numbers 0-9 and + - / * . esc to be entered and prevents characters from being entered
         * 
         * */
        private void input_KeyDown(object sender, KeyEventArgs e)
        {
            noNonNums = false;

            // prevents non 1-9 numbers from being entered
            if (e.KeyCode < Keys.D1 || e.KeyCode > Keys.D9)
            {
                if (e.KeyCode < Keys.NumPad1 || e.KeyCode > Keys.NumPad9)
                {
                    if (e.KeyCode != Keys.Back)
                    {
                        noNonNums = true;
                    }
                }
            }
            // prevents shift key button from being entered
            if (Control.ModifierKeys == Keys.Shift)
            {
                noNonNums = true;
            }
            // allows zero to be entered
            if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0)
            {
                b0_Click(new Object(),EventArgs.Empty);
            }
            // allow addition button to be entered NOTE you cant use shift + add button
            if (e.KeyCode == Keys.Add)
            {
                plus_Click(new object(),EventArgs.Empty);

            }
            // allow subtraction button to be entered NOTE you cant use shift + add subtract
            if (e.KeyCode == Keys.Subtract)
            {
                subtract_Click(new object(), EventArgs.Empty);

            }
            // allow multiplication button to be entered NOTE you cant use shift + *
            if (e.KeyCode == Keys.Multiply)
            {
                multiply_Click(new object(), EventArgs.Empty);

            }
            // allow division button to be entered
            if (e.KeyCode == Keys.Divide || e.KeyCode== Keys.OemBackslash)
            {
               devide_Click(new object(), EventArgs.Empty);

            }
            // uses enter key as equals button
            if (e.KeyCode == Keys.Enter)
            {
                bEquals_Click(new object(), EventArgs.Empty);

            }
            //enters decimal point
            if (e.KeyCode == Keys.Decimal)
            {
                comma_Click(new Object(),EventArgs.Empty);
            }

            // uses escape key to clear the textbox
            if (e.KeyCode == Keys.Escape)
            {
                clear_Click(new Object(), EventArgs.Empty);
            }
        }
        //function handles all nun numbers buttons
        private void input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (noNonNums == true)
            {
                e.Handled = true;
            }
        }

        private void input_TextChanged(object sender, EventArgs e)
        {
            label1.Text = numHolder1.ToString();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

    }
}
