namespace DesignPatternsDemo.Facade
{
    /// <summary>
    /// Facade class to simplify home theater usage.
    /// </summary>
    public class HomeTheaterFacade
    {
        private readonly AudioSystem _audio = new();
        private readonly VideoSystem _video = new();
        public void WatchMovie()
        {
            _audio.On();
            _video.On();
            Console.WriteLine("[Facade] Movie started!");
        }
        public void EndMovie()
        {
            _audio.Off();
            _video.Off();
            Console.WriteLine("[Facade] Movie ended!");
        }
    }
}
