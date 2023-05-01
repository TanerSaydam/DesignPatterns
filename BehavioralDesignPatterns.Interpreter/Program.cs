using BehavioralDesignPatterns.Interpreter.Interpreter1;
using BehavioralDesignPatterns.Interpreter.Interpreter2;

namespace BehavioralDesignPatterns.Interpreter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Expression leftExpression = new NumberExpression(3);
            //Expression rightExpression = new NumberExpression(5);
            //Expression addExpression = new AddExpression(leftExpression, rightExpression);

            //Context context = new Context();
            //int result = addExpression.Interpret(context);

            //Console.WriteLine($"Sonuç: {result}");

            string roman = "MCMXXVIII";
            Interpreter2.Context context = new(roman);
            List<RomanNumeralExpression> tree = new()
            {
                new ThousandExpression(),
                new HundredExpression(),
                new TenExpression(),
                new OneExpression()
            };

            foreach (var exp in tree)
            {
                exp.Interpret(context);
            }

            Console.WriteLine($"{roman} = {context.Output}");
            Console.ReadLine();
        }
    }
}