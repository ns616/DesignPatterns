namespace DesignPatternsDemo.Command
{
    /// <summary>
    /// Receiver class for light operations.
    /// </summary>
    public class Light
    {
        public bool IsOn { get; private set; }
        public void TurnOn()
        {
            IsOn = true;
            Console.WriteLine("[Command] Light turned ON");
        }
        public void TurnOff()
        {
            IsOn = false;
            Console.WriteLine("[Command] Light turned OFF");
        }
    }
}
