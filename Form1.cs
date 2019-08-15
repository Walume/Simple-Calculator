using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Calculator
{
    public partial class Form1 : Form
    {
       // public Form1()
        
            double FirstNumber;
            string Operation;
            public Form1()

            {

                InitializeComponent();
            }

    private void btn1_Click(object sender, EventArgs e)
    {
        if (txtInput.Text == "0" && txtInput.Text != null)
        {
            txtInput.Text = "1";
        }
        else
            { 
            txtInput.Text = txtInput.Text + "1";

    }

}

        private void btn2_Click(object sender, EventArgs e)
        {
            
                if (txtInput.Text == "0" && txtInput.Text != null)
                {
                    txtInput.Text = "2";
                }
                else
        { 
                    txtInput.Text = txtInput.Text + "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            
                if (txtInput.Text == "0" && txtInput.Text != null)
                {
                    txtInput.Text = "3";
                }
                else
    { 
                    txtInput.Text = txtInput.Text + "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            
                if (txtInput.Text == "0" && txtInput.Text != null)
                {
                    txtInput.Text = "4";
                }
                else
    { 
                    txtInput.Text = txtInput.Text + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            
                if (txtInput.Text == "0" && txtInput.Text != null)
                {
                    txtInput.Text = "5";
                }
                else
    { 
                    txtInput.Text = txtInput.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            
                if (txtInput.Text == "0" && txtInput.Text != null)
                {
                    txtInput.Text = "6";
                }
                else
    { 
                    txtInput.Text = txtInput.Text + "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            
                if (txtInput.Text == "0" && txtInput.Text != null)
                {
                    txtInput.Text = "7";
                }
                else
    { 
                    txtInput.Text = txtInput.Text + "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            
                if (txtInput.Text == "0" && txtInput.Text != null)
                {
                    txtInput.Text = "8";
                }
                else
    { 
                    txtInput.Text = txtInput.Text + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            {
                if (txtInput.Text == "0" && txtInput.Text != null)
                {
                    txtInput.Text = "9";
                }
                else
                    txtInput.Text = txtInput.Text + "9";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            
                    txtInput.Text = txtInput.Text + "0";
            }

        private void btnDot_Click(object sender, EventArgs e)
        {
            {
                if (txtInput.Text == "0" && txtInput.Text != null)
                {
                    txtInput.Text = ".";
                }
                else

                    txtInput.Text = txtInput.Text + ".";
            }

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtInput.Text);
            txtInput.Text = "0";
            Operation = "+";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtInput.Text);
            txtInput.Text = "0";
            Operation = "-";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtInput.Text);
            txtInput.Text = "0";
            Operation = "*";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtInput.Text);
            txtInput.Text = "0";
            Operation = "/";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Text = "0";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
        double SecondNumber;
        double Result;

        SecondNumber = Convert.ToDouble(txtInput.Text);

        if (Operation == "+")
        {
            Result = (FirstNumber + SecondNumber);
            txtInput.Text = Convert.ToString(Result);
            FirstNumber = Result;
        }
        if (Operation == "-")
        {
            Result = (FirstNumber - SecondNumber);
            txtInput.Text = Convert.ToString(Result);
            FirstNumber = Result;
        }
        if (Operation == "*")
        {
            Result = (FirstNumber * SecondNumber);
            txtInput.Text = Convert.ToString(Result);
            FirstNumber = Result;
        }
        if (Operation == "/")
        {
            if (SecondNumber == 0)
            {
                txtInput.Text = "Cannot divide by zero";

            }
            else
            {
                Result = (FirstNumber / SecondNumber);
                txtInput.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
        }
    }

    }  
}

