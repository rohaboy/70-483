using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implicitExplicitConversion
{
    class Money
    {
        public decimal Amount { get; set; }

        public Money(decimal amount)
        {
            Amount = amount;
        }

        public static implicit operator decimal(Money money)
        {
            return money.Amount;
        }

        public static explicit operator int(Money money)
        {
            return (int)money.Amount;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Money m = new Money(42.42M);
            decimal amount = m; //implicit converion
            int truncatedAmount = (int)m; //explicit


            Console.WriteLine("Implicitly converted Money to Decimal {0}", amount);
            Console.WriteLine("Implicitly converted Money to Integer {0}", truncatedAmount); //loss of data

            Console.ReadKey();
        }
    }
}
