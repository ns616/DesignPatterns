namespace DesignPatternsDemo.Interpreter
{
    /// <summary>
    /// Abstract expression for interpreter pattern.
    /// </summary>
    public abstract class Expression
    {
        public abstract int Interpret(Dictionary<string, int> context);
    }
}
