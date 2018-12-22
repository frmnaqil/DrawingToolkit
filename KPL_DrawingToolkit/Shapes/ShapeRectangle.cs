using System.Drawing.Drawing2D;
using System.Diagnostics;
using System.Drawing;

namespace KPL_DrawingToolkit.Shapes
{
    class ShapeRectangle : DrawingObject
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public Pen pen;

        public ShapeRectangle()
        {
            this.pen = new Pen(Color.Black);
            pen.Width = 1.5f;
        }

        public ShapeRectangle(int x, int y) : this()
        {
            this.X = x;
            this.Y = y;
        }

        public ShapeRectangle(int x, int y, int width, int height) : this(x, y)
        {
            this.Width = width;
            this.Height = height;
        }

        public ShapeRectangle(int x, int y, int width, int height, Pen pen) : this(x, y, width, height)
        {
            this.pen = pen;
        }

        public override bool Intersect(int xTest, int yTest)
        {
            if ((xTest >= X && xTest <= X + Width) && (yTest >= Y && yTest <= Y + Height))
            {
                Debug.WriteLine("Object " + IDObject + " is selected.");
                return true;
            }
            return false;
        }

        public override void Translate(int x, int y, int xAmount, int yAmount)
        {
            this.X += xAmount;
            this.Y += yAmount;
        }

        public override void RenderOnPreview()
        {
            this.pen.Color = Color.Red;
            this.pen.Width = 2.0f;
            this.pen.DashStyle = DashStyle.DashDotDot;
            Graphics.DrawRectangle(this.pen, X, Y, Width, Height);
        }

        public override void RenderOnEditingView()
        {
            this.pen.Color = Color.Blue;
            this.pen.Width = 2.0f;
            this.pen.DashStyle = DashStyle.Solid;
            Graphics.DrawRectangle(this.pen, X, Y, Width, Height);
        }

        public override void RenderOnStaticView()
        {
            this.pen.Color = Color.Black;
            this.pen.DashStyle = DashStyle.Solid;
            Graphics.DrawRectangle(this.pen, X, Y, Width, Height);
        }
    }
}
