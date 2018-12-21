using KPL_DrawingToolkit.Shapes;
using System;
using System.Windows.Forms;

namespace KPL_DrawingToolkit.Tools
{
    public class ToolLine : ToolStripButton, ITool
    {
        private ICanvas canvas;
        private ShapeLine lineSegment;

        public Cursor Cursor => Cursors.Arrow;

        public ICanvas Canvas { get => this.canvas; set => this.canvas = value; }

        public ToolLine()
        {
            this.Name = "Line Tool";
            this.ToolTipText = "Line Tool";
            this.Image = global::KPL_DrawingToolkit.Properties.Resources.Line;
            this.CheckOnClick = true;
        }

        public void ToolHotKeysDown(object sender, Keys e)
        {
            throw new NotImplementedException();
        }

        public void ToolKeyDown(object sender, KeyEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void ToolKeyUp(object sender, KeyEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void ToolMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lineSegment = new ShapeLine(new System.Drawing.Point(e.X, e.Y));
            }
        }

        public void ToolMouseMove(object sender, MouseEventArgs e)
        {

        }

        public void ToolMouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lineSegment.EndPoint = new System.Drawing.Point(e.X, e.Y);

                if (lineSegment.StartPoint != lineSegment.EndPoint)
                {
                    canvas.AddDrawingObject(lineSegment);
                }
            }
        }
    }
}
