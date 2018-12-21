using System.Drawing;

namespace KPL_DrawingToolkit.Shapes
{
    public class ShapeLine : DrawingObject
    {
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

        public override void Draw()
        {
            this.Graphics.DrawLine(this.pen, StartPoint, EndPoint);
        }
    }
}
