using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcAndAction
{
    class Program
    {
        public static int Sum(int a,int b) { return a + b; }

        public static void Greet(string name) { Console.WriteLine("Hello {0}", name); }

        static void Main(string[] args)
        {
            Func<int, int, int> funSum = Sum;
            Action<string> actionGreet = Greet;

            Console.WriteLine(funSum(10, 20));

            actionGreet("Nilesh");


            Console.ReadKey();
                
        }
    }
}
