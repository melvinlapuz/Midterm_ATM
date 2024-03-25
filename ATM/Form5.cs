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
    public partial class Form5 : Form
    {
        public static double Balance = 100000;
        public Form5()
        {
            InitializeComponent();
            lbluser1.Text = Form3.user;              
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            lblbalance.Text = Balance.ToString();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            this.Hide();
            form.ShowDialog();
        }
    }
}
