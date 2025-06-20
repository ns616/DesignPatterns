namespace DesignPatternsDemo.Visitor
{
    /// <summary>
    /// Visitor interface for elements.
    /// </summary>
    public interface IVisitor
    {
        void Visit(Book book);
        void Visit(Pen pen);
    }
}
