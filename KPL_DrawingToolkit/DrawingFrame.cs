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



            #endregion



        }

        private void Toolbox_ToolSelected(ITool tool)
        {

        }
    }
}
