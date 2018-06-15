using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shortCircuiting
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;int b = 10;bool check;
            check = a>0 || b>0;
            Console.WriteLine(check);

            bool x = true;
            check = x || GetB() > 0; //short circuited OR GetB wont be called

            Console.WriteLine(check);


            x = true; bool y = (a > 0);
            check = x && y;
            Console.WriteLine(check);

            x = false;
            check = x && GetY();  //short circuit AND GETY wont be called
            Console.WriteLine(check);

            //XOR  can not be shortcircuited
        }

        private static int GetB()
        {
            return 100;
        }

        private static bool GetY()
        {
            return 9>0;
        }
    }
}
