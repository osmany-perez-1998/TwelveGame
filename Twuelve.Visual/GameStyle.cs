using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Twuelve.Visual
{
  
    public partial class GameStyle : Form
    {
        public Start Start;
      
        public GameStyle()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (btnNormal.Checked)
            {
                if (btn5x4.Checked)
                {
                    TwuelvePlay twuelve = new TwuelvePlay(5, 4, "Normal");
                    twuelve.Show();

                }
                if (btn6x5.Checked)
                {
                    TwuelvePlay twuelve = new TwuelvePlay(6, 5, "Normal");
                    twuelve.Show();

                }
                if (btn7x6.Checked)
                {
                    TwuelvePlay twuelve = new TwuelvePlay(7, 6, "Normal");
                    twuelve.Show();
                }
                if (btn8x8.Checked)
                {
                    TwuelvePlay twuelve = new TwuelvePlay(8, 8, "Normal");
                    twuelve.Show();
                }
                if (btn9x9.Checked)
                {
                    TwuelvePlay twuelve = new TwuelvePlay(9, 9, "Normal");
                    twuelve.Show();
                }
                if (btn10x10.Checked)
                {
                    TwuelvePlay twuelve = new TwuelvePlay(10, 10, "Normal");
                    twuelve.Show();

                }
                if (btnPersonalize.Checked)
                {
                    TwuelvePlay twuelve = new TwuelvePlay((int)nupRow.Value, (int)nupColumn.Value, "Normal");
                    twuelve.Show();
                }
            }
            if (btnAggressive.Checked)
            {
                
                if (btn5x4.Checked)
                {
                    TwuelvePlay twuelve = new TwuelvePlay(5, 4, "Aggressive");
                    twuelve.Show();
                    
                }
                if (btn6x5.Checked)
                {
                    TwuelvePlay twuelve = new TwuelvePlay(6, 5, "Aggressive");
                    twuelve.Show();
                }
                if (btn7x6.Checked)
                {
                    TwuelvePlay twuelve = new TwuelvePlay(7, 6, "Aggressive");
                    twuelve.Show();
                }
                if (btn8x8.Checked)
                {
                    TwuelvePlay twuelve = new TwuelvePlay(8, 8, "Aggressive");
                    twuelve.Show();
                }
                if (btn9x9.Checked)
                {
                    TwuelvePlay twuelve = new TwuelvePlay(9, 9, "Aggressive");
                    twuelve.Show();
                }
                if (btn10x10.Checked)
                {
                    TwuelvePlay twuelve = new TwuelvePlay(10, 10, "Aggressive");
                    twuelve.Show();

                }
                if (btnPersonalize.Checked)
                {
                    TwuelvePlay twuelve = new TwuelvePlay((int)nupRow.Value, (int)nupColumn.Value, "Aggressive");
                    twuelve.Show();
                }
                
            }
            
            this.Hide();
        }

        private void GameStyle_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void bntBack_MouseClick(object sender, MouseEventArgs e)
        {
            Start.Show();
        }

        private void bntBack_Click(object sender, EventArgs e)
        {
            Start = new Start();
            Start.Show();
            Hide();
        }

        private void GameStyle_Load(object sender, EventArgs e)
        {

        }
    }
}
