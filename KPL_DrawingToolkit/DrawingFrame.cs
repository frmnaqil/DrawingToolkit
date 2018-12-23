using KPL_DrawingToolkit.Tools;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Diagnostics;
using System.Windows.Forms;

namespace KPL_DrawingToolkit
{
    public partial class DrawingFrame : Form
    {
        private IToolbox toolbox;
        private IEditor editor;

        public DrawingFrame()
        {
            InitializeComponent();
            InitForm();
        }

        private void InitForm()
        {
            Debug.WriteLine("Loading UI . . .");

            #region Editor and Canvas

            Debug.WriteLine("Loading Canvas . . .");

            this.editor = new DrawingEditor();
            this.toolStripContainer1.ContentPanel.Controls.Add((Control)this.editor);

            ICanvas canvas = new DrawingCanvas();
            canvas.Name = "Untitled";
            this.editor.AddCanvas(canvas);

            #endregion

            #region Toolbox

            Debug.WriteLine("Loading Toolbox . . .");
            this.toolbox = new Toolbox();
            this.toolStripContainer1.TopToolStripPanel.Controls.Add((Control)this.toolbox);
            this.editor.Toolbox = toolbox;

            #endregion

            #region Tools

            Debug.WriteLine("Loading Tools . . .");
            this.toolbox.AddTool(new ToolSelection());
            this.toolbox.AddSeparator();
            this.toolbox.AddTool(new ToolLine());
            this.toolbox.AddSeparator();
            this.toolbox.AddTool(new ToolRectangle());
            this.toolbox.AddSeparator();
            this.toolbox.AddTool(new ToolOval());
            this.toolbox.AddSeparator();
            this.toolbox.AddTool(new ToolGradient());
            this.toolbox.ToolSelected += Toolbox_ToolSelected;

            #endregion


        }

        private void Toolbox_ToolSelected(ITool tool)
        {
            if (this.editor != null)
            {
                Debug.WriteLine("Tool " + tool.Name + " is selected");
                ICanvas canvas = this.editor.GetSelectedCanvas();
                canvas.SetActiveTool(tool);
                tool.Canvas = canvas;
            }
        }
    }
}
