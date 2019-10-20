using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class1_Intro
{
    public partial class GetSeedForRand : Form
    {
        public int myVar;


        public GetSeedForRand()
        {
            InitializeComponent();
        }

        private void Gen_RandomText_Click(object sender, EventArgs e)
        {
            Random lol = new Random();
            numericUpSeed.Value = lol.Next(1, 999999);
        }

        private void Accept_B_Click(object sender, EventArgs e)
        {
            int seedFromUser = (int)numericUpSeed.Value;

            myVar = seedFromUser;   

        } 

        public void setMyvar(int number)
        {
            myVar = number;
        }
    }
}
