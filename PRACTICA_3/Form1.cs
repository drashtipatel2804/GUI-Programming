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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str, revs="";

            str = txtstring.Text;

            for (int i = str.Length - 1; i >= 0; i--) //String Reverse  
            {
                revs += str[i].ToString();
            }
            if (revs == str) // Checking whether string is palindrome or not  
            {
                MessageBox.Show("String is Palindrome. ");
            }
            else
            {
                MessageBox.Show("String is not Palindrome. ");
            }
            
        
        }
    }
}
