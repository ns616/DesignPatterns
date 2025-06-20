namespace DesignPatternsDemo.Bridge
{
    /// <summary>
    /// Concrete implementor for raster drawing.
    /// </summary>
    public class RasterDrawing : IDrawingImplementation
    {
        public void DrawCircle(double x, double y, double radius)
        {
            Console.WriteLine($"[Bridge] Drawing raster circle at ({x},{y}) with radius {radius}");
        }
    }
}
