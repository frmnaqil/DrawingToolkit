using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPL_DrawingToolkit
{
    public interface IEditor
    {
        IToolbox Toolbox { get; set; }
        void AddCanvas(ICanvas canvas);
        ICanvas GetSelectedCanvas();
        void RemoveCanvas(ICanvas canvas);
        void RemoveSelectedCanvas();
    }
}
