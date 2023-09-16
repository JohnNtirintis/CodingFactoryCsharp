namespace OverloadingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result1 = Add(1,2,3);
            int result2 = Add(5,3,4,6);

            Console.WriteLine(result1);
            Console.WriteLine(result2);

            DateTime dt1 = getDateTime();
            DateTime dt2 = getDateTime(year: 2000, month: 10, day: 30);

            Console.WriteLine(dt1);
            Console.WriteLine(dt2);
        }

        public static int Add(params int[] numms)
        {
            int sum = 0;
            foreach(int i in numms)
            {
                sum += i;
            }

            return sum; 
        }

        public static DateTime getDateTime(int year=1970, int month=1, int day = 1, int hour=0, int min=0, int sec=0, int milSec = 0)
        {

            return new DateTime(year, month, day, hour, min, sec, milSec, DateTimeKind.Utc);
        }
        
        public static double mul(int a, double d)
        {
            return a * d;
        }

        // Overloaded
        public static double mul(double a, double b)
        {
            return a * b;
        }
    }
}