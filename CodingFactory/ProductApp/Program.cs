using System.Numerics;


namespace ProductApp
{
    /// <summary>
    /// Showcases bigint that can store huge nums
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = 100;
            BigInteger result = 1;
            int i = 1;

            while(i <= n)
            {
                result *= i;
                i++;
                Console.WriteLine(result);
            }

            Console.WriteLine($"1 * 2 * ... * n = {result}");
        }
    }
}