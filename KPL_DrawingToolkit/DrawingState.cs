namespace KPL_DrawingToolkit
{
    public abstract class DrawingState
    {
        public DrawingState State
        {
            get
            {
                return this.state;
            }
        }

        private DrawingState state;

        public abstract void Draw(DrawingObject obj);

        public virtual void Deselect(DrawingObject obj)
        {
            
        }

        public virtual void Select(DrawingObject obj)
        {

        }
    }
}