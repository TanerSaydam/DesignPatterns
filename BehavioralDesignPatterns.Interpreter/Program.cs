using BehavioralDesignPatterns.Interpreter.Interpreter1;

namespace BehavioralDesignPatterns.Interpreter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Expression leftExpression = new NumberExpression(3);
            Expression rightExpression = new NumberExpression(5);
            Expression addExpression = new AddExpression(leftExpression, rightExpression);

            Context context = new Context();
            int result = addExpression.Interpret(context);

            Console.WriteLine($"Sonuç: {result}");


            Console.ReadLine();
        }
    }
}