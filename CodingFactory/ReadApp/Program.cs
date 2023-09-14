using System;

namespace ReadApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, sum;
            Console.WriteLine("Please insert two ints");

            num1 = int.Parse(Console.ReadLine()!);
            num2 = int.Parse(Console.ReadLine()!);

            sum = num1 + num2;

            Console.WriteLine($"The sum is: {sum}");
        }
    }
}
