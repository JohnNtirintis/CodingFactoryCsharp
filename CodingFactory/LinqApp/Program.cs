using LinqApp.Model;
using System.Threading.Channels;
using System.Threading.Tasks.Sources;

namespace LinqApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get Data Source
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12};

            //IEnumerable<int>
            // Create Query
            var allNumbers = from num in numbers select num; 

            // Execute Query
            foreach(int num in allNumbers)
            {
                Console.WriteLine(num + " ");
            }
            Console.WriteLine();

            var oddNumbers = from num in numbers where num % 2 != 0 select num;
            
            foreach (int num in oddNumbers)
            {
                Console.Write(num + " ");
            }

            List<int> evensList = (from num in numbers 
                                  where (num % 2) == 0
                                  orderby num descending
                                  select num).ToList();

            evensList.ForEach(num => Console.WriteLine(num));

            var evensArr = (from num in numbers
                            where (num % 2) == 0
                            orderby num descending
                            select num).ToArray();

            foreach(var num in evensArr)
            {
                Console.WriteLine(num + " ") ;
            }


            List<Student> students = new() {
                new() { Id = 1, Firstname = "Fernando", Lastname = "Alonso"},
                new() {Id = 2, Firstname = "Daniel", Lastname = "Ricciardo"},
                new() {Id = 3, Firstname = "Oscar", Lastname = "Piastri"}
            };

            var studetsByLastName = from student in students
                                    group student by student.Lastname into studentGroup
                                    orderby studentGroup.Key
                                    select studentGroup;

            Console.WriteLine();
            Console.WriteLine();

            foreach (var studentGroup in studetsByLastName)
            {
                Console.Write(" " + studentGroup.Key);
                foreach(var student  in studentGroup)
                {
                    Console.Write($"\t {student.Firstname}");
                }
            }
        }
    }
}