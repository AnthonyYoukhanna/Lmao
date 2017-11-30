using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TilePicker
{
    class Grid
    {

        // provate fields/members
        private Tile[,] mGrid;
        private int mRows, mColumns;
        private int mCellSize;


        //constructors
        public Grid(int Rows, int Columns, int CellSize)
        {
            //store rows, columns, cell size
            this.mRows = Rows;
            this.mColumns = Columns;
            this.mCellSize = CellSize;


            //set the grid size in memory
            mGrid = new Tile[this.mRows, this.mColumns];


            //create each cell in the array ( each element
            for (int i = 0; i < this.mRows; i++)
            {
                for (int j = 0; j < this.mColumns; j++)
                {
                    mGrid[i, j] = new Tile();
                }

            }

            //Create and palce tiles in order
            int RedTile = 20;
            int BlueTile = 20;
            int GreenTile = 5;
            int MaroonTile = 5;
            int AquaTile = 4;
            int BrownTile = 5;
            int BlackTile = 5;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (RedTile != 0)
                    {
                        mGrid[i, j].ScoreColour = Color.Red;
                        RedTile--;
                    }
                    else if (BlueTile != 0)
                    {
                        mGrid[i, j].ScoreColour = Color.Blue;
                        BlueTile--;
                    }
                    else if (GreenTile != 0)
                    {
                        mGrid[i, j].ScoreColour = Color.Green;
                        GreenTile--;
                    }
                    else if (MaroonTile != 0)
                    {
                        mGrid[i, j].ScoreColour = Color.Maroon;
                        MaroonTile--;
                    }
                    else if (AquaTile != 0)
                    {
                        mGrid[i, j].ScoreColour = Color.Aqua;
                        AquaTile--;
                    }
                    else if (BrownTile != 0)
                    {
                        mGrid[i, j].ScoreColour = Color.Brown;
                        BrownTile--;
                    }
                    else if (BlackTile != 0)
                    {
                        mGrid[i, j].ScoreColour = Color.Black;
                        BlackTile--;
                    }
                }
            }

            
            Color Temp;
            Random Index = new Random();
            for (int x = 0; x < 10; x++)
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        
                        int Row = Index.Next(0, 7);
                        int Column = Index.Next(0, 7);


                        Temp = mGrid[i, j].ScoreColour;
                        mGrid[i, j].ScoreColour = mGrid[Row, Column].ScoreColour;
                        mGrid[Row, Column].ScoreColour = Temp;

                    }
                }
            }

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (mGrid[i,j].ScoreColour == Color.Red)
                        {
                            mGrid[i,j].Score = 1;
                        }
                    else if (mGrid[i, j].ScoreColour == Color.Blue)
                        {
                            mGrid[i, j].Score = 2;
                        }
                    else if (mGrid[i, j].ScoreColour == Color.Green)
                        {
                            mGrid[i, j].Score = 3;
                        }
                    else if (mGrid[i, j].ScoreColour == Color.Maroon)
                        {
                            mGrid[i, j].Score = 5;
                        }
                    else if (mGrid[i, j].ScoreColour == Color.Aqua)
                        {
                            mGrid[i, j].Score = 10;
                        }
                    else if (mGrid[i, j].ScoreColour == Color.Brown)
                        {
                            mGrid[i, j].Score = -1;
                        }
                    else if (mGrid[i, j].ScoreColour == Color.Black)
                        {
                            mGrid[i, j].Score = -3;
                        }
            
                }
            }
        }

        //subtract tog et to 0,0
        //divide by cell size


        
            
        




        //methods
        public Tile GetCell(int Row, int Column)
        {
            return mGrid[Row, Column];
        }

        public void Draw(Graphics g, int X, int Y)
        {

            int pX = X;
            int pY = Y;
            for (int i = 0; i < this.mRows; i++)
            {
                pY = Y + (i * this.mCellSize);
                for (int j = 0; j < this.mColumns; j++)
                {
                    pX = X + (j * this.mCellSize);
                    mGrid[i, j].Draw(g, pX, pY);

                }
            }
        }
    }
}
