using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manuallyRaising
{
    class Program
    {
        public class Pub
        {
            public event EventHandler OnChange = delegate { };
            public void Raise()
            {
                var exceptions = new List<Exception>();

                foreach (Delegate handelr in OnChange.GetInvocationList())
                {
                    try
                    {
                        handelr.DynamicInvoke(this, EventArgs.Empty);
                    }
                    catch (Exception ex)
                    {
                        exceptions.Add(ex);
                    }
                }
            }

        }

        static void Main(string[] args)
        {
            Pub p = new Pub();

            p.OnChange += (sender, e) => Console.WriteLine("Subscribed 1 called");

            p.OnChange += (sender, e) => { throw new Exception(); };

            p.OnChange += (sender, e) => Console.WriteLine("Subscriber 2 called");

            try
            {
                p.Raise();
            }
            catch (AggregateException e)
            {
                Console.WriteLine("InnerException Count: {0} ", e.InnerExceptions.Count);
            }

            Console.ReadKey();
        }
       
        
    }
}
