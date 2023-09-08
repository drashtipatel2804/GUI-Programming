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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (listBox1.SelectedIndex == 0)
                pictureBox1.Image = Image.FromFile("C:/Users/01/Desktop/Pictures/bicycle.jpg");
            if (listBox1.SelectedIndex == 1)
                pictureBox1.Image = Image.FromFile("C:/Users/01/Desktop/Pictures/motorbike.png");
            if (listBox1.SelectedIndex == 2)
                pictureBox1.Image = Image.FromFile("C:/Users/01/Desktop/Pictures/car.jpg");
            if (listBox1.SelectedIndex == 3)
                pictureBox1.Image = Image.FromFile("C:/Users/01/Desktop/Pictures/aeroplane.jpg");
            if (listBox1.SelectedIndex == 4)
                pictureBox1.Image = Image.FromFile("C:/Users/01/Desktop/Pictures/helicopter.png");
        }


    }
}
