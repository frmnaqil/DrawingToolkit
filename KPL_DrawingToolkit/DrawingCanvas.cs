using System;
using System.Drawing;
using System.Windows.Forms;

namespace KPL_DrawingToolkit
{
    public partial class DrawingCanvas : Control, ICanvas
    {

        private ITool activeTool;

        public DrawingCanvas()
        {
            Init();
        }

        private void Init()
        {
            this.DoubleBuffered = true;
            this.BackColor = Color.White;
            this.Dock = DockStyle.Fill;
        }

        public void Repaint()
        {
            this.Invalidate();
            this.Update();
        }

        public void SetActiveTool(ITool tool)
        {
            this.activeTool = tool;
        }

        public void SetBackgroundColor(Color color)
        {
            this.BackColor = color;
        }
    }
}
