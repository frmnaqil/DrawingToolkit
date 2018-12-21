using KPL_DrawingToolkit.Shapes;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace KPL_DrawingToolkit.Tools
{
    public class ToolRectangle : ToolStripButton, ITool
    {
        private ICanvas canvas;
        private ShapeRectangle rectangle;

        public Cursor Cursor => Cursors.Arrow;

        public ICanvas Canvas { get => this.canvas; set => this.canvas = value; }

        public ToolRectangle()
        {
            this.Name = "Rectangle Tool";
            this.ToolTipText = "Rectangle Tool";
            this.Image = global::KPL_DrawingToolkit.Properties.Resources.Rectangle;
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
                this.rectangle = new ShapeRectangle(e.X, e.Y);
            }
        }

        public void ToolMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (this.rectangle != null)
                {

                    int width = e.X - rectangle.X;
                    int height = e.Y - rectangle.Y;

                    if (width != 0 || height != 0)
                    {
                        this.rectangle.Width = width;
                        this.rectangle.Height = height;
                    }
                }
            }
        }

        public void ToolMouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.canvas.AddDrawingObject(this.rectangle);
            }
        }
    }
}
