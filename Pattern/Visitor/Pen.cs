namespace DesignPatternsDemo.Visitor
{
    /// <summary>
    /// Concrete element: Pen.
    /// </summary>
    public class Pen : IElement
    {
        public string Color { get; }
        public Pen(string color) { Color = color; }
        public void Accept(IVisitor visitor) => visitor.Visit(this);
    }
}
