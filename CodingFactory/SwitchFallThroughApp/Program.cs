namespace SwitchFallThroughApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int grade;

            Console.WriteLine("Please enter a grade");
            grade = int.Parse(Console.ReadLine()!);

            switch (grade)
            {
                case 0:

                case 1:
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("Fail");
                    break;
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    Console.WriteLine("Excellent!");
                    break;
                default:
                    Console.WriteLine("Error!");
                    break;

            }
        }
    }
}