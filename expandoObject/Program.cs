using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expandoObject
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic myObject = new ExpandoObject();

            myObject.Name = "Nilesh";

            Console.WriteLine(myObject.Name);

            Console.ReadKey();
        }
    }
}
