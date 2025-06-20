namespace DesignPatternsDemo.State
{
    /// <summary>
    /// Context class for the switch.
    /// </summary>
    public class Switch
    {
        private ISwitchState _state;
        public Switch(ISwitchState state) { _state = state; }
        public void SetState(ISwitchState state) { _state = state; }
        public void Press() { _state.Handle(this); }
    }
}
