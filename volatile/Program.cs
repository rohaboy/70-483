using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace volatile1
{
    class Program
    {
        private static volatile int some = 10;
        static void Main(string[] args)
        {

            Console.WriteLine(some);

        }
    }
}
