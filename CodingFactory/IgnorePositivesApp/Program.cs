namespace IgnorePositivesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int count = 0;
            // The scope of init a var in an If is global
            if (!int.TryParse(args[0], out int num))
            {
                Console.WriteLine($"Error! Invalid user input.");
                Environment.Exit(1);
            }

            while (num != 0) {

                if (num < 0) count++;
                Console.WriteLine("Please enter a num.");
                if (!int.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine($"Error in num.");
                    break;
                }
            }

            Console.WriteLine($"Negatives count: ${count}");
        }

    }


}