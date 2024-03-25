using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to cancel?","Cancel", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Form1 form1 = new Form1();
                this.Hide();
                form1.ShowDialog();
            }
            
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtPin.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtPin.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtPin.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtPin.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtPin.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtPin.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtPin.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtPin.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtPin.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtPin.Text += "0";
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (txtPin.Text.Length > 0)
            {
                txtPin.Text = txtPin.Text.Remove(txtPin.Text.Length - 1, 1);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtPin.MaxLength = 4;
        }

        private void txtPin_TextChanged(object sender, EventArgs e)
        {
            if (txtPin.Text == "0000")
            {
                Form3 form3 = new Form3();
                this.Hide();
                form3.ShowDialog();
            }
            else
            {
                if (txtPin.Text.Length > 3)
                {
                    MessageBox.Show("Incorrect Password");
                    txtPin.Clear();

                }
            }
        }
    }
}
