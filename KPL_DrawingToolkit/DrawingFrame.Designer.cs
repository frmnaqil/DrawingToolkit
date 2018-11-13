namespace KPL_DrawingToolkit
{
    partial class DrawingFrame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lineTool = new System.Windows.Forms.ToolStripButton();
            this.drawingCanvas = new System.Windows.Forms.Panel();
            this.circleTool = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lineTool,
            this.circleTool});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lineTool
            // 
            this.lineTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lineTool.Image = global::KPL_DrawingToolkit.Properties.Resources.Line;
            this.lineTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lineTool.Name = "lineTool";
            this.lineTool.Size = new System.Drawing.Size(23, 22);
            this.lineTool.Text = "toolStripButton1";
            this.lineTool.Click += new System.EventHandler(this.lineTool_Click);
            // 
            // drawingCanvas
            // 
            this.drawingCanvas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.drawingCanvas.Location = new System.Drawing.Point(0, 28);
            this.drawingCanvas.Name = "drawingCanvas";
            this.drawingCanvas.Size = new System.Drawing.Size(784, 533);
            this.drawingCanvas.TabIndex = 1;
            this.drawingCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.drawingCanvas_Paint);
            this.drawingCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawingCanvas_MouseDown);
            this.drawingCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawingCanvas_MouseUp);
            // 
            // circleTool
            // 
            this.circleTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.circleTool.Image = global::KPL_DrawingToolkit.Properties.Resources.Circle;
            this.circleTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.circleTool.Name = "circleTool";
            this.circleTool.Size = new System.Drawing.Size(23, 22);
            this.circleTool.Text = "toolStripButton2";
            this.circleTool.Click += new System.EventHandler(this.circleTool_Click);
            // 
            // DrawingFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.drawingCanvas);
            this.Controls.Add(this.toolStrip1);
            this.Name = "DrawingFrame";
            this.Text = "Simple Drawing Toolkit";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton lineTool;
        private System.Windows.Forms.Panel drawingCanvas;
        private System.Windows.Forms.ToolStripButton circleTool;
    }
}

