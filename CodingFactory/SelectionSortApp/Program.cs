namespace SelectionSortApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 44, 77, 24, 33, 3, 4, 7, 31, 68, 25 };
            int min;
            int minPosition = 0;
            int tmp;

            for(int i = 0; i < arr.Length - 1; i++)
            {
                min = int.MaxValue;
                for(int j = i; j < arr.Length; j++)
                {
                    // find min value of subarray
                    if (arr[j] < min)
                    {
                        min = arr[j];
                        minPosition = j;
                    }

                    // swap
                    tmp = arr[i];
                    arr[i] = arr[minPosition];
                    arr[minPosition] = tmp;
                }
            }

            foreach(int item in arr)
            {
                Console.Write(item + " ");
            }
        }
    }
}