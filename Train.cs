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
    public partial class Train : Form
    {
        int money;
        public Train()
        {
            
            InitializeComponent();
            money = Form1.money;
            XP = Form1.XP;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Train_Load(object sender, EventArgs e)
        {
            label5.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((money - 10)<= 0)
            {
                label5.Text = "You cannot afford the Sloth plan";
            }
            else
            {
                money -= 10;
                label5.Text = "You have bought the Sloth plan and earned 5XP";
                XP += 5;
            }
        }
    }
}
