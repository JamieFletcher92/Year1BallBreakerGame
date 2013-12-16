using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BallBreakerGame
{
    public partial class Settings : Form
    {

        
        public Settings()
        {
            InitializeComponent();
        }

        public void trackBar1_Scroll(object sender, EventArgs e)
        {
            Options.BallSpeedTop = trackBarSpeed.Value;
            label1.Text = Options.BallSpeedTop.ToString();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {        
            if (levelSelect.Text == "Level 1")
            {
                Form1 Form1 = new Form1();
                this.Hide();
                Form1.Show();
            }
            else if (levelSelect.Text == "Level 2")
            {
                Form2 Form2 = new Form2();
                this.Hide();
                Form2.Show();
            }
            else if (levelSelect.Text == "Level 3")
            {
                Form3 Form3 = new Form3();
                this.Hide();
                Form3.Show();
            }
            else
            {
                MessageBox.Show("Please Select a Level!");
            }

        }
    }
}
