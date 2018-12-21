﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPL_DrawingToolkit
{
    public delegate void ToolSelectedEventHandler(ITool tool);

    interface IToolbox
    {
        event ToolSelectedEventHandler ToolSelected;
        void AddTool(ITool tool);
        void RemoveTool(ITool tool);
        void AddSeparator();
        ITool ActiveTool { get; }
    }
}
