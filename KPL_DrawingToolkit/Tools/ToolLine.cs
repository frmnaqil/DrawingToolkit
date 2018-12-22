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
            this.Name = "Stateful Line Tool";
            this.ToolTipText = "Stateful Line Tool";
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
                lineSegment.EndPoint = new System.Drawing.Point(e.X, e.Y);
                canvas.AddDrawingObject(lineSegment);
            }
        }

        public void ToolMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (this.lineSegment != null)
                {
                    lineSegment.EndPoint = new System.Drawing.Point(e.X, e.Y);
                }
            }
        }

        public void ToolMouseUp(object sender, MouseEventArgs e)
        {
            if (this.lineSegment != null)
            {
                if (e.Button == MouseButtons.Left)
                {
                    lineSegment.EndPoint = new System.Drawing.Point(e.X, e.Y);
                    lineSegment.Select();
                }
                else if (e.Button == MouseButtons.Right)
                {
                    canvas.RemoveDrawingObject(this.lineSegment);
                }
                
            }
        }
    }
}
