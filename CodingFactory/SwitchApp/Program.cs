namespace SwitchApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;

            Console.WriteLine("Please insert choice.");
            choice = int.Parse(Console.ReadLine()!);

            switch(choice)
            {
                case 1:
                    Console.WriteLine("Its 1");
                    break;  
                case 2:
                    Console.WriteLine("Its 2");
                    break;
                default: 
                    Console.WriteLine("its the default option");
                    break;
            }
        }
    }
}