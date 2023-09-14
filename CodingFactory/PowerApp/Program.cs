using System.Numerics;

namespace PowerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 2; 
            int b = 3;
            BigInteger result = 1;

            for(int i = 0; i < b; i++)
            {
                result *= a;
            }

            Console.WriteLine($"{a} ^ {b} = {result}");
        }
    }
}