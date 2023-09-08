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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rdbtnsquare.Checked == true)
            {
                int side = Convert.ToInt32(txtsquare.Text);
                int area = side * side;
                MessageBox.Show("area of square = "+area);
            }
            else if (rdbcircle.Checked == true)
            {
                int radius = Convert.ToInt32(txtcircle.Text);
                double area = 3.14 * radius * radius;
                MessageBox.Show("area of circle = " + area);
            }
            else if (rdbtriangle.Checked == true)
            {
                int b = Convert.ToInt32(txtbase.Text);
                int h = Convert.ToInt32(txtheight.Text);

                double area = b * h / 2; 
                MessageBox.Show("area of triangle = " + area);
            }
        }
        private void rdbtnsquare_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            txtsquare.Visible = true;
            label2.Visible = false;
            txtcircle.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            txtbase.Visible = false;
            txtheight.Visible = false;
        }

        private void rdbcircle_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = false;
            txtsquare.Visible = false;
            label2.Visible = true;
            txtcircle.Visible = true;
            label3.Visible = false;
            label4.Visible = false;
            txtbase.Visible = false;
            txtheight.Visible = false;
        }

        private void rdbtriangle_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = false;
            txtsquare.Visible = false;
            label2.Visible = false;
            txtcircle.Visible = false;
            label3.Visible = true;
            label4.Visible = true;
            txtbase.Visible = true;
            txtheight.Visible = true;
        }
    }
}
