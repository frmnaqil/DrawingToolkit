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

        public override void Draw()
        {
            this.Graphics.DrawRectangle(pen, X, Y, Width, Height);
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
            throw new System.NotImplementedException();
        }

        public override void RenderOnEditingView()
        {
            throw new System.NotImplementedException();
        }

        public override void RenderOnStaticView()
        {
            throw new System.NotImplementedException();
        }
    }
}
