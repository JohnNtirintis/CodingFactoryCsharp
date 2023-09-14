using System;

namespace NullableApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? i = null;
            Console.WriteLine("i = {0} ", (i == null) ? "null" : "not null"); ;
        }
    }
}
