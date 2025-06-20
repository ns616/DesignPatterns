namespace DesignPatternsDemo.Bridge
{
    /// <summary>
    /// Implementor interface for drawing shapes.
    /// </summary>
    public interface IDrawingImplementation
    {
        void DrawCircle(double x, double y, double radius);
    }
}
