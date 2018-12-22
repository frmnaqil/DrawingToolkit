using KPL_DrawingToolkit.Shapes;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace KPL_DrawingToolkit.Tools
{
    public partial class ToolOval : ToolStripButton, ITool
    {
        private ICanvas canvas;
        private ShapeOval oval;

        public Cursor Cursor => Cursors.Arrow;

        public ICanvas Canvas { get => this.canvas; set => this.canvas = value; }

        public ToolOval()
        {
            this.Name = "Oval Tool";
            this.ToolTipText = "Oval Tool";
            this.Image = global::KPL_DrawingToolkit.Properties.Resources.Circle;
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
                this.oval = new ShapeOval(e.X, e.Y);
                this.canvas.AddDrawingObject(this.oval);
            }
        }

        public void ToolMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (this.oval != null)
                {
                    int width = e.X - oval.X;
                    int height = e.Y - oval.Y;

                    if (width != 0 || height != 0)
                    {
                        this.oval.Width = width;
                        this.oval.Height = height;
                    }
                }
            }
        }

        public void ToolMouseUp(object sender, MouseEventArgs e)
        {
            if (oval != null)
            {
                if (e.Button == MouseButtons.Left)
                {
                    this.oval.Select();
                }
                else if (e.Button == MouseButtons.Right)
                {
                    canvas.RemoveDrawingObject(this.oval);
                }
            }
        }
    }
}
