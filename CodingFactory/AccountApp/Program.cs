using AccountApp.Exceptions;
using AccountApp.Model;

namespace AccountApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account warrenBuffet = new Account();

            warrenBuffet.Id = 1;
            warrenBuffet.Iban = "US123456";
            warrenBuffet.Firstname = "Warren";
            warrenBuffet.Lastname = "Buffet";
            warrenBuffet.Ssn = "123456";
            warrenBuffet.Balance = 100_000;

            try
            {
                warrenBuffet.Deposit(100.5M);
                Console.WriteLine(warrenBuffet);

                warrenBuffet.Withdraw(500, "123456");
                Console.WriteLine(warrenBuffet);

                Console.WriteLine(warrenBuffet.GetBalance());
            } catch (NegativeAmountException ex)
            {
                Console.WriteLine(ex.Message);
            } catch (InvalidSSNException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}