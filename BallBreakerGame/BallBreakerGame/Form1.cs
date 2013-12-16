using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;  //for the use of sounds within the game

namespace BallBreakerGame
{
    public partial class Form1 : Form
    {
        //to allow access to these forms
        Settings settings = new Settings();
        Form2 Form2 = new Form2();

        //variables to set up speeds
        public int TopSpeed = 15;  //for bat
        int BallSpeedTop = Options.BallSpeedTop;
        public int BallSpeedLeft = 20;

        //variables for playing area
        int PlayAreaTop = 27;
        int PlayAreaBottom = 488;
        int PlayAreaRight = 903;
        int PlayAreaLeft = 0;

        //score for this level
        int Level1Score = 0;

        //lives for this level, starts on 5, will decrease when life is lost
        int lives = 5;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //setting the movements of the bat for certain key presses
            if (e.KeyData == Keys.Left)
            {
                pictureBoxBat.Left -= TopSpeed;
            }
            if (e.KeyData == Keys.Right)
            {
                pictureBoxBat.Left += TopSpeed;
            }

            //options for the player
            if (e.KeyData == Keys.P)
            {
                timer1.Enabled = false;
            }
            if (e.KeyData == Keys.R)
            {
                timer1.Enabled = true;
                labelReady.Visible = false;
            }
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            //constantly updating the score when timer is enabled, and displaying them to the user
            labelLevelScore.Text = Level1Score.ToString();
            labelOverallScore.Text = Options.OverallScore.ToString();


            //setting up a list to hold the bricks in, so they can all be coded together
            List<PictureBox> bricksList = new List<PictureBox>();

            bricksList.Add(pictureBoxBrick);
            bricksList.Add(pictureBoxBrick1);
            bricksList.Add(pictureBoxBrick2);
            bricksList.Add(pictureBoxBrick3);
            bricksList.Add(pictureBoxBrick4);
            bricksList.Add(pictureBoxBrick5);
            bricksList.Add(pictureBoxBrick6);
            bricksList.Add(pictureBoxBrick7);
            bricksList.Add(pictureBoxBrick8);
            bricksList.Add(pictureBoxBrick9);
            bricksList.Add(pictureBoxBrick10);


            //moving the ball
            pictureBoxBall.Top += BallSpeedTop;
            pictureBoxBall.Left += BallSpeedLeft;

            //if the ball collides with the edges of the panel
            if (pictureBoxBall.Top < PlayAreaTop)
            {
                //times by -1 reverses the direction
                BallSpeedTop *= -1;
            }

            if (pictureBoxBall.Left < PlayAreaLeft)
            {
                BallSpeedLeft *= -1;
            }

            if (pictureBoxBall.Left > PlayAreaRight)
            {
                BallSpeedLeft *= -1;
            }

            //if the ball goes below the bat
            if (pictureBoxBall.Top > PlayAreaBottom)
            {
                //resetting ball to middle of play area
                pictureBoxBall.Top = 210;
                pictureBoxBall.Left = 417;

                //deducting live, and updating lives lable which displays lives to the user
                lives = lives - 1;
                labelLives.Text = lives.ToString();

                //playing the designated sound effect to the user when a life is lost
                SoundPlayer deathSound = new SoundPlayer("Powerup2.wav");
                deathSound.Play();
            }

            //using the collisions method
            //collision between ball and bat
            if (collide(pictureBoxBat, pictureBoxBall) == true)
            {
                SoundPlayer batSound = new SoundPlayer("Blip_Select.wav");
                batSound.Play();


                BallSpeedTop *= -1;

                //to stop the ball from glitching inside of the bat at high speeds
                pictureBoxBall.Top = pictureBoxBall.Top - 21;
            }

            foreach (PictureBox brick in bricksList)
            {
                //collision between ball and brick
                if (collide(pictureBoxBall, brick) == true)
                {
                    //deflecting the ball and making sure it doesnt get stuck inside the brick
                    BallSpeedTop *= -1;
                    pictureBoxBall.Top = pictureBoxBall.Top + 30;

                    brick.Top = 1000;

                    Level1Score = Level1Score + 10;

                    Options.OverallScore = Options.OverallScore + 10;

                    SoundPlayer brickSound = new SoundPlayer("Jump.wav");
                    brickSound.Play();
                }
            }

            if (lives == 0)
            {
                timer1.Enabled = false;

                GameOver GameOver = new GameOver();
                this.Close();
                GameOver.ShowDialog();
            }

            if (Level1Score == 110)
            {
                this.Close();
                Form2.Show();
            }
        }


        //this is the method for any collisions that occur
        private bool collide(PictureBox Object1, PictureBox Object2)
        {
            return !(Object1.Location.X > Object2.Location.X + Object2.Size.Width
                || Object1.Location.X + Object1.Size.Width < Object2.Location.X
                || Object1.Location.Y > Object2.Location.Y + Object2.Size.Height
                || Object1.Location.Y + Object1.Size.Height < Object2.Location.Y);
        }


        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings Settings = new Settings();

            //resetting the score, closing current form, opening Settings form, effectively restarting game.
            Options.OverallScore = 0;
            this.Close();
            Settings.ShowDialog();
        }
    }
}   

    

