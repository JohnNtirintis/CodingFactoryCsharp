namespace ArrayUtilApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4};
            int[] arrCopy = new int[arr.Length];
            int[] arrCopy2 = new int[arr.Length];

            int length = arr.Length;

            Array.Copy(arr,arrCopy, length);

            foreach (int i  in arrCopy)
            {
                Console.Write(i + " ");
            }

            Array.Copy(arr, 1, arrCopy2, 0, length);
            foreach(int i in arrCopy2)
            {
                Console.Write(i + " ");
            }
        }
    }
}