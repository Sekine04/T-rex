using System;

using System.Windows.Forms;

namespace TrexGame
{
    public partial class Trex : Form
    {
        bool jumping = false;
        int jumpSpeed = 9;
        int force = 12;
        int score = 0;
        int obstacleSpeed = 10;
        System.Random rnd = new Random();
       // private bool isGameOver = false;

        
        public Trex()
        {
            InitializeComponent();
            ResetGame();
        }

        private void GameEvent(object sender, EventArgs e)
        {
            t_rex.Top += jumpSpeed;
            lbl_score.Text = "Score: " + score;

            if (jumping && force < 0)
            {
                jumping = false;
            }
              
            if (jumping)
            {
                jumpSpeed = -10;
                force -= 1;
            }
            else
            {
                jumpSpeed = 10;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")

                {
                    x.Left -= obstacleSpeed;

                    if (x.Left + x.Width < -120)
                    {
                        x.Left = this.ClientSize.Width + rnd.Next(200, 800);
                        score++;
                        if (score > 0)
                        {
                            this.BackColor = System.Drawing.Color.LightSteelBlue;
                        }

                        if (score > 3)
                        {
                            this.BackColor = System.Drawing.Color.Gray;
                        }

                        if (score > 5)
                        {
                            this.BackColor = System.Drawing.Color.MistyRose;
                        }

                        if (score > 7)
                        {
                            this.BackColor = System.Drawing.Color.LightSalmon;
                        }

                        if (score > 9)
                        {
                            this.BackColor = System.Drawing.Color.LightCoral;
                        }

                        if (score > 11)
                        {
                            this.BackColor = System.Drawing.Color.White;
                        }
                    }

                    if (t_rex.Bounds.IntersectsWith(x.Bounds))
                    {
                        gametimer.Stop();
                        t_rex.Image = Properties.Resources.dead;

                        lbl_score.Text += " Game Over! Press R to restart the game!";
                        
                    }
                }
            }

           if (t_rex.Top >= 380 && !jumping)
            {
                force = 12;
                t_rex.Top = floor.Top - t_rex.Height;
                jumpSpeed = 0;
            }
           
            if (score >= 7)
            {
                obstacleSpeed = 12;
            }
        }

        private void Keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && !jumping)
            {
                jumping = true;
            }
        }
        private void Keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R)
            {
                ResetGame();
            }

            if (jumping)
            {
                jumping = false;
            }
        }


        private void ResetGame()
        {
            force = 12;
            t_rex.Top = floor.Top - t_rex.Height;
            jumpSpeed = 0;
            jumping = false;
            score = 0;
            obstacleSpeed = 10;
            lbl_score.Text = "Score: " + score;

            t_rex.Image = Properties.Resources.running;
            
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    int position = rnd.Next(600, 1000);
                    x.Left = 640 + (x.Left + position + x.Width * 3);
                }
            }

            gametimer.Start();
        }


    }
}
