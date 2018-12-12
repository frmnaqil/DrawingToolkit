using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Diagnostics;
using System.Windows.Forms;

namespace KPL_DrawingToolkit
{
    public partial class DrawingFrame : Form
    {
        private IToolbox toolbox;
        private ICanvas canvas;

        private bool LineToolStatus;
        private bool CircleToolStatus;
        private int InitialPointX;
        private int InitialPointY;

        public DrawingFrame()
        {
            InitializeComponent();
            InitForm();
        }

        private void InitForm()
        {
            Debug.WriteLine("Loading UI . . .");

            #region Toolbox

            Debug.WriteLine("Loading Toolbox . . .");
            this.toolbox = new Toolbox();



            #endregion



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

            LinearGradientBrush linGrBrush = new LinearGradientBrush(
                new Point(0, 10),
                new Point(200, 10),
                Color.FromArgb(255, 255, 0, 0),   // Opaque red
                Color.FromArgb(255, 0, 0, 255));  // Opaque blue

            Pen pen = new Pen(linGrBrush);
            Graphics circle;
            circle = drawingCanvas.CreateGraphics();
            circle.FillEllipse(linGrBrush, InitialPointX, InitialPointY, x - InitialPointX, y - InitialPointY);

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

        private void ToolGradient_Click(object sender, EventArgs e)
        {

        }

        private void GradientSelectColor1(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();
            colorDialog1.ShowDialog();

        }

        private void GradientSelectColor2(object sender, EventArgs e)
        {
            ColorDialog colorDialog2 = new ColorDialog();
            colorDialog2.ShowDialog();

        }
    }
}
