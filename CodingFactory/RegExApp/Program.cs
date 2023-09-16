using System.Text.RegularExpressions;

namespace RegExApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string expr;
            string[] tokens;
            int num1;
            int num2;
            string op;
            int result;

            Console.WriteLine("Please insert the expression.");
            expr = Console.ReadLine()!;

            tokens = Regex.Split(expr, "\\s+");
            // tokens = Regex.Split(expr, @"\s+");

            num1 = int.Parse(tokens[0]);
            num2 = int.Parse(tokens[2]);
            op = tokens[1];

            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-": 
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
                case "%":
                    result = num1 % num2;
                    break;
                default:
                    Console.WriteLine("Error! Invalid operator.");
                    break;
            }

            Console.WriteLine($"Result: {result}");
        }
    }
}