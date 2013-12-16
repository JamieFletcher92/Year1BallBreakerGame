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
    public partial class GameFinished : Form
    {
        public GameFinished()
        {
            InitializeComponent();
        }

        private void GameComplete_Load(object sender, EventArgs e)
        {
            lblOverallScore.Text = Options.OverallScore.ToString();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            Settings Settings = new Settings();

            Options.OverallScore = 0;
            this.Close();
            Settings.ShowDialog();
        }
    }
}
