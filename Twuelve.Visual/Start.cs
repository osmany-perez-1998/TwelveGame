using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Twuelve.Visual
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            GameStyle gs = new GameStyle();
            gs.Start = this;
            gs.Show();
            this.Hide();
        }

        private void Start_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\n The name of this game is Twuelve. \nThe basic principle of this game is to try and join the boxes that contain the same values. \n As you will realize, you cannot join any two boxes with the same value. \nThe game will verify whether there is an available path which will allow the boxes to be joined.\nAfter that the box you clicked last will have a value greater in 1.", "", MessageBoxButtons.OK);

        }

        private void btnLoadGame_Click(object sender, EventArgs e)
        {
            if(File.Exists("Board.dat") && File.Exists("Score.dat") && File.Exists("Agressive.dat"))
            {
                TwuelvePlay twuelve = new TwuelvePlay(8, 8, "Aggressive");
                
            }
        }

      
    }
}
