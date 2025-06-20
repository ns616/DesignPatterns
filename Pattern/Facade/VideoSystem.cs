namespace DesignPatternsDemo.Facade
{
    /// <summary>
    /// Subsystem class for video.
    /// </summary>
    public class VideoSystem
    {
        public void On() => Console.WriteLine("[Facade] Video system ON");
        public void Off() => Console.WriteLine("[Facade] Video system OFF");
    }
}
