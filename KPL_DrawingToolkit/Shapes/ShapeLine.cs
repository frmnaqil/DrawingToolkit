using System.Drawing;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System;

namespace KPL_DrawingToolkit.Shapes
{
    public class ShapeLine : DrawingObject
    {
        private const double EPSILON = 3.0;

        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }

        private Pen pen;

        public ShapeLine()
        {
            this.pen = new Pen(Color.Black);
            pen.Width = 1.5f;
        }

        public ShapeLine(Point startpoint) : this()
        {
            this.StartPoint = startpoint;
        }

        public ShapeLine(Point startpoint, Point endpoint) : this(startpoint)
        {
            this.EndPoint = endpoint;
        }

        public override void RenderOnStaticView()
        {
            pen.Color = Color.Black;
            pen.Width = 1.5f;
            pen.DashStyle = DashStyle.Solid;

            if (this.Graphics != null)
            {
                this.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                this.Graphics.DrawLine(pen, this.StartPoint, this.EndPoint);

            }
        }

        public override void RenderOnEditingView()
        {
            pen.Color = Color.Blue;
            pen.Width = 2.0f;
            pen.DashStyle = DashStyle.Solid;

            if (this.Graphics != null)
            {
                this.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                this.Graphics.DrawLine(pen, this.StartPoint, this.EndPoint);
            }
        }

        public override void RenderOnPreview()
        {
            pen.Color = Color.Red;
            pen.Width = 2.0f;
            pen.DashStyle = DashStyle.DashDotDot;

            if (this.Graphics != null)
            {
                this.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                this.Graphics.DrawLine(pen, this.StartPoint, this.EndPoint);
            }
        }

        public override bool Intersect(int xTest, int yTest)
        {
            double m = GetSlope();
            double b = EndPoint.Y - m * EndPoint.X;
            double y_point = m * xTest + b;

            if (Math.Abs(yTest - y_point) < EPSILON)
            {
                Debug.WriteLine("Object " + IDObject + " is selected");
                return true;
            }
            return false;
        }

        private double GetSlope()
        {
            double m = (double)(EndPoint.Y - StartPoint.Y) / (double)(EndPoint.X - StartPoint.X);
            return m;
        }

        public override void Translate(int x, int y, int xAmount, int yAmount)
        {
            this.StartPoint = new Point(this.StartPoint.X + xAmount, this.StartPoint.Y + yAmount);
            this.EndPoint = new Point(this.EndPoint.X + xAmount, this.EndPoint.Y + yAmount);
        }

    }
}
