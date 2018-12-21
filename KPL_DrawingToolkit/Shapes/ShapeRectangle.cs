using System.Drawing;

namespace KPL_DrawingToolkit.Shapes
{
    class ShapeRectangle : DrawingObject
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        private Pen pen;

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

        public override void Draw()
        {
            this.Graphics.DrawRectangle(pen, X, Y, Width, Height);
        }
    }
}
