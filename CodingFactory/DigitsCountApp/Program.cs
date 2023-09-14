namespace DigitsCountApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1234;
            int temp = num;
            int digitsCount = 0;

            do
            {
                temp /= 10;
                digitsCount++;

            } while (temp != 0);

            Console.WriteLine($"{num} has in total {digitsCount} digits.");
        }
    }
}