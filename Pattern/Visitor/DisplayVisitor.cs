namespace DesignPatternsDemo.Visitor
{
    /// <summary>
    /// Concrete visitor for displaying items.
    /// </summary>
    public class DisplayVisitor : IVisitor
    {
        public void Visit(Book book) => Console.WriteLine($"[Visitor] Book: {book.Title}");
        public void Visit(Pen pen) => Console.WriteLine($"[Visitor] Pen: {pen.Color}");
    }
}
