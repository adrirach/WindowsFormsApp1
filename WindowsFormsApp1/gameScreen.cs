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
     
        int playerx = 142;
        int playery = 354;
   
        int playerspeedy = 5;
        int playerspeedx = 5;
        int playerWidth = 30;
        int playerHeight = 30;
        public gameScreen()
        {
            InitializeComponent();
           
        }
      

        private void gameScreen_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Pink, 120, 340, 80, 60);
            e.Graphics.FillRectangle(Brushes.Blue, 200, 200, 200, 200);
            e.Graphics.FillRectangle(Brushes.Green, 275, 150, 50, 50);
            e.Graphics.FillRectangle(Brushes.Red, sidex, sidey, sideWidth, sideHeight);
            e.Graphics.FillRectangle(Brushes.Blue, sidex2, sidey2, sideWidth2, sideHeight2);
            e.Graphics.FillRectangle(Brushes.Pink, sidex3, sidey3, sideWidth3, sideHeight3);
            e.Graphics.FillRectangle(Brushes.Blue, sidex4, sidey4, sideWidth4, sideHeight4);
            e.Graphics.FillRectangle(Brushes.Blue, sidex5, sidey5, sideWidth5, sideHeight5);
            e.Graphics.FillRectangle(Brushes.Blue, sidex6, sidey6, sideWidth6, sideHeight6);
            e.Graphics.FillRectangle(Brushes.Pink, sidex7, sidey7, sideWidth7, sideHeight7);
            e.Graphics.FillRectangle(Brushes.Pink, sidex8, sidey8, sideWidth8, sideHeight8);
            e.Graphics.FillRectangle(Brushes.Black, playerx, playery, playerWidth,playerHeight);
        }

        private void gameTImer_Tick(object sender, EventArgs e)
        {


            if (akey == true )
            {
                playerx -= playerspeedx;
            }

            if (dkey == true)
            {
                playerx += playerspeedx;

            }
                if (wkey == true)
                {
                    playery -= playerspeedy;
                }

                if (skey == true)
                {

                playery += playerspeedy;

            }

                Refresh();

                Rectangle playerRec = new Rectangle(playerx, playery, sidex, sidey);
            Rectangle sideRec = new Rectangle(playerx, playery, sidex, sidey);

            if (playerRec.IntersectsWith(sideRec))
            {
               
            }



        }
        

        private void gameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    akey = true;
                    break;
                case Keys.D:
                    dkey = true;
                    break;
                case Keys.W:
                    wkey = true;
                    break;
                case Keys.S:
                    skey = true;
                    break;
            }


        }

        private void gameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    akey = false;
                    break;
                case Keys.D:
                    dkey = false;
                    break;
                case Keys.W:
                    wkey = false;
                    break;
                case Keys.S:
                    skey = false;
                    break;
            }

        }
    }
}
