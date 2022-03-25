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

        Player players;
        bool wkey = false;
        bool akey = false;
        bool skey = false;
        bool dkey = false;
        Size screenSize;
        int speeds = 6;
        int sidey = 200;
        int sidex = 200;
        int sideHeight = 1;
        int sideWidth = 75;
        int sidey2 = 200;
        int sidex2 = 325;
        int sideHeight2 = 1;
        int sideWidth2 = 75;
        int sidey3 = 340;
        int sidex3 = 120;
        int sideHeight3 = 1;
        int sideWidth3 = 80;
        int sidey4 = 200;
        int sidex4 = 200;
        int sideHeight4 = 140;
        int sideWidth4 = 1;
        int sidey5 = 200;
        int sidex5 = 400;
        int sideHeight5 = 200;
        int sideWidth5 = 1;
        int sidey6 = 400;
        int sidex6 = 200;
        int sideHeight6 = 1;
        int sideWidth6 = 200;
        int sidey7 = 340;
        int sidex7 = 120;
        int sideHeight7 = 60;
        int sideWidth7 = 1;
        int sidey8 = 400;
        int sidex8 = 120;
        int sideHeight8 = 1;
        int sideWidth8 = 80;
        int ySpeed = 1;
        int xspeed = 1;
        int x;
        int y;
     int   size = 50;
        public gameScreen()
        {
            InitializeComponent();
            InitializeGame();
        }
        public void InitializeGame()
        {
            screenSize = new Size(this.Width, this.Height);

            int x = 142; ;
            int y = 354;


            players = new Player(x, y);
            

        }
    

        private void gameScreen_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Pink, 120, 340, 80, 60);
            e.Graphics.FillRectangle(Brushes.Blue, 200, 200, 200, 200);
            e.Graphics.FillRectangle(Brushes.Green, 275, 150, 50, 50);
            e.Graphics.FillRectangle(Brushes.Blue, sidex, sidey, sideWidth, sideHeight);
            e.Graphics.FillRectangle(Brushes.Blue, sidex2, sidey2, sideWidth2, sideHeight2);
            e.Graphics.FillRectangle(Brushes.Pink, sidex3, sidey3, sideWidth3, sideHeight3);
            e.Graphics.FillRectangle(Brushes.Blue, sidex4, sidey4, sideWidth4, sideHeight4);
            e.Graphics.FillRectangle(Brushes.Blue, sidex5, sidey5, sideWidth5, sideHeight5);
            e.Graphics.FillRectangle(Brushes.Blue, sidex6, sidey6, sideWidth6, sideHeight6);
            e.Graphics.FillRectangle(Brushes.Pink, sidex7, sidey7, sideWidth7, sideHeight7);
            e.Graphics.FillRectangle(Brushes.Pink, sidex8, sidey8, sideWidth8, sideHeight8);
            e.Graphics.FillRectangle(Brushes.Black, players.x, players.y, players.width,players.height);
        }

        private void gameTImer_Tick(object sender, EventArgs e)
        {
            if (akey == true && fortnite.Left > 0)
            {
                fortnite.Left -= speeds;
            }

            if (dkey == true && fortnite.Left < 600)
            {
                fortnite.Left += speeds;

            }

            if (skey == true&& fortnite.Top >0)
            {
                fortnite.Top += speeds;
            }

            if (wkey == true && fortnite.Top < 600)
            {
               fortnite.Top -= speeds;
            }

            if (akey == true)
            {
                players.Move("left", screenSize);
            }

            if (dkey == true)
            {
                players.Move("right", screenSize);
            }

            if (wkey == true)
            {
                players.Move("up", screenSize);
            }

            if (dkey == true)
            {
                players.Move("down", screenSize);
            }
           
            Refresh();

            Rectangle playerRec = new Rectangle  (x, y, sidex, sidey);
            Rectangle sideRec = new Rectangle(players.x, players.y, players.width, players.height);

            if (sideRec.IntersectsWith(playerRec))
            {
             

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
                case Keys.A:
                    akey = true;
                    break;
                case Keys.D:
                    dkey = true;
                    break;
            }

            if (e.KeyCode == Keys.Up)
            {
                wkey = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                akey = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                skey = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                dkey = true;
            }

        }

        private void gameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                wkey = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                akey = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                skey = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                dkey = false;
            }
            switch (e.KeyCode)
            {
                case Keys.W:
                    wkey = false;
                    break;
                case Keys.S:
                    skey = false;
                    break;
                case Keys.A:
                    akey = false;
                    break;
                case Keys.D:
                    dkey = false;
                    break;
            }
        }
    }
}
