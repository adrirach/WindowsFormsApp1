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
    public partial class gamoverscreen : UserControl
    {
        public gamoverscreen()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {

            // when you click the exit button you will close the game
            Application.Exit();
        }

        private void playagain_Click(object sender, EventArgs e)
        {
            // when you click play again you go to the game 
            Form1.ChangeScreen(this, new gameScreen());
            
        }
    }
}
