namespace BehavioralDesignPatterns.Interpreter.Odev1;

public abstract class Expression
{
    public abstract void Interpret(Context context);
}

public class Context
{
    public string Input { get; set; }
    public int Output { get; set; }
}

public class NumberExpression : Expression
{
    private readonly int _number;

    public NumberExpression(int number)
    {
        _number = number;
    }

    public override void Interpret(Context context)
    {
        context.Output = _number;
    }
}

public abstract class OperatorExpression : Expression
{
    protected Expression Left;
    protected Expression Right;
    protected OperatorExpression(Expression left, Expression right)
    {
        Left = left;
        Right = right;
    }
}

public class AddExpression : OperatorExpression
{
    public AddExpression(Expression left, Expression right) : base(left,right) {}
    public override void Interpret(Context context)
    {
        Left.Interpret(context);
        int leftResult = context.Output;

        Right.Interpret(context);
        int rightResult = context.Output;

        context.Output = leftResult + rightResult;
    }
}

public class SubtractExpression : OperatorExpression
{
    public SubtractExpression(Expression left, Expression right) : base(left, right) { }
    public override void Interpret(Context context)
    {
        Left.Interpret(context);
        int leftResult = context.Output;

        Right.Interpret(context);
        int rightResult = context.Output;

        context.Output = leftResult - rightResult;
    }
}

public class MultiplyExpression : OperatorExpression
{
    public MultiplyExpression(Expression left, Expression right) : base(left, right) { }
    public override void Interpret(Context context)
    {
        Left.Interpret(context);
        int leftResult = context.Output;

        Right.Interpret(context);
        int rightResult = context.Output;

        context.Output = leftResult * rightResult;
    }
}

public class DivideExpression : OperatorExpression
{
    public DivideExpression(Expression left, Expression right) : base(left, right) { }
    public override void Interpret(Context context)
    {
        Left.Interpret(context);
        int leftResult = context.Output;

        Right.Interpret(context);
        int rightResult = context.Output;

        context.Output = leftResult / rightResult;
    }
}