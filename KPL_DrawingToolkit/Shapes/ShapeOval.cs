using System.Drawing.Drawing2D;
using System.Diagnostics;
using System.Drawing;

namespace KPL_DrawingToolkit.Shapes
{
    public class ShapeOval : DrawingObject
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        private Pen pen;

        public ShapeOval()
        {
            this.pen = new Pen(Color.Black);
            pen.Width = 1.5f;
        }

        public ShapeOval(int x, int y) : this()
        {
            this.X = x;
            this.Y = y;
        }

        public ShapeOval(int x, int y, int width, int height) : this(x, y)
        {
            this.Width = width;
            this.Height = height;
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
            Graphics.DrawEllipse(this.pen, X, Y, Width, Height);
        }

        public override void RenderOnEditingView()
        {
            this.pen.Color = Color.Blue;
            this.pen.Width = 2.0f;
            this.pen.DashStyle = DashStyle.Solid;
            Graphics.DrawEllipse(this.pen, X, Y, Width, Height);
        }

        public override void RenderOnStaticView()
        {
            this.pen.Color = Color.Black;
            this.pen.DashStyle = DashStyle.Solid;
            Graphics.DrawEllipse(this.pen, X, Y, Width, Height);
        }
    }
}
