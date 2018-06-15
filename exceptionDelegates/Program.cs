using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionDelegates
{
    class Program
    {
        public class Pub
        {
            public event EventHandler OnChange = delegate { };

            public void Raise()
            {
                OnChange(this, EventArgs.Empty);
            }
        }

        static void Main(string[] args)
        {
            CreateAndRaise();


            Console.ReadKey();   
        }

        public static void CreateAndRaise()
        {
            Pub p = new Pub();

            p.OnChange += (sender, e) => Console.WriteLine("Subscribed 1 called");

            p.OnChange += (sender, e) => { throw new Exception(); };

            p.OnChange += (sender, e) => Console.WriteLine("Subscriber 2 called");

            p.Raise();
        }
    }
}
