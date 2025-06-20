namespace DesignPatternsDemo.Interpreter
{
    /// <summary>
    /// Non-terminal expression for addition.
    /// </summary>
    public class AddExpression : Expression
    {
        private readonly Expression _left, _right;
        public AddExpression(Expression left, Expression right)
        {
            _left = left; _right = right;
        }
        public override int Interpret(Dictionary<string, int> context)
        {
            return _left.Interpret(context) + _right.Interpret(context);
        }
    }
}
