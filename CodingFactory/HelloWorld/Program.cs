using System;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            testClass();
        }
        
        static int testClass()
        {
            Console.WriteLine("Hello world, from another class!");
            return 0;
        }
    }
}
