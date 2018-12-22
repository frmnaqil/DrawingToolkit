namespace KPL_DrawingToolkit
{
    public abstract class DrawingState
    {
        private DrawingState state;

        public DrawingState State => this.state;

        public abstract void Draw(DrawingObject obj);

        public virtual void Deselect(DrawingObject obj)
        {
            
        }

        public virtual void Select(DrawingObject obj)
        {

        }
    }
}