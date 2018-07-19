using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace TwuelveBehind
{
    [Serializable]
   public class GAME_ENGINE
    {
        #region OBJECTS
        BOARD Tablero;
        int score;
        int highscoreAG;
        int highscoreNOR;

        public bool Aggressive;
        int[] D_Rows = new int[] { 1, 0, -1, 0 };
        int[] D_Columns = new int[] { 0, 1, 0, -1 };

        List<Tuple<int, int>> Desoccupied = new List<Tuple<int, int>>();
        List<Tuple<int, int>> Occupied = new List<Tuple<int, int>>();

        Stack<Tuple<int, int>> PathWay;
        static Random r = new Random();
        int Moves = 0;
        #endregion
     

        #region Public Methods
        public BOARD Board()
        {
            return Tablero;
        }
        public bool AGGRESSIVE()
        {
            return Aggressive;
        }
        public int SCORE()//this is so it can be used in the visual,score at the moment for a given board size
        {
            return score;
        }
        public int HIGHSCOREAG()//this is so it can be used in the visual, highscore aggressive for a given board size
        {
            return highscoreAG;
        }
        public int HIGHSCORENOR()//this is so it can be used in the visual,highscore normal for a given board size
        {
            return highscoreNOR;
        }
              
        public GAME_ENGINE(int Height, int Width) //Creates the board and generates CASILLAS depending on the board's size
        {
            Tablero = new BOARD(Height, Width);
            GenerateBox((int)Math.Sqrt(Tablero.width + Tablero.heigth));

        }
        public bool LOST() //Checks whether the game is over or not.
        {
            return Lost();
        }
        public void ADBOXES(int y, int x, int y1, int x1) // Adds the boxes.
        {
            AdBoxes(y, x, y1, x1);
        }
        public Stack<Tuple<int, int>> PATHWAY() //Path that the box will follow when adding.
        {
           return PathWay;
        }
        public void Play(int RowI, int ColumnI,int RowF,  int ColumnF) // This is the method that plays, either adds the boxes or it doesn't.
        {
            if (!LOST())
            {
                 PathWay = FindPath(RowI, ColumnI, RowF, ColumnF);
                if (PathWay.Count != 0)
                    ADBOXES(RowI, ColumnI, RowF, ColumnF);
            }

        }
        void SaveHighScore(int Rows, int Columns)
        {
            BinaryFormatter bf = new BinaryFormatter();
            if (Aggressive)
            {
                FileStream fhighscoreAG = new FileStream("AGHighScore" + Rows + "X" + Columns + ".dat"/*nombre del archivo que vas a crear*/, FileMode.Create/*si vas a crear o a abrir*/, FileAccess.Write/*si vas a leer o a escribir*/);
                bf.Serialize(fhighscoreAG, highscoreAG);
                fhighscoreAG.Dispose();
            }
            if (!Aggressive)
            {
                FileStream fhighscoreNOR = new FileStream("NORHighScore" + Rows + "X" + Columns + ".dat"/*nombre del archivo que vas a crear*/, FileMode.Create/*si vas a crear o a abrir*/, FileAccess.Write/*si vas a leer o a escribir*/);
                bf.Serialize(fhighscoreNOR, highscoreNOR);
                fhighscoreNOR.Dispose();
            }
        }
        public void LoadHighScore(int Rows, int Columns)
        {
            BinaryFormatter bf = new BinaryFormatter();
            if (Aggressive)
            {
                FileStream fhighscoreAG = new FileStream("AGHighScore" + Rows + "X" + Columns + ".dat", FileMode.Open, FileAccess.Read);
                highscoreAG = (int)bf.Deserialize(fhighscoreAG);
                fhighscoreAG.Dispose();
                
            }
            if(!Aggressive)
            {
                FileStream fhighscoreNOR = new FileStream("NORHighScore" + Rows + "X" + Columns + ".dat", FileMode.Open, FileAccess.Read);
                highscoreNOR = (int)bf.Deserialize(fhighscoreNOR);
                fhighscoreNOR.Dispose();
            }

            
           
     

        }
        public void SaveGame(int Rows, int Columns)
        {
            BinaryFormatter bf = new BinaryFormatter();
            if (Aggressive)
            {
                FileStream fboard = new FileStream("AGBoard" + Rows + "X" + Columns + ".dat"/*Name of the file that will be created*/, FileMode.Create/*Whether creating or opening*/, FileAccess.Write/*if you are going to read or write*/);
                FileStream fscore = new FileStream("AGScore" + Rows + "X" + Columns + ".dat"/*Name of the file that will be created*/, FileMode.Create/*whether creating or opening*/, FileAccess.Write/*if you are going to read or write*/);
                FileStream faggressive = new FileStream("Aggressive" + Rows + "X" + Columns + ".dat"/*Name of the file that will be created*/, FileMode.Create/*whether creating or opening*/, FileAccess.Write/*if you are going to read or write*/);

                bf.Serialize(fboard, Tablero);
                bf.Serialize(fscore, score);
                bf.Serialize(faggressive, Aggressive);
                fboard.Dispose();
                fscore.Dispose();
                faggressive.Dispose();
            }
            if(!Aggressive)
            {
                FileStream fboard = new FileStream("NORBoard" + Rows + "X" + Columns + ".dat"/*Name of the file that will be created*/, FileMode.Create/*Whether creating or opening*/, FileAccess.Write/*if you are going to read or write*/);
                FileStream fscore = new FileStream("NORScore" + Rows + "X" + Columns + ".dat"/*Name of the file that will be created*/, FileMode.Create/*whether creating or opening*/, FileAccess.Write/*if you are going to read or write*/);
                FileStream faggressive = new FileStream("Normal" + Rows + "X" + Columns + ".dat"/*Name of the file that will be created*/, FileMode.Create/*whether creating or opening*/, FileAccess.Write/*if you are going to read or write*/);

                bf.Serialize(fboard, Tablero);
                bf.Serialize(fscore, score);
                bf.Serialize(faggressive, Aggressive);
                fboard.Dispose();
                fscore.Dispose();
                faggressive.Dispose();
            }
        }
        public void LoadGame(int Rows, int Columns)
        {
           
            BinaryFormatter bf = new BinaryFormatter();
            if (Aggressive)
            {
                FileStream fboard = new FileStream("AGBoard" + Rows + "X" + Columns + ".dat", FileMode.Open, FileAccess.Read);
                FileStream fscore = new FileStream("AGScore" + Rows + "X" + Columns + ".dat", FileMode.Open, FileAccess.Read);
                FileStream faggressive = new FileStream("Agressive" + Rows + "X" + Columns + ".dat", FileMode.Open, FileAccess.Read);
                Tablero = (BOARD)bf.Deserialize(fboard);
                score = (int)bf.Deserialize(fscore);
                Aggressive = (bool)bf.Deserialize(faggressive);
                fboard.Dispose();
                fscore.Dispose();
                faggressive.Dispose();
            }
            if(!Aggressive)
            {
                FileStream fboard = new FileStream("NORBoard" + Rows + "X" + Columns + ".dat", FileMode.Open, FileAccess.Read);
                FileStream fscore = new FileStream("NORScore" + Rows + "X" + Columns + ".dat", FileMode.Open, FileAccess.Read);
                FileStream faggressive = new FileStream("Normal" + Rows + "X" + Columns + ".dat", FileMode.Open, FileAccess.Read);
                Tablero = (BOARD)bf.Deserialize(fboard);
                score = (int)bf.Deserialize(fscore);
                Aggressive = (bool)bf.Deserialize(faggressive);
                fboard.Dispose();
                fscore.Dispose();
                faggressive.Dispose();
            }
        }
        #endregion

        #region Private Methods



        void WhereOccupiedAndDesoccupied()
        {
            Desoccupied = new List<Tuple<int, int>>();
            Occupied = new List<Tuple<int, int>>();

            for (int i = 0; i < Tablero.heigth; i++)
                for (int j = 0; j < Tablero.width; j++)
                {
                    if (Tablero[i, j].value == 0) Desoccupied.Add(new Tuple<int, int>(i, j));
                    else Occupied.Add(new Tuple<int, int>(i, j));
                }
        }
        bool Valid(int x, int y)
        {
            return (x >= 0 && y >= 0 && x < Tablero.width && y < Tablero.heigth);
        }       
        bool Lost()
        {
            if (Desoccupied.Count > 0) return false;

            for (int i = 0; i < Tablero.heigth; i++)
                for (int j = 0; j < Tablero.width; j++)
                    for (int k = 0; k < 2; k++)
                    {
                        int NextY = i + D_Rows[k];
                        int NextX = j + D_Columns[k];
                        if (Valid(NextX, NextY))
                        {
                            if (Tablero[i, j].value == Tablero[NextY, NextX].value)
                            { return false; }
                        }
                    }
            return true;
        }           
        void GenerateBox(int Generate)
        {
            while (Generate != 0)
            {
                WhereOccupiedAndDesoccupied();
               Tuple<int,int> Momentaneous= Desoccupied.ElementAt<Tuple<int, int>>(r.Next(0,((Desoccupied.Count())-1)));
                int Row =Momentaneous.Item1;
                int Column = Momentaneous.Item2;

                Tablero[Row, Column].value = r.Next(1,4);
                Occupied.Add(Momentaneous);
                Desoccupied.Remove(Momentaneous);

                Generate--;

            }
                    
        }
        Stack<Tuple<int, int>> FindPath(int RowI, int ColumnI,int RowF, int ColumnF)
        {
            int[,] LookP = new int[Tablero.heigth, Tablero.width];

            for (int i = 0; i < Tablero.heigth; i++)
                for (int j = 0; j < Tablero.width; j++)
                   if (Tablero[i, j].value != 0)
                        LookP[i, j] = -1;
            
            LookP[RowI, ColumnI] = 1;
            LookP[RowF, ColumnF] = 0;

           Queue<Tuple<int, int>> Coordenadas = new Queue<Tuple<int, int>>();
           Coordenadas.Enqueue(new Tuple<int, int>(RowI, ColumnI));

            while (Coordenadas.Count != 0)
            {
                int X = Coordenadas.Peek().Item2;
                int Y = Coordenadas.Peek().Item1;

                for (int i = 0; i < 4; i++)
                {
                    int NextRow = Y + D_Rows[i];
                    int NextCol = X + D_Columns[i];

                    if ((NextRow>=0) &&( NextRow < LookP.GetLength(0)) &&( NextCol>=0 )&&( NextCol<LookP.GetLength(1)) && (LookP[NextRow, NextCol] == 0))
                    {
                        Coordenadas.Enqueue(new Tuple<int, int>(NextRow, NextCol));
                        LookP[NextRow, NextCol] = LookP[Y, X] + 1;
                    }
                }
                Coordenadas.Dequeue();
                if(LookP[RowF, ColumnF] != 0)break;
            }

            PathWay = new Stack<Tuple<int, int>>();
            if (LookP[RowF, ColumnF] != 0)
            {
                
                PathWay.Push(new Tuple<int, int>(RowF, ColumnF));

                int X = PathWay.Peek().Item2;
                int Y = PathWay.Peek().Item1;

                while (LookP[Y, X] != 1)
                  for (int i = 0; i < 4; i++)
                    {
                        int NextRow = Y + D_Rows[i];
                        int NextCol = X + D_Columns[i];

                        if (NextRow >= 0 && NextRow < LookP.GetLength(0) && NextCol >= 0 && NextCol < LookP.GetLength(1) && (LookP[NextRow, NextCol] == (LookP[Y, X] - 1)))
                        {
                            PathWay.Push(new Tuple<int, int>(NextRow, NextCol));
                            Y = NextRow;
                            X = NextCol;

                            break;
                        }
                    }
            }
           return PathWay;
        }
        void Randomize()
        {
            if (Moves % 15 == 0)
              for (int i = 0; i < Tablero.width*Tablero.heigth; i++)
                {
                    Tuple<int, int> First = new Tuple<int, int>(r.Next(0, Tablero.heigth), r.Next(0, Tablero.width));
                    Tuple<int, int> Second = new Tuple<int, int>(r.Next(0, Tablero.heigth), r.Next(0, Tablero.width));

                    int Mom = Tablero[First.Item1, First.Item2].value;
                    Tablero[First.Item1, First.Item2].value = Tablero[Second.Item1, Second.Item2].value;
                    Tablero[Second.Item1, Second.Item2].value = Mom;
                    WhereOccupiedAndDesoccupied();                   
                }            
        }
        void ChangeOccupations(Tuple<int,int> Final, Tuple<int, int> Initial)
        {
            Occupied.Add(Final);
            Desoccupied.Add(Initial);
            Occupied.Remove(Initial);            
            Desoccupied.Remove(Final);
        }                 
        void AdBoxes(int RowI, int ColumnI, int RowF, int ColumnF)
        {
          
                    if ((RowI != RowF || ColumnI != ColumnF) && Tablero[RowI, ColumnI].value != 0 && Tablero[RowF, ColumnF].value == 0)
                    {
                        Tablero[RowF, ColumnF].value = Tablero[RowI, ColumnI].value;
                        Tablero[RowI, ColumnI].value = 0;

                        Tuple<int, int> Final = new Tuple<int, int>(RowF, ColumnF);
                        Tuple<int, int> Inicial = new Tuple<int, int>(RowI, ColumnI);
                        ChangeOccupations(Final, Inicial);

                        if (Desoccupied.Count > 1) GenerateBox(2);
                        if (Desoccupied.Count == 1) GenerateBox(1);
         
                        if (Aggressive)
                        {
                            Moves++;
                            Randomize();
                        }
                        
                    }
                    else if ((RowI != RowF || ColumnI != ColumnF) && Tablero[RowI, ColumnI].value != 0 && Tablero[RowF, ColumnF].value == Tablero[RowI, ColumnI].value)
                    {
                        Tablero[RowF, ColumnF].value = ((Tablero[RowI, ColumnI].value) + 1);
                        Tablero[RowI, ColumnI].value = 0;
                        score += ((Tablero[RowF, ColumnF].value));

                        if (Aggressive) { if (score > highscoreAG) highscoreAG = score; SaveHighScore(Tablero.heigth, Tablero.width); }
                        if(!Aggressive) { if (score > highscoreNOR) highscoreNOR = score; SaveHighScore(Tablero.heigth, Tablero.width); }

                        Tuple<int, int> Final = new Tuple<int, int>(RowF, ColumnF);
                        Tuple<int, int> Inicial = new Tuple<int, int>(RowI, ColumnI);
                        ChangeOccupations(Final, Inicial);
                    
                        GenerateBox(1);
                
                        if (Aggressive)
                        {
                            Moves++;
                            Randomize();
                        }                 
                    }       
        }
        #endregion
       
    }
}
