namespace DesignPatternsDemo.State
{
    /// <summary>
    /// Concrete state: ON.
    /// </summary>
    public class OnState : ISwitchState
    {
        public void Handle(Switch sw)
        {
            Console.WriteLine("[State] Turning OFF");
            sw.SetState(new OffState());
        }
    }
}
