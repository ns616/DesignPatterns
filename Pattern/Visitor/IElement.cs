namespace DesignPatternsDemo.Visitor
{
    /// <summary>
    /// Element interface for accept method.
    /// </summary>
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }
}
