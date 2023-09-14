namespace StringsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1;
            string? s2;
            string s3 = "AUEB";
            string s4 = "AUEB"; // intern, must be immutable because it points to the same position in memory as s3
            string s5 = new string("AUEB"); // doesnt intern, points to different point in memory.
            string s6 = new("AUEB"); // doesnt intern, points to different point in memory.
            string s7 = string.Intern("AUEB");
            string s8 = "UoA";

            bool areEqual = s3 == s5; //overloaded operator of equals
            bool areEqual2 = s3.Equals(s5);

            Console.WriteLine(areEqual);
            Console.WriteLine(areEqual2);

            bool areReferencesEqual = ReferenceEquals(s3, s5);
            Console.WriteLine(areReferencesEqual);

            Console.WriteLine($"{string.Compare(s3, s8)}");
            Console.WriteLine($"{s3.CompareTo(s8)}");

            string s9 = s3 + " " + s8;

            string pass1 = " !  ! myPass $";
            string pass2 = "MYPASS";
            if(pass1.ToUpper() == pass2.ToUpper())
            {
                Console.WriteLine("String are CI equal");
            }

            string cf = "Coding Factory";
            int index = cf.IndexOf("Coding");
            index = cf.IndexOf("o"); // 1
            index = cf.IndexOf("o", 2); // 11

            string path = "C:\\tmp\\myphoto.png";
            string filename = path.Substring(7, 7); /// start index , length (can be empty)
            Console.WriteLine(filename);

            cf.Trim();

            
            char[] trimChars= { '*', '!' };
            string trimmedPass1 = pass1.Trim(trimChars);

        }
    }
}