namespace DesignPatternsDemo.Facade
{
    /// <summary>
    /// Subsystem class for audio.
    /// </summary>
    public class AudioSystem
    {
        public void On() => Console.WriteLine("[Facade] Audio system ON");
        public void Off() => Console.WriteLine("[Facade] Audio system OFF");
    }
}
