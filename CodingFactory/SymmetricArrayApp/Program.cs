namespace SymmetricArrayApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] symmetricArr = { 1, 2, 3, 2, 1 };
            int[] notSymmetricApp = { 1, 2, 4, 3, 5 };
            bool isSymmetric = true;

           
            for(int i = 0; i < symmetricArr.Length; i++)
            {
                for(int j = symmetricArr.Length - 1; j < i; j--)
                {
                    if (symmetricArr[j] != symmetricArr[i])
                    {
                        isSymmetric = false;
                        break;
                    }
                }
            }
            

            Console.WriteLine(isSymmetric);
        }
    }
}