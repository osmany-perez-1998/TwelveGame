using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwuelveBehind
{
    [Serializable]
    public class CASILLA
    {
        public int value;
        public bool NotNull;
        public CASILLA()
        {
            value = 0;
            NotNull=false;
        }
    }
    [Serializable]
    public class BOARD
    {
        public CASILLA[,] Tablero;
        public bool[,] Not0;
        public int width { get; private set; }
        public int heigth { get; private set; }

        public void Start()
        {
            for (int i = 0; i < heigth; i++)
                for (int j = 0; j < width; j++)
                {
                    Tablero[i, j] = new CASILLA();
                }
        }
       
        public CASILLA this[int Row, int Column]
        {
            get { return Tablero[Row, Column]; }
            set { Tablero[Row, Column] = value; }
           
        }
      
        public BOARD(int HeightGiven, int WidthGiven)
        {
            width = WidthGiven;
            heigth = HeightGiven;
            Tablero = new CASILLA[heigth, width];
            
            Start();
        }
        
    }

}
