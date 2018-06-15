using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace instanceField
{
    public class MyClass
    {
        public string MyInstanceField;

        public string Concatenate(string valueToAppend)
        {
            return MyInstanceField + valueToAppend;
        }
    }

    class Program
    {
        
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            mc.MyInstanceField = "Some New Value";


            Console.WriteLine(mc.Concatenate(" Hello !"));


            Console.ReadKey();
        }
    }
}
