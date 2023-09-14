namespace GradesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gradesSum;
            int gradesCount;
            int average;

            Console.WriteLine("Please insert grades sum and grades count");

            if (!int.TryParse(Console.ReadLine(), out gradesSum))
            {
                Console.WriteLine("Error in user input.");
            }

            if (!int.TryParse(Console.ReadLine(), out gradesCount))
            {
                Console.WriteLine("Error in user input.");
            }

            if (gradesCount == 0)
            {
                Console.WriteLine($"Error - Grades count is {gradesCount}");
            }

            average = gradesSum / gradesCount;

            if (average > 10)
            {
                Console.WriteLine($"Average is invalid: {average}");
            }


            Console.WriteLine($"Average = {average}");

            if (average >= 9)
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}