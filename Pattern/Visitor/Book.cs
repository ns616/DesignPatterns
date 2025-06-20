namespace DesignPatternsDemo.Visitor
{
    /// <summary>
    /// Concrete element: Book.
    /// </summary>
    public class Book : IElement
    {
        public string Title { get; }
        public Book(string title) { Title = title; }
        public void Accept(IVisitor visitor) => visitor.Visit(this);
    }
}
