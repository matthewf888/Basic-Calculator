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
    public partial class Calculator : Form
    {
        Double value = 0;
        String operation = "";  //stores operations
        bool operation_pressed = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Clicked(object sender, EventArgs e)
        {
            // We don't want zeros appearing when we type
            if ((mainDisplay.Text == "0")||(operation_pressed))
            {
                mainDisplay.Clear();
            }

            // Displays text from label onto mainDisplay
            operation_pressed = false;
            Button b = (Button)sender;
            if (b.Text == ".")
            {
                if (!mainDisplay.Text.Contains("."))
                {
                    mainDisplay.Text = mainDisplay.Text + b.Text;
                }
            }
            else
            {
                mainDisplay.Text = mainDisplay.Text + b.Text;
            }
            invisibleFocusLabel.Focus();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {
                case "0":
                    zeroButton.PerformClick();
                    break;
                case "1":
                    oneButton.PerformClick();
                    break;
                case "2":
                    twoButton.PerformClick();
                    break;
                case "3":
                    threeButton.PerformClick();
                    break;
                case "4":
                    fourButton.PerformClick();
                    break;
                case "5":
                    fiveButton.PerformClick();
                    break;
                case "6":
                    sixButton.PerformClick();
                    break;
                case "7":
                    sevenButton.PerformClick();
                    break;
                case "8":
                    eightButton.PerformClick();
                    break;
                case "9":
                    nineButton.PerformClick();
                    break;
                case "+":
                    addButton.PerformClick();
                    break;
                case "-":
                    subtractButton.PerformClick();
                    break;
                case "*":
                   multButton.PerformClick();
                    break;
                case "/":
                    divideButton.PerformClick();
                    break;
                case "=":
                    equalsButton.PerformClick();
                    break;
                case " ":
                    equalsButton.PerformClick();
                    break;
                case "\r":
                    equalsButton.PerformClick();
                    break;
                case "\b":
                    // Used backspace method for delete key
                    backspace(sender, e);
                    break;
                default:
                    break;
            }
        }

        private void cButton_Click(object sender, EventArgs e)
        {
            mainDisplay.Text = "0";
            value = 0;
            equation.Text = "";
            invisibleFocusLabel.Focus();
        }

        private void ceButton_Click(object sender, EventArgs e)
        {
            mainDisplay.Text = "0";
            invisibleFocusLabel.Focus();
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (value != 0)
            {
                equalsButton.PerformClick();
                operation_pressed = true;
                operation = b.Text;
                equation.Text = value + " " + operation; 
            }
            else
            {
                operation = b.Text;
                value = Double.Parse(mainDisplay.Text);
                operation_pressed = true;
                equation.Text = value + " " + operation;
            }
            invisibleFocusLabel.Focus();
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            equation.Text = "";
            switch (operation)
            {
                case "+":
                    mainDisplay.Text = (value + Double.Parse(mainDisplay.Text)).ToString();
                    break;
                case "-":
                    mainDisplay.Text = (value - Double.Parse(mainDisplay.Text)).ToString();
                    break;
                case "*":
                    mainDisplay.Text = (value * Double.Parse(mainDisplay.Text)).ToString();
                    break;
                case "/":
                    mainDisplay.Text = (value / Double.Parse(mainDisplay.Text)).ToString();
                    break;
                default:
                    break;
            }
            value = Double.Parse(mainDisplay.Text);
            operation = "";
            invisibleFocusLabel.Focus();
        }

        private void backspace(object sender, EventArgs e)
        {
            if (mainDisplay.Text != "0")
            {
                mainDisplay.Text = mainDisplay.Text.Substring(0, (mainDisplay.Text.Length - 1));
                if(mainDisplay.Text == "")
                {
                    mainDisplay.Text = "0";
                }
            }
        }

        private void Negate_Number(object sender, EventArgs e)
        {
            if(mainDisplay.Text != "0")
            {
                if (!mainDisplay.Text.Contains("-"))
                {
                    mainDisplay.Text = "-" + mainDisplay.Text;
                }
                else if (mainDisplay.Text.Contains("-"))
                {
                    mainDisplay.Text = mainDisplay.Text.Remove(0, 1);
                }
            }
            invisibleFocusLabel.Focus();
        }
    }
}
