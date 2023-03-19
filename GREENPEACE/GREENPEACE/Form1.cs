using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GREENPEACE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath myPath = new System.Drawing.Drawing2D.GraphicsPath();
            myPath.AddPolygon(new Point[] { new Point(0, 200), new Point(300, 0), new Point(600, 200), new Point(300, 400) });
            
           
            Region myRegion = new Region(myPath);
            this.Region = myRegion;

            // Determine the center point of the form
            //Point centerPoint = new Point((int)(myPath.PathPoints[0].X + ((myPath.PathPoints[2].X - myPath.PathPoints[0].X) / 2)),
            //(int)(myPath.PathPoints[0].Y + ((myPath.PathPoints[2].Y - myPath.PathPoints[0].Y) / 2)) );
            
            
            Point centerPoint = new Point((int)((myPath.PathPoints[0].X + myPath.PathPoints[1].X + myPath.PathPoints[2].X + myPath.PathPoints[3].X) / 4),
                (int)((myPath.PathPoints[0].Y + myPath.PathPoints[1].Y + myPath.PathPoints[2].Y + myPath.PathPoints[3].Y) / 4) );


            // Determine the width and height of the button
            int buttonWidth = CloseGreen.Size.Width;
            int buttonHeight = CloseGreen.Size.Height;

            // Calculate the X and Y coordinates of the top-left corner of the button
            int buttonX = centerPoint.X - buttonWidth / 2;
            int buttonY = centerPoint.Y - buttonHeight;

            // Set the Location property of the button to the calculated coordinates
            CloseGreen.Location = new Point(buttonX, buttonY);



        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
