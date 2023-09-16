namespace PrimeNumbersApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
                
        }

        public static bool OptimisedIsPrime(int n)
        {
            if (n < 2) return false; 
            if (n == 2) return true; 
            if (n % 2 == 0) return false; 

            int maxDivider = (int)Math.Sqrt(n);

            for (int divider = 3; divider <= maxDivider; divider += 2)
            {
                if (n % divider == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static bool IsPrime(int n)
        {
            int divider = 2;
            int maxDivider = (int)Math.Sqrt(n);
            bool isPrime = true;

            while (isPrime && divider <= maxDivider)
            {
                if(n % divider == 0)
                {
                    isPrime = false;    
                }

                divider++;
            }

            return isPrime;
        }
    }
}