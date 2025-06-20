namespace DesignPatternsDemo.Interpreter
{
    /// <summary>
    /// Terminal expression for variables.
    /// </summary>
    public class VariableExpression : Expression
    {
        private readonly string _name;
        public VariableExpression(string name) { _name = name; }
        public override int Interpret(Dictionary<string, int> context)
        {
            return context[_name];
        }
    }
}
