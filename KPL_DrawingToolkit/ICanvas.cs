using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPL_DrawingToolkit
{
    public interface ICanvas
    {
        void SetActiveTool(ITool tool);
        void Repaint();

        void AddDrawingObject(DrawingObject drawingObject);
        void RemoveDrawingObject(DrawingObject drawing);

        DrawingObject GetObjectAt(int x, int y);
        DrawingObject SelectObjectAt(int x, int y);
        void DeselectAllObjects();
    }
}
