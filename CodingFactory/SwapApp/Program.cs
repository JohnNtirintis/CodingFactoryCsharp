namespace SwapApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5; 
            int y = 24;
            // notice use of "ref" while calling func
            swap1(ref x, ref y);
            Console.WriteLine($"x: {x}, y: {y}");

            string? test = "Coding Factory";
            // notice use of "out" while calling func
            ChangeStr(out test);
            Console.WriteLine(test);
        }

        // ref = reference to the memory location similar to a pointer
        // but a lot more safer. C# manages memory, so we dont have to malloc
        public static void swap1(ref int a, ref int b)
        {
            // int tmp = a;
            // a = b;
            // b = tmp;

            (a, b) = (b, a);
        }

        // out is again a reference to the memory location, but,
        // its a pointer to a str and then a pointer to the actual value (i.e. in c its str**)
        // NOTE: you can also pass null values (you dont have to init the var)
        public static void ChangeStr(out string str)
        {
            str = "CF AUEB";
        }
    }
}