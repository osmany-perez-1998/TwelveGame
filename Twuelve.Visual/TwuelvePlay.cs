using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwuelveBehind;
using System.Threading;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Diagnostics;
namespace Twuelve.Visual
{
    public partial class TwuelvePlay : Form
    {
        GAME_ENGINE PlayBoard;
        int CellSize = 50;

        GameStyle GS = new GameStyle();

        bool adding = false;
        bool Clicked = false;
        Tuple<int, int> start;
        Tuple<int, int> end;

        int selectedCellRow, selectedCellCol;
        Pen linePen = new Pen(Color.DarkBlue, 3);
        Pen PathPen = new Pen(Color.White, 6);

        public void PaintPath(Graphics g)
        {
            int ColumnWidth = GameBoard.Width / PlayBoard.Board().width;
            int RowWidth = GameBoard.Height / PlayBoard.Board().heigth;

            if (adding && PlayBoard.PATHWAY().Count != 0)
            {

                 
                Tuple<int, int> First = PlayBoard.PATHWAY().ElementAt<Tuple<int, int>>(0);
                g.DrawRectangle(PathPen, First.Item2 * RowWidth + 2, First.Item1 * ColumnWidth + 2, CellSize - 2, CellSize - 2);


                for (int i = 1; i < PlayBoard.PATHWAY().Count - 1; i++)
                {
                    Tuple<int, int> Coordinates = PlayBoard.PATHWAY().ElementAt<Tuple<int, int>>(i);
                    g.DrawImage(ImLNumbers.Images[21], Coordinates.Item2 * RowWidth, Coordinates.Item1 * ColumnWidth, CellSize, CellSize);
                    Thread.Sleep((PlayBoard.Board().heigth + PlayBoard.Board().width) / (PlayBoard.PATHWAY().Count) * 20);
                }

                Tuple<int, int> Last = PlayBoard.PATHWAY().ElementAt<Tuple<int, int>>(PlayBoard.PATHWAY().Count - 1);
                g.DrawRectangle(PathPen, Last.Item2 * RowWidth + 2, Last.Item1 * ColumnWidth + 2, CellSize - 2, CellSize - 2);
                 
            }
        }

        public TwuelvePlay(int Rows, int Columns, string Modo)
        {
            InitializeComponent();

            PlayBoard = new GAME_ENGINE(Rows, Columns);
            if (Modo == "Normal") PlayBoard.Aggressive = false;
            else PlayBoard.Aggressive = true;

            if (PlayBoard.Aggressive && File.Exists("AGHighScore" + Rows + "X" + Columns + ".dat"))
                PlayBoard.LoadHighScore(Rows, Columns);

            if (!PlayBoard.Aggressive && File.Exists("NORHighScore" + Rows + "X" + Columns + ".dat"))
                PlayBoard.LoadHighScore(Rows, Columns);

            Refresh();

        }

        private void GameBoard_Paint(object sender, PaintEventArgs e)
        {

            int ColumnWidth = GameBoard.Width / PlayBoard.Board().width;
            int RowWidth = GameBoard.Height / PlayBoard.Board().heigth;

            this.Width = PlayBoard.Board().width * CellSize + 40;
            this.Height = PlayBoard.Board().heigth * CellSize + 150;

            GameBoard.Width = PlayBoard.Board().width * CellSize;
            GameBoard.Height = PlayBoard.Board().heigth * CellSize;




            for (int i = 0; i < PlayBoard.Board().heigth; i++)
                for (int j = 0; j < PlayBoard.Board().width; j++)
                {
                    e.Graphics.DrawImage(ImLNumbers.Images[PlayBoard.Board()[i, j].value], j * RowWidth, i * ColumnWidth, CellSize, CellSize);
                }
            if (Clicked)
                e.Graphics.DrawRectangle(linePen, selectedCellCol * 50 + 2, selectedCellRow * 50 + 2, 46, 46);



        }

        private void GameBoard_MouseClick(object sender, MouseEventArgs e)
        {

            {
                int column = e.X * PlayBoard.Board().width / GameBoard.Width;
                int row = e.Y * PlayBoard.Board().heigth / GameBoard.Height;


                if (!Clicked)
                {
                    start = new Tuple<int, int>(row, column);
                    selectedCellRow = row;
                    selectedCellCol = column;
                    Clicked = true;
                    adding = false;
                }
                else
                {
                    end = new Tuple<int, int>(row, column);
                    Clicked = false;
                    if (start != end)
                    { PlayBoard.Play(start.Item1, start.Item2, end.Item1, end.Item2); }
                    lbTellScore.Text = PlayBoard.SCORE().ToString();
                    adding = true;
                    PaintPath(GameBoard.CreateGraphics());
                }


                Thread.Sleep(50);

                adding = false;

                if (PlayBoard.LOST())
                {
                    MessageBox.Show("No le queda ningun movimiento valido por realizar, HA PERDIDO.");

                }
                Refresh();
            }
        }

        private void btnBack_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult a = MessageBox.Show("Are You Sure?", "Back", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (a == DialogResult.Yes)
                this.Close();

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void howToPlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\n The name of this game is Twuelve. \nThe basic principle of this game is to try and join the boxes that contain the same values. \n As you will realize, you cannot join any two boxes with the same value. \nThe game will verify whether there is an available path which will allow the boxes to be joined.\nAfter that, the box you clicked last will have a value greater in 1.", "", MessageBoxButtons.OK);
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version 1.0.0.0.\n Copyright 2017 OPR Corporation.\n All rights reserved.", "Twuelve", MessageBoxButtons.OK);
        }


        private void TwuelvePlay_Paint(object sender, PaintEventArgs e)
        {
            if (PlayBoard.Aggressive)
            {
                lbMode1.Text = "Aggressive";
                lbHScore.Text = PlayBoard.HIGHSCOREAG().ToString();
            }
            if (!PlayBoard.Aggressive)
            {
                lbMode1.Text = "Normal";
                lbHScore.Text = PlayBoard.HIGHSCORENOR().ToString();
            }

            this.Width = PlayBoard.Board().width * CellSize + 40;
            this.Height = PlayBoard.Board().heigth * CellSize + 150;

            GameBoard.Width = PlayBoard.Board().width * CellSize;
            GameBoard.Height = PlayBoard.Board().heigth * CellSize;
        }

        private void TwuelvePlay_FormClosed(object sender, FormClosedEventArgs e)
        {

            GS = new GameStyle();
            GS.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NOR5X4Load_Click(object sender, EventArgs e)
        {
            PlayBoard.Aggressive = false;
            if (File.Exists("NORBoard5X4.dat") && File.Exists("NORScore5X4.dat") && File.Exists("Normal5X4.dat"))

            {
                Clicked = false;
                PlayBoard.LoadGame(5, 4);
                PlayBoard.LoadHighScore(5, 4);
                lbHScore.Refresh();
                Refresh();
            }
            else
                MessageBox.Show("", "There is no game saved, you need to start a new game.", MessageBoxButtons.OK);
        }

        private void NOR6X5Load_Click(object sender, EventArgs e)
        {
            PlayBoard.Aggressive = false;
            if (File.Exists("NORBoard6X5.dat") && File.Exists("NORScore6X5.dat") && File.Exists("Normal6X5.dat"))

            {
                Clicked = false;
                PlayBoard.LoadGame(6, 5);
                PlayBoard.LoadHighScore(6, 5);
                lbHScore.Refresh();

                Refresh();
            }
            else
                MessageBox.Show("", "There is no game saved, you need to start a new game.", MessageBoxButtons.OK);
        }

        private void NOR7X6Load_Click(object sender, EventArgs e)
        {
            PlayBoard.Aggressive = false;
            if (File.Exists("NORBoard7X6.dat") && File.Exists("NORScore7X6.dat") && File.Exists("Normal7X6.dat"))

            {
                Clicked = false;
                PlayBoard.LoadGame(7, 6);
                PlayBoard.LoadHighScore(7, 6);
                lbHScore.Refresh();

                Refresh();
            }
            else
                MessageBox.Show("", "There is no game saved, you need to start a new game.", MessageBoxButtons.OK);
        }

        private void NOR8X8Load_Click(object sender, EventArgs e)
        {
            PlayBoard.Aggressive = false;
            if (File.Exists("NORBoard8X8.dat") && File.Exists("NORScore8X8.dat") && File.Exists("Normal8X8.dat"))

            {
                Clicked = false;
                PlayBoard.LoadGame(8, 8);
                PlayBoard.LoadHighScore(8, 8);
                lbHScore.Refresh();
                Refresh();
            }
            else
                MessageBox.Show("", "There is no game saved, you need to start a new game.", MessageBoxButtons.OK);
        }

        private void NOR9X9Load_Click(object sender, EventArgs e)
        {
            PlayBoard.Aggressive = false;
            if (File.Exists("NORBoard9X9.dat") && File.Exists("NORScore9X9.dat") && File.Exists("Normal9X9.dat"))

            {
                Clicked = false;
                PlayBoard.LoadGame(9, 9);
                PlayBoard.LoadHighScore(9, 9);
                lbHScore.Refresh();

                Refresh();
            }
            else
                MessageBox.Show("", "There is no game saved, you need to start a new game.", MessageBoxButtons.OK);
        }

        private void NOR10X10Load_Click(object sender, EventArgs e)
        {
            PlayBoard.Aggressive = false;
            if (File.Exists("NORBoard10X10.dat") && File.Exists("NORScore10X10.dat") && File.Exists("Normal10X10.dat"))

            {
                Clicked = false;
                PlayBoard.LoadGame(10, 10);
                PlayBoard.LoadHighScore(10, 10);
                lbHScore.Refresh();
                Refresh();
            }
            else
                MessageBox.Show("", "There is no game saved, you need to start a new game.", MessageBoxButtons.OK);
        }

        private void AG5X4Load_Click(object sender, EventArgs e)
        {
            PlayBoard.Aggressive = true;
            if (File.Exists("AGBoard5X4.dat") && File.Exists("AGScore5X4.dat") && File.Exists("Aggressive5X4.dat"))

            {
                Clicked = false;
                PlayBoard.LoadGame(5, 4);
                //PlayBoard.LoadHighScore(5,4);
                //lbHScore.Refresh();

                Refresh();
            }
            else
                MessageBox.Show("", "There is no game saved, you need to start a new game.", MessageBoxButtons.OK);

        }

        private void AG6X5Load_Click(object sender, EventArgs e)
        {
            PlayBoard.Aggressive = true;
            if (File.Exists("AGBoard6X5.dat") && File.Exists("AGScore6X5.dat") && File.Exists("Aggressive6X5.dat"))

            {
                Clicked = false;
                PlayBoard.LoadGame(6, 5);
                //PlayBoard.LoadHighScore(6, 5);
                //lbHScore.Refresh();
                Refresh();
            }
            else
                MessageBox.Show("", "There is no game saved, you need to start a new game.", MessageBoxButtons.OK);
        }

        private void AG7X6Load_Click(object sender, EventArgs e)
        {
            PlayBoard.Aggressive = true;
            if (File.Exists("AGBoard7X6.dat") && File.Exists("AGScore7X6.dat") && File.Exists("Aggressive7X6.dat"))

            {
                Clicked = false;
                PlayBoard.LoadGame(7, 6);
                //PlayBoard.LoadHighScore(7, 6);
                //lbHScore.Refresh();
                Refresh();
            }
            else
                MessageBox.Show("", "There is no game saved, you need to start a new game.", MessageBoxButtons.OK);
        }

        private void AG8X8Load_Click(object sender, EventArgs e)
        {
            PlayBoard.Aggressive = true;
            if (File.Exists("AGBoard8X8.dat") && File.Exists("AGScore8X8.dat") && File.Exists("Aggressive8X8.dat"))

            {
                Clicked = false;
                PlayBoard.LoadGame(8, 8);
                //PlayBoard.LoadHighScore(8, 8);
                //lbHScore.Refresh();
                Refresh();
            }
            else
                MessageBox.Show("", "There is no game saved, you need to start a new game.", MessageBoxButtons.OK);
        }

        private void AG9X9Load_Click(object sender, EventArgs e)
        {
            PlayBoard.Aggressive = true;
            if (File.Exists("AGBoard9X9.dat") && File.Exists("AGScore9X9.dat") && File.Exists("Aggressive9X9.dat"))

            {
                Clicked = false;
                PlayBoard.LoadGame(9, 9);
                PlayBoard.LoadHighScore(9, 9);
                lbHScore.Refresh();

                Refresh();
            }
            else
                MessageBox.Show("", "There is no game saved, you need to start a new game.", MessageBoxButtons.OK);
        }

        private void AG10X10Load_Click(object sender, EventArgs e)
        {
            PlayBoard.Aggressive = true;
            if (File.Exists("AGBoard10X10.dat") && File.Exists("AGScore10X10.dat") && File.Exists("Aggressive10X10.dat"))

            {
                Clicked = false;
                PlayBoard.LoadGame(10, 10);
                PlayBoard.LoadHighScore(10, 10);
                lbHScore.Refresh();
                Refresh();
            }
            else
                MessageBox.Show("", "There is no game saved, you need to start a new game.", MessageBoxButtons.OK);
        }


        private void TwuelvePlay_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult Save = MessageBox.Show("Do you want to save your current game, before you exit?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Save == DialogResult.Yes)
            {
                PlayBoard.SaveGame(PlayBoard.Board().heigth, PlayBoard.Board().width);
            }
        }

    }
}
