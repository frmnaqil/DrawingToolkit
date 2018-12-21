using System;
using System.Drawing;

namespace KPL_DrawingToolkit
{
    public abstract class DrawingObject
    {
        public Guid IDObject { get; set; }
        public Graphics Graphics { get; set; }

        public DrawingObject()
        {
            IDObject = Guid.NewGuid();
        }

        public abstract void Draw();
    }
}
