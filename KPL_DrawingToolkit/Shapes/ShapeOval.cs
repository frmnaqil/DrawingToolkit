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

        public override void Draw()
        {
            this.Graphics.DrawEllipse(pen, X, Y, Width, Height);
        }

        public override bool Intersect(int xTest, int yTest)
        {
            throw new System.NotImplementedException();
        }

        public override void Translate(int x, int y, int xAmount, int yAmount)
        {
            throw new System.NotImplementedException();
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
