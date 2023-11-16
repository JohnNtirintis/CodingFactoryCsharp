using System.Net.Http.Headers;

namespace CollectionsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var linkedList = new LinkedList<string>();
            var elem1 = linkedList.AddFirst("Coding");
            var elem2 = linkedList.AddBefore(elem1, "Hello");
            var elem3 = linkedList.AddAfter(elem1, "Factory");
            var elem4 = linkedList.AddAfter(elem3, "AUEB");


            // Nav to lst
            linkedList.Last!.Previous!.Previous!.Value = "Test1";
            linkedList.First!.Next!.Next!.Value = "test2";

            foreach(string word in linkedList)
            {
                Console.WriteLine(word);
            }

            var lst = new List<int>();
            lst.Add(1);
            lst.AddRange(new[] { 1, 2, 3, 4, 5 });
            lst.Insert(index: 0, item: 24);
            lst.RemoveAt(index: 4);
            lst.Remove(item: 5);
            lst.RemoveRange(index: 2, count: 3);
            lst.Reverse();
            lst.Sort();

            bool isTwentyFourExists = lst.Contains(24);
            int secondListItem = lst[1];

            Console.WriteLine(isTwentyFourExists);
            Console.WriteLine(secondListItem);

            // FIFO
            var queue = new Queue<string>();
            queue.Enqueue("Car: 1");
            queue.Enqueue("Car: 2");
            queue.Enqueue("Car: 3");

            var topValue = queue.Peek();
            Console.WriteLine(topValue);

            var topItem = queue.Dequeue();
            Console.WriteLine(topItem);

            foreach(string element in queue)
            {
                Console.WriteLine(element);
            }

            // LIFO
            var stack = new Stack<string>();
            stack.Push("Stack: 1");
            stack.Push("Stack: 2");
            stack.Push("Stack: 3");

            var topElem = stack.Peek();
            Console.WriteLine(topElem);

            var popElem = stack.Pop();
            Console.Write("Popping element: ");
            Console.WriteLine(popElem);

            foreach(string element in stack)
            {
                Console.WriteLine(element + " ");
            }

            // Set - No Duplicates
            var s1 = new SortedSet<char>() { 'F', 'T', 'c', 'd', 'e', 'o', 'd', 'a' };
            var s2 = new SortedSet<char>() { 'F', 'A', 'C', 'T', 'O', 'R', 'Y' };

            s1.Remove('s');
            s1.Add('4');

            // Adds the mutual values
            s1.Union(s2);

            // Skips mutual values
            s1.ExceptWith(s2);

            foreach (char c in s1) Console.Write(c + " ");

            // Collection Initi
            var nums = new List<int> { 1, 2, 3, 4, 5, 6 };
            var dict = new Dictionary<int, string>() { { 1, "Alice" }, {2, "Bob" } } ;


            List<Product> products = new List<Product>()
            {
                new Product {Description = "Milk", Price = 2M, Quantity = 10},
                new Product {Description = "Apples", Price = 1.5M, Quantity = 100},
                new Product {Description = "Oranges", Price = 55M, Quantity = 150}
            };

            products.Sort();

            products.ForEach(p => Console.WriteLine(p));

            products.Sort((p1, p2) => p1.Quantity.CompareTo(p2.Quantity));
            products.ForEach(p => Console.WriteLine(p));

        }
    }
}