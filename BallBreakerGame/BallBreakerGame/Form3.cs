using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace BallBreakerGame
{
    public partial class Form3 : Form
    {
        Settings settings = new Settings();

        //variables to set up speeds
        public int TopSpeed = 15;
        int BallSpeedTop = Options.BallSpeedTop;
        public int BallSpeedLeft = 20;

        //variables for playing area
        int PlayAreaTop = 27;  //maybe 27?
        int PlayAreaBottom = 488;
        int PlayAreaRight = 903;
        int PlayAreaLeft = 0;

        int Level3Score = 0;
        int OverallScore3 = 0;
        int lives3 = 5;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_KeyDown_1(object sender, KeyEventArgs e)
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
                timer3.Enabled = false;
            }
            if (e.KeyData == Keys.R)
            {
                timer3.Enabled = true;

                labelReady3.Visible = false;
            }
        }


        private void timer3_Tick_1(object sender, EventArgs e)
        {
            labelLevelScore.Text = Level3Score.ToString();
            labelOverallScore.Text = Options.OverallScore.ToString();


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
            bricksList.Add(pictureBoxBrick11);
            bricksList.Add(pictureBoxBrick12);
            bricksList.Add(pictureBoxBrick13);
            bricksList.Add(pictureBoxBrick14);
            bricksList.Add(pictureBoxBrick15);
            bricksList.Add(pictureBoxBrick16);
            bricksList.Add(pictureBoxBrick17);
            bricksList.Add(pictureBoxBrick18);

            List<PictureBox> bricksList1 = new List<PictureBox>();
            bricksList1.Add(pictureBoxBrick19);
            bricksList1.Add(pictureBoxBrick20);
            bricksList1.Add(pictureBoxBrick21);
            bricksList1.Add(pictureBoxBrick22);
            bricksList1.Add(pictureBoxBrick23);
            bricksList1.Add(pictureBoxBrick24);
            bricksList1.Add(pictureBoxBrick25);
            bricksList1.Add(pictureBoxBrick26);

            List<PictureBox> bricksRedList = new List<PictureBox>();

            bricksRedList.Add(pictureBoxBrickRed);
            bricksRedList.Add(pictureBoxBrickRed1);

            List<PictureBox> bricksGreenList = new List<PictureBox>();

            bricksGreenList.Add(pictureBoxBrickGreen);

            List<PictureBox> bricksDeathList = new List<PictureBox>();

            bricksDeathList.Add(pictureBoxBrickDeath);
            bricksDeathList.Add(pictureBoxBrickDeath1);
            bricksDeathList.Add(pictureBoxBrickDeath2);

            List<PictureBox> bricksBlockList = new List<PictureBox>();

            bricksBlockList.Add(pictureBoxBrickBlock);
            bricksBlockList.Add(pictureBoxBrickBlock1);


            //moving the ball
            pictureBoxBall.Top += BallSpeedTop;
            pictureBoxBall.Left += BallSpeedLeft;

            //if the ball collides with the top of the panel
            if (pictureBoxBall.Top < PlayAreaTop)
            {
                BallSpeedTop *= -1;  //times by -1 reverses the direction
            }

            //if ball goes below bottom of screen
            if (pictureBoxBall.Top > PlayAreaBottom)
            {
                pictureBoxBall.Top = 210;
                pictureBoxBall.Left = 417;

                lives3 = lives3 - 1;
                labelLives.Text = lives3.ToString();

                SoundPlayer deathSound = new SoundPlayer("Powerup2.wav");
                deathSound.Play();
            }

            if (pictureBoxBall.Left < PlayAreaLeft)
            {
                BallSpeedLeft *= -1;
            }

            if (pictureBoxBall.Left > PlayAreaRight)
            {
                BallSpeedLeft *= -1;
            }
            
            //using the collisions method
            //collision between ball and bat
            if (collide(pictureBoxBat, pictureBoxBall) == true)
            {
                BallSpeedTop *= -1;


                SoundPlayer batSound = new SoundPlayer("Blip_Select.wav");
                batSound.Play();

                pictureBoxBall.Top = pictureBoxBall.Top - 21;
            }

            foreach (PictureBox brick in bricksList)
            {
                //collision between ball and brick
                if (collide(pictureBoxBall, brick) == true)
                {
                    BallSpeedTop *= -1;
                    pictureBoxBall.Top = pictureBoxBall.Top + 30;

                    brick.Top = 1000;

                    Level3Score = Level3Score + 10;

                    Options.OverallScore = Options.OverallScore + 10;

                    SoundPlayer brickSound = new SoundPlayer("Jump.wav");
                    brickSound.Play();

                }
            }

            foreach (PictureBox brick in bricksList1)
            {
                if (collide(pictureBoxBall, brick) == true)
                {
                    BallSpeedTop *= -1;
                    pictureBoxBall.Top = pictureBoxBall.Top + 30;

                    brick.Top = 1000;

                    Level3Score = Level3Score + 10;

                    Options.OverallScore = Options.OverallScore + 10;

                    SoundPlayer brickSound = new SoundPlayer("Jump.wav");
                    brickSound.Play();

                }
            }

            //when player hits red brick, power down, decreases bat size
            foreach (PictureBox brick in bricksRedList)
            {
                //collision between brick and ball
                if (collide(pictureBoxBall, brick) == true)
                {
                    BallSpeedTop *= -1;
                    pictureBoxBall.Top = pictureBoxBall.Top + 30;

                    brick.Top = 1000;

                    Level3Score = Level3Score + 10;

                    Options.OverallScore = Options.OverallScore + 10;

                    //decreasing bat size
                    pictureBoxBat.Width = pictureBoxBat.Width / 2;

                    SoundPlayer batDownSound = new SoundPlayer("Powerup2.wav");
                    batDownSound.Play();

                }
            }

            //when player hits green brick, increases bat size
            foreach (PictureBox brick in bricksGreenList)
            {
                if (collide(pictureBoxBall, brick) == true)
                {
                    BallSpeedTop *= -1;
                    pictureBoxBall.Top = pictureBoxBall.Top + 30;

                    brick.Top = 1000;

                    Level3Score = Level3Score + 10;
                    Options.OverallScore = Options.OverallScore + 10;

                    //increasing bat size
                    pictureBoxBat.Width = pictureBoxBat.Width * 2;

                    SoundPlayer batUpSound = new SoundPlayer("Powerup.wav");
                    batUpSound.Play();
                }
            }

            //when player hits a death brick
            foreach (PictureBox brick in bricksDeathList)
            {
                if (collide(pictureBoxBall, brick) == true)
                {
                    BallSpeedTop *= -1;
                    //pictureBoxBall.Top = pictureBoxBall.Top + 30;

                    brick.Top = 1000;

                    //deducting life
                    lives3 = lives3 - 1;
                    labelLives.Text = lives3.ToString();

                    SoundPlayer deathSound = new SoundPlayer("Powerup2.wav");
                    deathSound.Play();
                }
            }

            //when player hits a block brick
            foreach (PictureBox brick in bricksBlockList)
            {
                if (collide(pictureBoxBall, brick) == true)
                {
                    BallSpeedTop *= -1;

                    SoundPlayer blockSound = new SoundPlayer("Blip_Select.wav");
                    blockSound.Play();
                }
            }


            if (lives3 == 0)
            {
                timer3.Enabled = false;

                GameOver GameOver = new GameOver();
                this.Close();
                GameOver.ShowDialog();
            }

            if (Level3Score == 300)
            {
                GameFinished GameFinished = new GameFinished();

                timer3.Enabled = false;

                this.Close();
                GameFinished.ShowDialog();
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


        private void quitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings Settings = new Settings();

            Options.OverallScore = 0;
            this.Close();
            Settings.ShowDialog();
        }
    }
}



        
    

