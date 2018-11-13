using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KPL_DrawingToolkit
{
    public partial class DrawingFrame : Form
    {

        private bool LineToolStatus;
        private bool CircleToolStatus;
        private int InitialPointX;
        private int InitialPointY;

        public DrawingFrame()
        {
            InitializeComponent();
        }

        private void lineTool_Click(object sender, EventArgs e)
        {
            LineToolStatus = true;
            CircleToolStatus = false;

        }

        private void circleTool_Click(object sender, EventArgs e)
        {
            LineToolStatus = false;
            CircleToolStatus = true;

        }

        private void drawingCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            InitialPointX = e.X;
            InitialPointY = e.Y;
        }

        private void drawingCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (LineToolStatus == true)
            {
                DrawLine(e.X, e.Y);
            }
            else DrawCircle(e.X, e.Y);
        }

        private void DrawCircle(int x, int y)
        {
            Pen pen = new Pen(Color.Black, 1);
            Graphics circle;
            circle = drawingCanvas.CreateGraphics();
            circle.DrawEllipse(pen, InitialPointX, InitialPointY, x - InitialPointX, y - InitialPointY);

            pen.Dispose();
            circle.Dispose();
        }

        private void DrawLine(int EndPointX, int EndPointY)
        {
            Point point1 = new Point(InitialPointX, InitialPointY);
            Point point2 = new Point(EndPointX, EndPointY);

            Pen pen = new Pen(Color.Black, 1);
            Graphics line;
            line = drawingCanvas.CreateGraphics();
            line.DrawLine(pen, point1, point2);

            pen.Dispose();
            line.Dispose();
        }

        private void drawingCanvas_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
