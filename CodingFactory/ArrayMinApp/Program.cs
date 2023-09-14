namespace ArrayMinApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] prices = { 56, 33, 24, 3, 14 };

            int minPosition = 0;

            for(int i =0; i < prices.Length; i++)
            {
                if (prices[i] < prices[minPosition])
                {
                    minPosition = i;
                }
            }

            Console.WriteLine($"Min price is: {prices[minPosition]} in position {minPosition + 1}");
        }
    }
}