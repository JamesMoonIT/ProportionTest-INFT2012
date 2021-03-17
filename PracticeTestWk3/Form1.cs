/* 
Name: James Moon
Date: 17/3/2021
Description: The objective of the code is to take a value between 0.0 and 1.0 and create a rectangle coloured in a specific size
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeTestWk3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            Graphics gPaper = picbxDrawing.CreateGraphics();                                  // creates picture object out of picture box
            SolidBrush bGreen = new SolidBrush(Color.Green);                                  // creates green brush object
            SolidBrush bYellow = new SolidBrush(Color.Yellow);                                // creates yellow brush object
            if (txbxProportion.Text == "")
            {
                txbxResult.Text = "Please enter a valid number into the textbox. E.g. 0.5846";  // prints label                                                                       // if nothing is presented in textbox
            }
            else 
            {
                double result = Convert.ToDouble(txbxProportion.Text);                        // turns text in the textbox (string) to double
                int intResult = Convert.ToInt32(result * 100);                               // turns double into int for the graphic and textbox between 0 and 100
                int remainder = 100 - Convert.ToInt32(result * 100);                         // turns double into int for the graphic and textbox between 0 and 100
                if (intResult > 100)
                {
                    gPaper.FillRectangle(bGreen, 0, 0, 200, 100);
                    txbxResult.Text = "The rectangle is 100% green because " + intResult + "% makes no sense";
                }
                else if (intResult < 0)
                {
                    gPaper.FillRectangle(bYellow, 0, 0, 200, 100);
                    txbxResult.Text = "The rectangle is 0% becasue " + intResult + "% makes no sense";
                }
                else
                {
                    gPaper.FillRectangle(bGreen, 0, 0, intResult * 2, 150);                      // creates green rectangle in gPaper
                    gPaper.FillRectangle(bYellow, intResult * 2, 0, remainder * 2, 150);          // created yellow rectangle in gPaper
                    txbxResult.Text = "The rectangle is " + Convert.ToString(intResult) + "% green and " + Convert.ToString(remainder) + "% yellow";     // prints label
                }
                
            }
        }
    }
}
