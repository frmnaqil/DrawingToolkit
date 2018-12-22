﻿using System;
using System.Windows.Forms;

namespace KPL_DrawingToolkit
{
    public interface ITool
    {
        String Name { get; set; }
        Cursor Cursor { get; }
        ICanvas Canvas { get; set; }

        void ToolMouseDown(object sender, MouseEventArgs e);
        void ToolMouseUp(object sender, MouseEventArgs e);
        void ToolMouseMove(object sender, MouseEventArgs e);

        void ToolKeyUp(object sender, KeyEventArgs e);
        void ToolKeyDown(object sender, KeyEventArgs e);
        void ToolHotKeysDown(object sender, Keys e);
    }
}
