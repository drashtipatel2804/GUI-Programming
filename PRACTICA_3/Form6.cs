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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = null;

            foreach (String i in checkedListBox1.CheckedItems)
            {
                value += i + " \n ";
            }
            label1.Text = value;
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
