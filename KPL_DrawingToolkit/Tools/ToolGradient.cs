using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace KPL_DrawingToolkit.Tools
{
    public class ToolGradient : ToolStripButton, ITool
    {
        private ICanvas canvas;
        private DrawingObject selectedObject;

        public ToolGradient()
        {
            this.Name = "Gradient Tool";
            this.ToolTipText = "Gradient Tool";
            this.Image = global::KPL_DrawingToolkit.Properties.Resources.Gradient;
            this.CheckOnClick = true;
        }

        public Cursor Cursor => Cursors.Arrow;

        public ICanvas Canvas { get => this.canvas; set => this.canvas = value; }

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
            if (e.Button == MouseButtons.Left && canvas != null)
            {
                canvas.DeselectAllObjects();
                selectedObject = canvas.SelectObjectAt(e.X, e.Y);
                if (selectedObject != null)
                {
                    selectedObject.DrawGradient();
                }
            }
        }

        public void ToolMouseMove(object sender, MouseEventArgs e)
        {
            
        }

        public void ToolMouseUp(object sender, MouseEventArgs e)
        {

        }
    }
}
