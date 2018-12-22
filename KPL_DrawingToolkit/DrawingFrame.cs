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
        private ICanvas canvas;

        public DrawingFrame()
        {
            InitializeComponent();
            InitForm();
        }

        private void InitForm()
        {
            Debug.WriteLine("Loading UI . . .");

            #region Toolbox

            Debug.WriteLine("Loading Toolbox . . .");
            this.toolbox = new Toolbox();
            this.toolStripContainer1.TopToolStripPanel.Controls.Add((Control)this.toolbox);

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
            this.toolbox.ToolSelected += Toolbox_ToolSelected;


            #endregion

            #region Canvas

            Debug.WriteLine("Loading Canvas . . .");
            this.canvas = new DrawingCanvas();
            this.toolStripContainer1.ContentPanel.Controls.Add((Control)this.canvas);

            #endregion


        }

        private void Toolbox_ToolSelected(ITool tool)
        {
            if (this.canvas != null)
            {
                this.canvas.SetActiveTool(tool);
                tool.Canvas = this.canvas;
            }
        }
    }
}
