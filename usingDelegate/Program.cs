using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usingDelegate
{
    class Program
    {
        public delegate int Calculate(int a, int b);

        public static int Add(int x,int y) { return x + y; }
        public static int Multiply(int x, int y) { return x * y; }

        static void Main(string[] args)
        {
            Calculate calc = Add;
            Console.WriteLine(calc(3, 4));


            calc = Multiply;
            Console.WriteLine(calc(3, 4));

            Console.ReadKey();

        }
    }
}
