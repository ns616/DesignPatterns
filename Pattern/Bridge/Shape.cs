namespace DesignPatternsDemo.Bridge
{
    /// <summary>
    /// Abstraction for shapes.
    /// </summary>
    public abstract class Shape
    {
        protected IDrawingImplementation _drawingImpl;
        protected Shape(IDrawingImplementation drawingImpl)
        {
            _drawingImpl = drawingImpl;
        }
        public abstract void Draw();
    }
}
