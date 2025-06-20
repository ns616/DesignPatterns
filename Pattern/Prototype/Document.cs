namespace DesignPatternsDemo.Prototype
{
    /// <summary>
    /// Concrete prototype for a document.
    /// </summary>
    public class Document : IPrototype<Document>
    {
        public string Content { get; set; }
        public Document(string content) { Content = content; }
        public Document Clone() => new Document(Content);
    }
}
