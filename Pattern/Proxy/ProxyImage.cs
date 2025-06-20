namespace DesignPatternsDemo.Proxy
{
    /// <summary>
    /// Proxy for lazy-loading an image.
    /// </summary>
    public class ProxyImage : IImage
    {
        private RealImage _realImage;
        private readonly string _filename;
        public ProxyImage(string filename)
        {
            _filename = filename;
        }
        public void Display()
        {
            if (_realImage == null)
                _realImage = new RealImage(_filename);
            _realImage.Display();
        }
    }
}
