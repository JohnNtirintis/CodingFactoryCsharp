using System;

namespace TypecastApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            long longNum = 100_000_000L;
            float myFloat = 19.75f;
            double myDouble = 24.04;
            decimal myDecimal = 170_000M;

            num = (int)longNum;

            Console.WriteLine("{0,20:N0}", num);
            Console.WriteLine($"{num:N2}");
        }
    }
}
