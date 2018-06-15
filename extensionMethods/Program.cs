using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extensionMethods
{
    public class Product
    {
        public decimal Price { get; set; }
    }

    public static class MyExtensions
    {
        public static decimal Discount(this Product product)
        {
            return product.Price * .9M;
        }
    }

    public class Calculator
    {
        public decimal CalculateDiscount(Product p)
        {
            return p.Discount();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a product price:");
            decimal pp = Convert.ToDecimal(Console.ReadLine());

            Product p = new Product();
            p.Price = pp;

            Console.WriteLine(new Calculator().CalculateDiscount(p));

            Console.ReadKey();
        }
    }
}
