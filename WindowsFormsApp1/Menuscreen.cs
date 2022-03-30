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
    public partial class Menuscreen : UserControl
    {
        public Menuscreen()
        {
            InitializeComponent();
        }

       

        private void playbutton_Click(object sender, EventArgs e)
        {
            // when the play button is clicked go to the  game
            Form1.ChangeScreen(this, new gameScreen());
        }
        private void Exitbutton_Click(object sender, EventArgs e)
        {
            // when you click the exit button you will close the game
            Application.Exit();
        }
    }
}
