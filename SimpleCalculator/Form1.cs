using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class frmCalculator : Form
    {
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        string result;
        char operation;

        public frmCalculator()
        {
            InitializeComponent();
        }

        private CalculatorReference.CalculatorSoapClient calcRef;


        private void frmCalculator_Load(object sender, EventArgs e)
        {
            calcRef = new CalculatorReference.CalculatorSoapClient();
            btnOne.Click += new EventHandler(btn_Click);
            btnTwo.Click += new EventHandler(btn_Click);
            btnThree.Click += new EventHandler(btn_Click);
            btnFour.Click += new EventHandler(btn_Click);
            btnFive.Click += new EventHandler(btn_Click);
            btnSix.Click += new EventHandler(btn_Click);
            btnSeven.Click += new EventHandler(btn_Click);
            btnEight.Click += new EventHandler(btn_Click);
            btnNine.Click += new EventHandler(btn_Click);
            btnZero.Click += new EventHandler(btn_Click);
            btnDot.Click += new EventHandler(btn_Click);
        }

        void btn_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = sender as Button;

                switch (btn.Name)
                {
                    case "btnOne":
                    case "btnTwo":
                    case "btnThree":
                    case "btnFour":
                    case "btnFive":
                    case "btnSix":
                    case "btnSeven":                        
                    case "btnEight":                    
                    case "btnNine":                       
                    case "btnZero":
                        txtInput.Text += btn.Text ;
                        break;
                    case "btnDot":
                        if (!txtInput.Text.Contains("."))
                            txtInput.Text += btn.Text;
                        break;

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Sorry for the inconvenience, Unexpected error occured. Details: " +
                    ex.Message);
            }
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0':
                //case '+':
                //case '-':
                //case '*':
                //case '/':
                //case '.':
                    break;
                default:
                    e.Handled = true;
                    MessageBox.Show("Only numbers, +, -, ., *, / are allowed");
                    break;
            }           
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            operand1 = txtInput.Text;
            operation = '+';
            txtInput.Text = string.Empty;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            operand1 = txtInput.Text;
            operation = '-';
            txtInput.Text = string.Empty;
        }

        private void btnMulitply_Click(object sender, EventArgs e)
        {
            operand1 = txtInput.Text;
            operation = '*';
            txtInput.Text = string.Empty;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            operand1 = txtInput.Text;
            operation = '/';
            txtInput.Text = string.Empty;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            operand2 = txtInput.Text;

            double opr1, opr2;
            double.TryParse(operand1, out opr1);
            double.TryParse(operand2, out opr2);

            switch (operation)
            {
                case '+':
                    result = Convert.ToString(calcRef.Add(opr1, opr2));
                    break;

                case '-':
                    result = Convert.ToString(calcRef.Subtract(opr1, opr2));
                    break;

                case '*':
                    result = Convert.ToString(calcRef.Multiply(opr1, opr2)); break;

                case '/':
                    if (opr2 != 0)
                    {
                        result = Convert.ToString(calcRef.Divide(opr1, opr2));
                    }
                    else
                    {
                        MessageBox.Show("Can't divide by zero");
                    }
                    break;
            }

            txtInput.Text = result.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Text = string.Empty;
            operand1 = string.Empty;
            operand2 = string.Empty;
        }

        private void btnSqrRoot_Click(object sender, EventArgs e)
        {
            double opr1;
            if (double.TryParse(txtInput.Text, out opr1))
            {
                txtInput.Text = (Math.Sqrt(opr1)).ToString();
            }
        }

        private void btnByTwo_Click(object sender, EventArgs e)
        {
            double opr1;
            if (double.TryParse(txtInput.Text, out opr1))
            {
                txtInput.Text = (opr1 / 2).ToString();
            }
        }

        private void btnByFour_Click(object sender, EventArgs e)
        {
            double opr1;
            if (double.TryParse(txtInput.Text, out opr1))
            {
                txtInput.Text = (opr1 / 4).ToString();
            }
        }

        private void btnThree_Click(object sender, EventArgs e)
        {

        }


        
            
        
    }
}
