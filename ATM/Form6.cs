using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Form6 : Form
    {
        public static double fivek;
        public static double tenk;
        public Form6()
        {
            InitializeComponent();
        }

        private void txtWithdraw_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn5000_Click(object sender, EventArgs e)
        {
            fivek += 5000;
            double total = fivek + tenk;
            txtWithdraw.Text = total.ToString();
        }

        private void btn10000_Click(object sender, EventArgs e)
        {
            tenk += 10000;
            double total = fivek + tenk;
            txtWithdraw.Text = total.ToString(); 
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtWithdraw.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtWithdraw.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtWithdraw.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtWithdraw.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtWithdraw.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtWithdraw.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtWithdraw.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtWithdraw.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtWithdraw.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
           if (txtWithdraw.Text == "0")
            {
                txtWithdraw.Text = "0";
            }
            else
            {
                txtWithdraw.Text += "0";
            }
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (txtWithdraw.Text.Length > 0)
            {
                txtWithdraw.Text = txtWithdraw.Text.Remove(txtWithdraw.Text.Length - 1, 1);
            }
        }
    }
}
