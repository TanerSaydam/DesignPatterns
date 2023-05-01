namespace BehavioralDesignPatterns.Interpreter.Interpreter1;

//Abstract Expression
public abstract class Expression
{
    public abstract int Interpret(Context context);
}

public class Context
{
    //Dilbilgisi ve giriş verileri yazılabilir
}

//Terminal Expression
public class NumberExpression : Expression
{
    private readonly int _number;

    public NumberExpression(int number)
    {
        _number = number;
    }

    public override int Interpret(Context context)
    {
        return _number;
    }
}

//Non Terminal Expression
public class AddExpression : Expression
{
    private readonly Expression _leftExpression;
    private readonly Expression _rightExpression;

    public AddExpression(Expression leftExpression, Expression rightExpression)
    {
        _leftExpression = leftExpression;
        _rightExpression = rightExpression;
    }

    public override int Interpret(Context context)
    {
        return _leftExpression.Interpret(context) + _rightExpression.Interpret(context);
    }
}
