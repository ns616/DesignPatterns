namespace DesignPatternsDemo.Bridge
{
    /// <summary>
    /// Concrete implementor for vector drawing.
    /// </summary>
    public class VectorDrawing : IDrawingImplementation
    {
        public void DrawCircle(double x, double y, double radius)
        {
            Console.WriteLine($"[Bridge] Drawing vector circle at ({x},{y}) with radius {radius}");
        }
    }
}
