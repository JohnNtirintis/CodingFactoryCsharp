using AccountApp.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp.Model
{
    internal class Account
    {
        public long Id { get; set; }
        public string? Iban { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public string? Ssn { get; set; }
        public decimal Balance { get; set; }

        public void Deposit(decimal amount)
        {
            try
            {
                if (amount <= 0)
                {
                    throw new NegativeAmountException("Negative Amount");
                }

                Balance += amount;
            } catch (NegativeAmountException e )
            {
                Console.Error.WriteLine(e.Message);
                throw;
            }   
        }

        public void Withdraw(decimal amount, string ssn)
        {
            decimal balance = GetBalance();

            try
            {
                if (string.IsNullOrEmpty(ssn)) throw new InvalidSSNException("Empty or Null String error.");
                if (!IsSsnValid(ssn)) throw new InvalidSSNException($"{ssn} is not valid.");
                if (amount < 0) throw new NegativeAmountException("Error! Negative amount is not permitted!");

                Balance -= amount;
            } catch(InvalidSSNException e)
            {
                Console.Error.WriteLine($"{ssn}: {e.Message}");
                throw;
            } catch (NegativeAmountException e)
            {
                Console.Error.WriteLine($"Error! Negative amount: {e.Message}");
                throw;
            }

            
        }

        public decimal GetBalance()
        {
            return Balance;
        }

        private bool IsSsnValid(string ssn) 
        {
            return string.Equals(Ssn, ssn);
        }

        public override string? ToString()
        {
            return $"{Id}, {Iban}, {Firstname}, {Lastname}, {Ssn}, {Balance} ";
        }
    }
}
