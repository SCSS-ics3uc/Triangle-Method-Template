using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace TriangleMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            /* Setup your DrawTriangle method and then uncomment
             * the following line to test if the method draws a triangle 
             * correctly. Show me when this part is done.
             */
            
            Pen redPen = new Pen(Color.Red);
            //DrawTriangle(redPen, 10, 10, 200, 40, 50, 70);
        }

        /* you need to setup all the parameters for this method. Take a look at the 
         * assignment for details.
         */
        public void DrawTriangle()
        {
            /* the first of the three draw lines you will need to create is 
             * shown below. Use it to help you create the next two lines
             */

            Graphics formGraphics = this.CreateGraphics();
            //formGraphics.DrawLine(drawPen, x1, y1, x2, y2);
        }
    }
}
