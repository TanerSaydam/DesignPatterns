using BehavioralDesignPatterns.Interpreter.Interpreter1;
using BehavioralDesignPatterns.Interpreter.Interpreter2;
using BehavioralDesignPatterns.Interpreter.Odev1;

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

            //string roman = "MCMXXVIII";
            //Interpreter2.Context context = new(roman);
            //List<RomanNumeralExpression> tree = new()
            //{
            //    new ThousandExpression(),
            //    new HundredExpression(),
            //    new TenExpression(),
            //    new OneExpression()
            //};

            //foreach (var exp in tree)
            //{
            //    exp.Interpret(context);
            //}

            //Console.WriteLine($"{roman} = {context.Output}");

            // 3 + 5 *2 - 4 /2; == 13 - 2;

            Odev1.Expression tree = new Odev1.NumberExpression(3);
            Odev1.Expression five = new Odev1.NumberExpression(5);
            Odev1.Expression two = new Odev1.NumberExpression(2);
            Odev1.Expression four = new Odev1.NumberExpression(4);

            Odev1.Expression multiplication = new MultiplyExpression(five, two);
            Odev1.Expression addition = new Odev1.AddExpression(tree, multiplication);
            Odev1.Expression division = new DivideExpression(four, two);
            Odev1.Expression subtraction = new SubtractExpression(addition, division);

            Odev1.Context context = new();
            subtraction.Interpret(context);

            Console.WriteLine($"3 + 5 * 2 - 4 / 2 = {context.Output}");

            Console.ReadLine();
        }
    }
}