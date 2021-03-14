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
                fail();                                                                       // if nothing is presented in textbox
            }
            else 
            {
                double result = Convert.ToDouble(txbxProportion.Text);                        // turns text in the textbox (string) to double
                if (result > 1.0 || result < 0)                                               // checks to see if the result is between 0 and 1 (no outliers like 1.01 and -0.1)
                {
                    fail();                                                                   // if requirements are not met
                }
                else                                                                          // the textbox number is valid
                {
                    int intResult = Convert.ToInt32(result * 100);                            // turns double into int for the graphic and textbox between 0 and 100
                    int remainder = 100 - Convert.ToInt32(result * 100);                      // turns double into int for the graphic and textbox between 0 and 100
                    gPaper.FillRectangle(bGreen, 0, 0, intResult*2, 150);                     // creates green rectangle in gPaper
                    gPaper.FillRectangle(bYellow, intResult*2, 0, remainder*2, 150);          // created yellow rectangle in gPaper

                    lblResult.Text = "The rectangle is " + Convert.ToString(intResult) + "% green and " + Convert.ToString(remainder) + "% yellow";     // prints label

                }
            }
        }

        private void fail()                                                                   // called when requirements are not met for Proportion test
        {
            lblResult.Text = "Please enter a valid number between 0.0 and 1.0. E.g. 0.5846";  // prints label
        }
    }
}
