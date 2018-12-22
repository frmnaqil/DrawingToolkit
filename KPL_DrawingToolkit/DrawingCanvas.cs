using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace KPL_DrawingToolkit
{
    public partial class DrawingCanvas : Control, ICanvas
    {

        private ITool activeTool;
        private List<DrawingObject> drawingObjects;

        public DrawingCanvas()
        {
            Init();
        }

        private void Init()
        {
            this.drawingObjects = new List<DrawingObject>();
            this.DoubleBuffered = true;

            this.BackColor = Color.White;
            this.Dock = DockStyle.Fill;

            this.Paint += DrawingCanvas_Paint;
            this.MouseDown += DrawingCanvas_MouseDown;
            this.MouseUp += DrawingCanvas_MouseUp;
            this.MouseMove += DrawingCanvas_MouseMove;
        }

        private void DrawingCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.activeTool != null)
            {
                this.activeTool.ToolMouseMove(sender, e);
                this.Repaint();
            }
        }

        private void DrawingCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.activeTool != null)
            {
                this.activeTool.ToolMouseUp(sender, e);
                this.Repaint();
            }
        }

        private void DrawingCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.activeTool != null)
            {
                this.activeTool.ToolMouseDown(sender, e);
                this.Repaint();
            }
        }

        private void DrawingCanvas_Paint(object sender, PaintEventArgs e)
        {
            foreach (DrawingObject obj in drawingObjects)
            {
                obj.Graphics = e.Graphics;
                obj.Draw();
            }
        }

        public void Repaint()
        {
            this.Invalidate();
            this.Update();
        }

        public ITool GetActiveTool()
        {
            return this.activeTool;
        }

        public void SetActiveTool(ITool tool)
        {
            this.activeTool = tool;
        }

        public void SetBackgroundColor(Color color)
        {
            this.BackColor = color;
        }

        public void AddDrawingObject(DrawingObject drawingObject)
        {
            this.drawingObjects.Add(drawingObject);
        }

        public void RemoveDrawingObject(DrawingObject drawingObject)
        {
            this.drawingObjects.Remove(drawingObject);
        }

        public DrawingObject GetObjectAt(int x, int y)
        {
            foreach (DrawingObject obj in drawingObjects)
            {
                if (obj.Intersect(x, y))
                {
                    return obj;
                }
            }
            return null;
        }

        public DrawingObject SelectObjectAt(int x, int y)
        {
            DrawingObject obj = GetObjectAt(x, y);
            if (obj != null)
            {
                obj.Select();
            }
            return obj;
        }

        public void DeselectAllObjects()
        {
            foreach (DrawingObject drawObj in drawingObjects)
            {
                drawObj.Deselect();
            }
        }

    }
}
