using System;

namespace ExpressionsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1, num2 = 2;
            int result1 = 0;
            int sum, mul, div, mod, result2, result3;

            sum = num1 + num2;

            result1 += sum;

            result1++;

            result2 = (result1 >= 4) ? 1 : 0;

            result3 = Math.Abs(result2);



        }
    }
}
