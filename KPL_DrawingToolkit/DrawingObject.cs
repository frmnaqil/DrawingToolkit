using KPL_DrawingToolkit.States;
using System;
using System.Drawing;
using System.Diagnostics;

namespace KPL_DrawingToolkit
{
    public abstract class DrawingObject
    {
        public Guid IDObject { get; set; }
        public Graphics Graphics { get; set; }

        private DrawingState state;

        public DrawingState State => this.state;

        public DrawingObject()
        {
            IDObject = Guid.NewGuid();
            this.ChangeState(PreviewState.GetInstance());
        }

        public abstract bool Intersect(int xTest, int yTest);
        public abstract void Translate(int x, int y, int xAmount, int yAmount);

        public abstract void RenderOnPreview();
        public abstract void RenderOnEditingView();
        public abstract void RenderOnStaticView();

        public void ChangeState(DrawingState state)
        {
            this.state = state;
        }

        public virtual void Draw()
        {
            this.state.Draw(this);
        }

        public void Select()
        {
            Debug.WriteLine("Object ID : " + IDObject.ToString() + "is selected");
            this.state.Select(this);
        }

        public void Deselect()
        {
            Debug.WriteLine("Object ID : " + IDObject.ToString() + "is deselected");
            this.state.Deselect(this);
        }

        public abstract void DrawGradient();
    }
}
