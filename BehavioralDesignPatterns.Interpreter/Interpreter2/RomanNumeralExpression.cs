namespace BehavioralDesignPatterns.Interpreter.Interpreter2;

public abstract class RomanNumeralExpression
{
    public abstract string One();
    public abstract string Four();
    public abstract string Five();
    public abstract string Nine();
    public abstract int Multiplier();

    public void Interpret(Context context)
    {
        if (context.Input.Length == 0) return;

        if (context.Input.StartsWith(Nine())) //IX
        {
            context.Output += (9 * Multiplier());
            context.Input = context.Input.Substring(2);
        }
        else if (context.Input.StartsWith(Four()))
        {
            context.Output += (4 * Multiplier()); //IV
            context.Input = context.Input.Substring(2);
        }
        else if (context.Input.StartsWith(Five()))
        {
            context.Output += (5 * Multiplier()); //V
            context.Input = context.Input.Substring(1);
        }
        
        
        while(context.Input.StartsWith(One())) //I
        {
            context.Output += (1 * Multiplier());
            context.Input = context.Input.Substring(1);
        }
    }
}

public class Context
{
    public string Input { get; set; }
    public int Output { get; set; }

    public Context(string input)
    {
        Input = input;
        Output = 0;
    }
}

public class OneExpression : RomanNumeralExpression
{
    public override string One() => "I";
    public override string Four() => "IV";
    public override string Five() => "V";
    public override string Nine() => "IX";
    public override int Multiplier() => 1;

}

public class TenExpression : RomanNumeralExpression
{
    public override string One() => "X";
    public override string Four() => "XL";
    public override string Five() => "L";
    public override string Nine() => "XC";
    public override int Multiplier() => 10;
}

public class HundredExpression : RomanNumeralExpression
{
    public override string One() => "C";
    public override string Four() => "CD";
    public override string Five() => "D";
    public override string Nine() => "CM";
    public override int Multiplier() => 100;
}

public class ThousandExpression : RomanNumeralExpression
{
    public override string One() => "M";
    public override string Four() => " ";
    public override string Five() => " ";
    public override string Nine() => " ";
    public override int Multiplier() => 1000;
}

