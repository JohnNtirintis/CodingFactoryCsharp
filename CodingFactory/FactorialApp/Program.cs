using System.Numerics;

namespace FactorialApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigInteger facto50 = Facto(50);
            Console.WriteLine($"{facto50:N0}");

            int facto25 = recursiveFacto(25);
            Console.WriteLine(facto25);
        }

        public static BigInteger Facto(int n )
        {
            BigInteger result = 1;
            for(int i = 1; i <= n; i++) 
            {
                result *= i; 
            }
            return result; 
        }

        public static int recursiveFacto(int n)
        {
            if(n == 1)
            {
                return 1;
            }

            return n * recursiveFacto(n - 1);
        }
    }
}