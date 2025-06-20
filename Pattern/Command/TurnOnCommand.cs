namespace DesignPatternsDemo.Command
{
    /// <summary>
    /// Concrete command to turn on the light.
    /// </summary>
    public class TurnOnCommand : ICommand
    {
        private readonly Light _light;
        public TurnOnCommand(Light light) { _light = light; }
        public void Execute() => _light.TurnOn();
    }
}
