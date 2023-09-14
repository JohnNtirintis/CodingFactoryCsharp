namespace ForApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cities = new string[] {"Athens", "Berlin", "London", "Milan", "Rome" };

            for(int i = 0; i < cities.Length; i++)
            {
                Console.WriteLine(cities[i]);
            }

            foreach(string city in cities)
            {
                Console.WriteLine(city);
            }
        }
    }
}