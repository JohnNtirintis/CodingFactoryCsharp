namespace ArraysApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;

            int[] arr2 = {1,2,3,4,5};

            int[] arr3 = new int[] { 1, 2, 3, 4, };

            for(int i = 0; i < arr.Length; i++) 
            {
                Console.WriteLine($"{arr[i]}");
            }

            foreach(int element in arr2)
            {
                Console.WriteLine($"{arr[element]}");
            }
        }
    }
}