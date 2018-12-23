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
        private bool isGradient;

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
            if (isGradient)
            {
                LinearGradientBrush linGrBrush = new LinearGradientBrush(
                new Point(this.X, this.Y),
                new Point(Width + this.X, Height + this.Y),
                Color.FromArgb(255, 255, 0, 0),   // Opaque red
                Color.FromArgb(255, 0, 0, 255));

                ColorBlend blend = new ColorBlend(2);
                blend.Colors = new Color[2] { Color.Red, Color.Blue };
                blend.Positions = new float[2] { 0f, 1f };

                linGrBrush.InterpolationColors = blend;

                Graphics.FillRectangle(linGrBrush, X, Y, Width, Height);
            }
            else
            {
                this.pen.Color = Color.Blue;
                this.pen.Width = 2.0f;
                this.pen.DashStyle = DashStyle.Solid;
                Graphics.DrawRectangle(this.pen, X, Y, Width, Height);
            }
        }

        public override void RenderOnStaticView()
        {
            if (isGradient)
            {
                LinearGradientBrush linGrBrush = new LinearGradientBrush(
                new Point(this.X, this.Y),
                new Point(Width + this.X, Height + this.Y),
                Color.FromArgb(255, 255, 0, 0),   // Opaque red
                Color.FromArgb(255, 0, 0, 255));

                ColorBlend blend = new ColorBlend(2);
                blend.Colors = new Color[2] { Color.Red, Color.Blue };
                blend.Positions = new float[2] { 0f, 1f };

                linGrBrush.InterpolationColors = blend;

                Graphics.FillRectangle(linGrBrush, X, Y, Width, Height);
            }
            else
            {
                this.pen.Color = Color.Black;
                this.pen.DashStyle = DashStyle.Solid;
                Graphics.DrawRectangle(this.pen, X, Y, Width, Height);
            }
        }

        public override void DrawGradient() => this.isGradient = true;
    }
}
