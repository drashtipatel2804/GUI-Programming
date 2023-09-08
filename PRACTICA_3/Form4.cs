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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txtnum.Text);

            int f1 = 1;
            int f2 = 1;
            int fn;

            listBox1.Items.Clear();
            do
            {
                listBox1.Items.Add(f1);
                fn = f1 + f2;
                f1 = f2;
                f2 = fn;
            } while (f1 <= n);
        }
    }
}
