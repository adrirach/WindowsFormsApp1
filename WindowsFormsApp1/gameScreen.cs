using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class gameScreen : UserControl
    {

        
        bool wkey = false;
        bool akey = false;
        bool skey = false;
        bool dkey = false;
      
        int sidey = 200;
        int sidex = 200;
        int sideHeight = 1;
        int sideWidth = 100;
        int sidey2 = 200;
        int sidex2 = 350;
        int sideHeight2 = 1;
        int sideWidth2 = 100;
        int sidey3 = 390;
        int sidex3 = 120;
        int sideHeight3 = 1;
        int sideWidth3 = 80;
        int sidey4 = 200;
        int sidex4 = 200;
        int sideHeight4 = 190;
        int sideWidth4 = 1;
        int sidey5 = 200;
        int sidex5 = 450;
        int sideHeight5 = 250;
        int sideWidth5 = 1;
        int sidey6 = 450;
        int sidex6 = 200;
        int sideHeight6 = 1;
        int sideWidth6 = 250;
        int sidey7 = 390;
        int sidex7 = 120;
        int sideHeight7 = 60;
        int sideWidth7 = 1;
        int sidey8 = 450;
        int sidex8 = 120;
        int sideHeight8 = 1;
        int sideWidth8 = 80;
        int sidey9 = 200;
        int sidex9 = 220;
        int sideHeight9 = 250;
        int sideWidth9 = 1;
        int playerx = 142;
        int playery = 400;
   
        int playerspeedy = 4;
        int playerspeedx = 4;
        int playerWidth = 30;
        int playerHeight = 30;

        int ballspeed = 5;
        int ballsize = 20;
        int ballx = 410;
        int bally = 350;

        int ballx2 = 250;
        int bally2 = 390;
        int ballx3 = 410;
        int bally3 = 230;
        int ballx4 = 250;
        int bally4 = 270;
        int ballx5 = 410;
        int bally5 = 310;

        int goalsize = 10;
        int goalx = 320;
        int goaly = 180;

        public gameScreen()
        {
            InitializeComponent();
           
        }
      

   

        private void gameTImer_Tick(object sender, EventArgs e)
        {
           
            if (akey == true)
            {
                playerx -= playerspeedx;
            }

            if (dkey == true )
            {
              playerx += playerspeedx;
            }

            //move player 2 
            if (wkey == true )
            {
                playery -= playerspeedy;
            }

            if (skey == true )
            {
              playery+= playerspeedy;
            }

            ballx -= ballspeed;
            ballx2 += ballspeed;
            ballx3 -= ballspeed;
            ballx4 += ballspeed;
            ballx5 -= ballspeed;
            Refresh();

                Rectangle sideRec = new Rectangle(sidex, sidey, sideWidth, sideHeight);
            Rectangle sideRec2 = new Rectangle(sidex2, sidey2, sideWidth2, sideHeight2);
            Rectangle sideRec3 = new Rectangle(sidex3, sidey3, sideWidth3, sideHeight3);
            Rectangle sideRec4 = new Rectangle(sidex4, sidey4, sideWidth4, sideHeight4);
            Rectangle sideRec5 = new Rectangle(sidex5, sidey5, sideWidth5, sideHeight5);
            Rectangle sideRec6 = new Rectangle(sidex6, sidey6, sideWidth6, sideHeight6);
            Rectangle sideRec7 = new Rectangle(sidex7, sidey7, sideWidth7, sideHeight7);
            Rectangle sideRec8 = new Rectangle(sidex8, sidey8, sideWidth8, sideHeight8);
            Rectangle sideRec9 = new Rectangle(sidex9, sidey9, sideWidth9, sideHeight9);
            Rectangle playerRec = new Rectangle(playerx, playery, playerWidth, playerHeight);
            Rectangle ballRec = new Rectangle(ballx, bally, ballsize, ballsize);
            Rectangle ballRec2 = new Rectangle(ballx2, bally2, ballsize, ballsize);
            Rectangle ballRec3 = new Rectangle(ballx3, bally3, ballsize, ballsize);
            Rectangle ballRec4 = new Rectangle(ballx4, bally4, ballsize, ballsize);
            Rectangle ballRec5 = new Rectangle(ballx5, bally5, ballsize, ballsize);
            Rectangle goalRec = new Rectangle(goalx, goaly, goalsize, goalsize);
            if (playerRec.IntersectsWith(sideRec))
            {
               gameTImer.Enabled = false;
            }
            if (playerRec.IntersectsWith(sideRec2))
            {
                gameTImer.Enabled = false;
            }
            if (playerRec.IntersectsWith(sideRec3))
            {
                gameTImer.Enabled = false;
            }
            if (playerRec.IntersectsWith(sideRec4))
            {
                gameTImer.Enabled = false;
            }
            if (playerRec.IntersectsWith(sideRec5))
            {
                gameTImer.Enabled = false;
            }
            if (playerRec.IntersectsWith(sideRec6))
            {
                gameTImer.Enabled = false;
            }
            if (playerRec.IntersectsWith(sideRec7))
            {
                gameTImer.Enabled = false;
            }
            if (playerRec.IntersectsWith(sideRec8))
            {
                gameTImer.Enabled = false;
            }
            if (ballRec.IntersectsWith(sideRec5))
            {
                ballspeed *= -1;
            }
            if (ballRec.IntersectsWith(sideRec9))
            {
                ballspeed *= -1;
            }
            if (ballRec2.IntersectsWith(sideRec5))
            {
                ballspeed *= -1;
            }
            if (ballRec2.IntersectsWith(sideRec9))
            {
                ballspeed *= -1;
            }
            if (ballRec3.IntersectsWith(sideRec5))
            {
                ballspeed *= -1;
            }
            if (ballRec3.IntersectsWith(sideRec9))
            {
                ballspeed *= -1;
            }
            if (ballRec4.IntersectsWith(sideRec5))
            {
                ballspeed *= -1;
            }
            if (ballRec4.IntersectsWith(sideRec9))
            {
                ballspeed *= -1;
            }
            if (ballRec5.IntersectsWith(sideRec5))
            {
                ballspeed *= -1;
            }
            if (ballRec5.IntersectsWith(sideRec9))
            {
                ballspeed *= -1;
            }

            if (ballRec.IntersectsWith(playerRec))
            {
               gameTImer.Enabled = false;
                Form1.ChangeScreen(this, new gamoverscreen());
            }
            if (ballRec2.IntersectsWith(playerRec))
            {

                gameTImer.Enabled = false;
                Form1.ChangeScreen(this, new gamoverscreen());
            }
            if (ballRec3.IntersectsWith(playerRec))
            {
                gameTImer.Enabled = false;
                Form1.ChangeScreen(this, new gamoverscreen());
            }
            if (ballRec4.IntersectsWith(playerRec))
            {
                gameTImer.Enabled = false;
                Form1.ChangeScreen(this, new gamoverscreen());
            }
            if (ballRec5.IntersectsWith(playerRec))
            {
                gameTImer.Enabled = false;
                Form1.ChangeScreen(this, new gamoverscreen());
            }
            if (goalRec.IntersectsWith(playerRec))
            {
                gameTImer.Enabled = false;
                Form1.ChangeScreen(this, new Winscreen());

            }


        }


        private void gameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wkey = true;
                    break;
                case Keys.S:
                    skey = true;
                    break;
                case Keys.D:
                    dkey = true;
                    break;
                case Keys.A:
                    akey = true;
                    break;
            }

        }

        private void gameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wkey = false;
                    break;
                case Keys.S:
                    skey = false;
                    break;
                case Keys.D:
                    dkey = false;
                    break;
                case Keys.A:
                    akey = false;
                    break;
            }
        }
            private void gameScreen_Paint(object sender, PaintEventArgs e)
            {
                e.Graphics.FillRectangle(Brushes.Salmon, 120, 390, 80, 60);
           
            e.Graphics.FillRectangle(Brushes.LightBlue, 200, 200, 250, 250);
                e.Graphics.FillRectangle(Brushes.LightGreen, 300, 150, 50, 50);
            e.Graphics.FillRectangle(Brushes.Gold, goalx, goaly, goalsize, goalsize);
            e.Graphics.FillRectangle(Brushes.Red, sidex, sidey, sideWidth, sideHeight);
                e.Graphics.FillRectangle(Brushes.Red, sidex2, sidey2, sideWidth2, sideHeight2);
                e.Graphics.FillRectangle(Brushes.Red, sidex3, sidey3, sideWidth3, sideHeight3);
                e.Graphics.FillRectangle(Brushes.Red, sidex4, sidey4, sideWidth4, sideHeight4);
                e.Graphics.FillRectangle(Brushes.Red, sidex5, sidey5, sideWidth5, sideHeight5);
                e.Graphics.FillRectangle(Brushes.Red, sidex6, sidey6, sideWidth6, sideHeight6);
                e.Graphics.FillRectangle(Brushes.Red, sidex7, sidey7, sideWidth7, sideHeight7);
                e.Graphics.FillRectangle(Brushes.Red, sidex8, sidey8, sideWidth8, sideHeight8);
                e.Graphics.FillRectangle(Brushes.Black, playerx, playery, playerWidth, playerHeight);
            e.Graphics.FillRectangle(Brushes.Transparent, sidex9, sidey9, sideWidth9, sideHeight9);
            e.Graphics.FillRectangle(Brushes.Red, ballx, bally, ballsize, ballsize);
            e.Graphics.FillRectangle(Brushes.Red, ballx2, bally2, ballsize, ballsize);
            e.Graphics.FillRectangle(Brushes.Red, ballx3, bally3, ballsize, ballsize);
            e.Graphics.FillRectangle(Brushes.Red, ballx4, bally4, ballsize, ballsize);
            e.Graphics.FillRectangle(Brushes.Red, ballx5, bally5, ballsize, ballsize);
        }
    }
    }

