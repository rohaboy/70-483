using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambdaExpressions
{
    class Program
    {
        public delegate int Calculate(int a, int b);

        static void Main(string[] args)
        {
            Calculate calc = (x, y) => { return x + y; };
            Console.WriteLine(calc(10, 20));

            Console.ReadKey();
        }
    }
}
