namespace DesignPatternsDemo.Command
{
    /// <summary>
    /// Concrete command to turn off the light.
    /// </summary>
    public class TurnOffCommand : ICommand
    {
        private readonly Light _light;
        public TurnOffCommand(Light light) { _light = light; }
        public void Execute() => _light.TurnOff();
    }
}
