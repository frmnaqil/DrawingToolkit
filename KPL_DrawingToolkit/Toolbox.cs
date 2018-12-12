using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace KPL_DrawingToolkit
{
    public class Toolbox : ToolStrip, IToolbox
    {
        private ITool activeTool;

        public ITool ActiveTool => this.activeTool;

        public event ToolSelectedEventHandler ToolSelected;

        public void AddTool(ITool tool)
        {
            Debug.WriteLine(tool.Name + " is added into Toolbox");

            if (tool is ToolStripButton toggleButton)
            {
                if (toggleButton.CheckOnClick)
                {
                    toggleButton.CheckedChanged += ToggleButton_CheckedChanged;
                }

                this.Items.Add(toggleButton);
            }
        }

        private void ToggleButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is ToolStripButton button)
            {
                if (button.Checked)
                {
                    if (button is ITool)
                    {
                        this.activeTool = (ITool)button;
                        Debug.WriteLine(this.activeTool + "is selected");

                        if (ToolSelected != null)
                        {
                            ToolSelected(this.activeTool);
                        }

                        ToggleButton_UncheckInactive();
                    }
                    else
                    {
                        throw new InvalidCastException("The tool is not an instance of Tool");
                    }
                }
            }
        }

        private void ToggleButton_UncheckInactive()
        {
            foreach (ToolStripItem item in this.Items)
            {
                if (item != this.activeTool)
                {
                    ((ToolStripButton)item).Checked = false;
                }
            }
        }

        public void RemoveTool(ITool tool)
        {
            foreach (ToolStripItem i in this.Items)
            {
                if (i is ITool)
                {
                    if (i.Equals(tool))
                    {
                        this.Items.Remove(i);
                    }
                }
            }
        }
    }
}
