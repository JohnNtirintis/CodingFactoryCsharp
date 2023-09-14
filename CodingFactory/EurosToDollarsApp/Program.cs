using System;
using System.Text;

namespace EurosToDollarsApp
{
    /// <summary>
    /// Reads and integer from stdio that represents
    /// an amount of money in euro and converts 
    /// to dollars and cents. We assume that the
    /// parity is: 1 Euro = 1.07 USD.
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            const decimal RATE = 1.7M;
            const int CENTS_PER_DOLLAR = 100;
            decimal dollars;
            decimal cents;
            // decimal inputEuros;

            Console.WriteLine("Please insert the amount of euros.");
            if(!decimal.TryParse(Console.ReadLine(), out decimal inputEuros))
            {
                Console.WriteLine("Error in input");
            }

            dollars = inputEuros * RATE;
            cents = dollars * CENTS_PER_DOLLAR % 100;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine($"\u20AC {inputEuros} equals to \u0024 {dollars:N0}, {cents, 5:N0} cents");
        }
    }
}
