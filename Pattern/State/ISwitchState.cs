namespace DesignPatternsDemo.State
{
    /// <summary>
    /// State interface for a simple switch.
    /// </summary>
    public interface ISwitchState
    {
        void Handle(Switch sw);
    }
}
