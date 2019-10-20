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
    public partial class Settings : Form
    {
        public int interval;
        public int X;
        public int Y;
        public Color OneColor;
        public Color SecondColor;
        public Color OneMoreColor;
        public ColorDialog dlg = new ColorDialog();


        public Settings()
        {

            
            InitializeComponent(); 

           
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();

            dlg.Color = textBox1.BackColor;

            if (DialogResult.OK == dlg.ShowDialog())
            {
                textBox1.BackColor = dlg.Color;
                OneColor = dlg.Color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();

            dlg.Color = textBox2.BackColor;

            if (DialogResult.OK == dlg.ShowDialog())
            {
                textBox2.BackColor = dlg.Color;
                SecondColor = dlg.Color;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();

            dlg.Color = textBox3.BackColor;

            if (DialogResult.OK == dlg.ShowDialog())
            {
                textBox3.BackColor = dlg.Color;
                OneMoreColor = dlg.Color;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

           interval =  (int)Milli.Value;
            X = (int)UWidth1.Value;
            Y = (int)UHeight1.Value;
         
        }
    } 


    }

