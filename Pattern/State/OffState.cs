namespace DesignPatternsDemo.State
{
    /// <summary>
    /// Concrete state: OFF.
    /// </summary>
    public class OffState : ISwitchState
    {
        public void Handle(Switch sw)
        {
            Console.WriteLine("[State] Turning ON");
            sw.SetState(new OnState());
        }
    }
}
