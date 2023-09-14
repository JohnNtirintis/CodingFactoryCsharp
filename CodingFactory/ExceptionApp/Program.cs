namespace ExceptionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            while (true)
            {
                try
                {
                    Console.WriteLine("Please insert a num");
                    num = int.Parse(Console.ReadLine()!);
                    Console.WriteLine($"You inserted {num}");
                    if (num == 0) break;

                } catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}