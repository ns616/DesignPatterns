namespace DesignPatternsDemo.Proxy
{
    /// <summary>
    /// Real subject for loading and displaying an image.
    /// </summary>
    public class RealImage : IImage
    {
        private readonly string _filename;
        public RealImage(string filename)
        {
            _filename = filename;
            Console.WriteLine($"[Proxy] Loading image: {_filename}");
        }
        public void Display()
        {
            Console.WriteLine($"[Proxy] Displaying image: {_filename}");
        }
    }
}
