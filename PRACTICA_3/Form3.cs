using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PRACTICA_3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Spin_Click(object sender, EventArgs e)
        {
            Random rmd = new Random();
            label1.Text = rmd.Next(10).ToString();
            label2.Text = rmd.Next(10).ToString();
            label3.Text = rmd.Next(10).ToString();



            if (label1.Text == "9" || label2.Text == "9" || label3.Text == "9")
            {
                pictureBox1.Visible = true;
                button1.Enabled = true;
                button1.Visible = true;
                MessageBox.Show("you won!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = " ";
            label2.Text = " ";
            label3.Text = " ";

            button1.Visible = false;
            pictureBox1.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //pictureBox1.Enabled = false;
        }

       
    }
}
