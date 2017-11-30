using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TilePicker
{
    public partial class TilePicker : Form
    {


        //global field
        Grid myGrid = new Grid(8, 8, 40);
        int Score = 0;
        int OofCounter = 0;

        public TilePicker()
        {
            InitializeComponent();
        }

        private void TilePicker_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {   

                //finding out what cell is clicked
                int X = (e.X) / 40;
                int Y = (e.Y) / 40;

                //if clicked outside grid, roast whoever did that
                if (Y < 0 |Y > 7 | X < 0 | X > 7 )
                {
                    MessageBox.Show("stop doing shit u monkey");
                }
                else //putting everyting into an else statement so game doesnt break by someone clicking out of bounds of grid
                {


                    myGrid.GetCell(Y, X).BackgroundColour = myGrid.GetCell(Y, X).ScoreColour;
                    this.Refresh();

                    //adding the score of the colour to the score counter
                    //and adding the amount of clicks only if tile has not been selected
                    if (myGrid.GetCell(Y, X).Selected != true)
                    {
                        Score += myGrid.GetCell(Y, X).Score;
                        OofCounter++;
                    }

                    //changing the cell to be selected to not be able to click same tile twice
                    myGrid.GetCell(Y, X).Selected = true;



                    //constant output of score and clicks
                    string Output = string.Empty;
                    string Clicks = string.Empty;
                    lblScore.Text = Output + "Score : " + Score;
                    lblClicks.Text = Output + "Clicks Left : " + (10 - OofCounter);



                    //showing end game screen after 10 clicks

                    if (OofCounter == 10)
                    {
                        if (Score >= 30)
                        {
                            MessageBox.Show("Lmao ur a god, ur score is: " + Score);

                        }
                        else
                        {
                            MessageBox.Show("Get off my game u scrub, garbo score of: " + Score);
                        }
                        Close();
                    }
                }
            }

        }

        private void TilePicker_Paint(object sender, PaintEventArgs e)
        {
            if (myGrid != null)
            {
                Graphics g = this.CreateGraphics();
                myGrid.Draw(g, 0, 0);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
