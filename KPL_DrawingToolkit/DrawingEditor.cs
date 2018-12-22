using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace KPL_DrawingToolkit
{
    public class DrawingEditor : TabControl, IEditor
    {
        private List<ICanvas> canvases;
        private ICanvas selectedCanvas;
        private IToolbox toolbox;

        public IToolbox Toolbox { get => this.toolbox; set => this.toolbox = value; }

        public DrawingEditor()
        {
            Dock = DockStyle.Fill;
            canvases = new List<ICanvas>();

            this.Selected += DrawingEditor_Selected;
        }

        private void DrawingEditor_Selected(object sender, TabControlEventArgs e)
        {
            this.selectedCanvas = (ICanvas)e.TabPage.Controls[0];
            this.toolbox.ActiveTool = this.selectedCanvas.GetActiveTool();
        }

        public void AddCanvas(ICanvas canvas)
        {
            canvases.Add(canvas);
            TabPage tab = new TabPage(canvas.Name);
            tab.Controls.Add((Control)canvas);
            this.Controls.Add(tab);
            this.SelectedTab = tab;
            this.selectedCanvas = canvas;
        }

        public ICanvas GetSelectedCanvas()
        {
            return this.selectedCanvas;
        }

        public void RemoveCanvas(ICanvas canvas)
        {
            throw new NotImplementedException();
        }

        public void RemoveSelectedCanvas()
        {
            throw new NotImplementedException();
        }
        public void SelectCanvas(ICanvas canvas)
        {
            this.selectedCanvas = canvas;
        }
    }
}
