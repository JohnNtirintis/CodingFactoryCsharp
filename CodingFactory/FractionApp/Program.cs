using FractionApp.Model;

namespace FractionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Fraction fraction1 = new Fraction
                {
                    Numerator = 1,
                    Denominator = 2,
                };

                Fraction fraction2 = new Fraction
                {
                    Numerator = 2,
                    Denominator = 4,
                };

                Console.WriteLine(fraction1);
                Console.WriteLine(fraction2);

                Fraction result = fraction1 + fraction2;
                Console.WriteLine(result);

                result = fraction1 - fraction2;
                Console.WriteLine(result);

                result = fraction1 * fraction2;
                Console.WriteLine(result);

                result = fraction1 / fraction2;
                Console.WriteLine(result);
            } catch (DivideByZeroException e)
            {
                Console.WriteLine("Error: ", e.Message);
            } catch (ArgumentException e)
            {
                Console.WriteLine("Error: " ,   e.Message);
            }
            
        }
    }
}