using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiCastDelegate
{
    class Program
    {
        public static void MethodOne()
        {
            Console.WriteLine("Method 1");
        }

        public static void MethodTwo()
        {
            Console.WriteLine("Method 2");
        }

        public static void MethodThree()
        {
            Console.WriteLine("Method 3");
        }

        public delegate void Del();

        static void Main(string[] args)
        {
            Del d = MethodOne;

            d += MethodTwo;
            d += MethodThree;

            d -= MethodOne; //One will be removed

            //Find How many methods delegate gonna call
            int methodCount = d.GetInvocationList().Count();
            Console.WriteLine("Delegate will call {0} methods", methodCount);

            d();


            Console.ReadLine();
        }
    }
}
