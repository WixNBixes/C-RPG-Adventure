using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoresPrototype_v0._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label9.Text = money.ToString();
            label7.Text = XP.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if(comboBox1.Text is "Shop")
            {
                Shop f2 = new Shop();
                f2.Show();

            }else if(comboBox1.Text is "Fight")
            {
                Fight f3 = new Fight();
                f3.Show();
            } else if (comboBox1.Text is "Train")
            {
                Train f4 = new Train();
                f4.Show();
            } else if (comboBox1.Text is "Sleep")
            {
                Sleep f5 = new Sleep();
                f5.Show();
            }
            else
            {
            }
            

        }

        public static int money = 0;
        public static int XP = 0;

        private void label9_Click(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
