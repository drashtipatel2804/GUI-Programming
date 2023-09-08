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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bsalary, gsalary, hra, dra, bonus;

            bsalary = Convert.ToInt32(txtsalary.Text);

            hra = (bsalary * 10) / 100;
            dra = (bsalary * 7) / 100;

            gsalary = bsalary + hra + dra;

            if (gsalary >= 40000)
            {
                bonus = (bsalary * 15) / 100;
                MessageBox.Show("Bonus = " + bonus);
            }
            else if (gsalary >= 50000)
            {
                bonus = (bsalary * 20) / 100;
                MessageBox.Show("Bonus = " + bonus);
            }
            else if (gsalary >= 60000)
            {
                bonus = (bsalary * 25) / 100;
                MessageBox.Show("Bonus = " + bonus);
            }
            else
                MessageBox.Show("NO BONUS");
        }
    }
}
