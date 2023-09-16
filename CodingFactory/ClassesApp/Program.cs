using ClassesApp.Model;

namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student oscar = new Student();
            Student bob = new(); // C# 9.0
            
            var alice = new Student();

            Student fernandoAlonso = new Student() { Id = 14, Firstname = "Fernando", Lastname = "Alonso"};

            Student danielRicciardo = new() { Id = 3, Firstname = "Daniel", Lastname = "Ricciardo" };

            Console.Write(fernandoAlonso.Firstname + ", " + fernandoAlonso.Lastname);
        }
    }
}