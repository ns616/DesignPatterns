namespace DesignPatternsDemo.Bridge
{
    /// <summary>
    /// Refined abstraction for circles.
    /// </summary>
    public class Circle : Shape
    {
        private double _x, _y, _radius;
        public Circle(double x, double y, double radius, IDrawingImplementation drawingImpl)
            : base(drawingImpl)
        {
            _x = x; _y = y; _radius = radius;
        }
        public override void Draw()
        {
            _drawingImpl.DrawCircle(_x, _y, _radius);
        }
    }
}
