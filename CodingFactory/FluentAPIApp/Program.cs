namespace FluentAPIApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {1,2,3,4,5,6,7};

            var allItems = numbers.Select(num => num);

            foreach (int num in allItems)
            {
                Console.Write(num + " ");
            }

            var oddItems = numbers.Where(num => num % 2 != 0).Select(num => num);

            foreach (int num in oddItems)
            {
                Console.Write(num + " ");
            }

            List<int> evensToList = numbers.Where(num => num % 2 == 0).Select(num => num).ToList();
            int[] evensToArray = numbers.Where(num => num % 2 == 0).Select(num => num).ToArray();

            evensToList.ForEach(num => Console.Write(num + " "));

            foreach (int num in evensToArray)
            {
                Console.Write(num + " ");
            }
        }
    }
}