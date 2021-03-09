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
            Graphics gPaper = picbxDrawing.CreateGraphics();
            SolidBrush bGreen = new SolidBrush(Color.Green);
            SolidBrush bYellow = new SolidBrush(Color.Yellow);
            if (txbxProportion.Text == "")
            {
                fail();
            }
            else 
            {
                int result = Convert.ToInt32((Convert.ToDouble(txbxProportion.Text) * 100));
                if (result > 100 || result < 10)
                {
                    fail();
                }
                else
                {
                    int remainder = 100 - result;
                    gPaper.FillRectangle(bGreen, 0, 0, result*2, 150);
                    gPaper.FillRectangle(bYellow, result*2, 0, remainder*2, 150);

                    lblResult.Text = "The rectangle is " + Convert.ToString(result) + "% green and " + Convert.ToString(remainder) + "% yellow";

                }
            }
        }

        private void fail()
        {
            lblResult.Text = "Please enter a valid number between 0.0 and 1.0. E.g. 0.5846";
        }
    }
}
