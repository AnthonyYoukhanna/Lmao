using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TilePicker
{
    class Tile
    {
        //private fields/members
        private int mSize;
        private Color mBackgroundColour;
        private Color mBorderColour;
        private Color mScoreColour;
        private int mScore;
        private bool mSelected;







        //Constructor
        public Tile()
        {
            //default cell to white with black border
            this.mSize = 40;  //default to 20 pixels
            this.mBackgroundColour = Color.Tomato;
            this.mBorderColour = Color.White;
           
        }

        public Tile(int Size, Color BackgroundColour, Color BorderColour)
        {
            this.mSize = Size;
            this.mBackgroundColour = BackgroundColour;
            this.mBorderColour = BorderColour;

        }


      


        //Methods
        public void Draw(Graphics g, int X, int Y)
        {
            //will draw a cell on graphics object
            //x and y represent the location of 
            //top left corner of the cell

            //create a pen and a brush to draw with
            Pen BorderPen = new Pen(this.mBorderColour);
            SolidBrush BackBrush = new SolidBrush(this.mBackgroundColour);

            //draw cell
            g.FillRectangle(BackBrush, X, Y, this.mSize, this.mSize);
            g.DrawRectangle(BorderPen, X, Y, this.mSize, this.mSize);


            //dispose of drawing objects
            BorderPen.Dispose();
            BackBrush.Dispose();

        }




        //Properties
        public int Size
        {
            set { this.mSize = value; }
            get { return this.mSize; }
        }

        public Color BackgroundColour
        {
            set { this.mBackgroundColour = value; }
            get { return this.mBackgroundColour; }

        }

        public Color BorderColour
        {
            set { this.mBorderColour = value; }
            get { return this.mBorderColour; }

        }
        public Color ScoreColour
        {
            set { this.mScoreColour = value; }
            get { return this.mScoreColour; }

        }
        public int Score
        {
            set { this.mScore = value; }
            get { return this.mScore; }

        }
        public bool Selected
        {
            set { this.mSelected = value; }
            get { return this.mSelected; }

        }
        
    }
}
