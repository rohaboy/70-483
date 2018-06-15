using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace events
{
    class Program
    {

        public class Pub
        {
            public Action OnChange { get; set; }
            public event Action OnChange2 = delegate { };
            public event EventHandler ReportChange = delegate { };
            public void Raise()
            {
                if(OnChange !=null)
                {
                    OnChange();
                }
            }

            public void Raise2()
            {
                if(OnChange2 !=null)
                {
                    OnChange2();
                }
            }

            public void OnReportChange(object sender, EventArgs e)
            {
                ReportChange(sender,e);
            }
        }



        static void Main(string[] args)
        {
            Pub p = new Pub();
            p.OnChange += () => Console.WriteLine("Event raised to method 1"); //Weak as anyone can call this 
            p.OnChange += () => Console.WriteLine("Event rasied to method 2");
            p.Raise();


            Pub p2 = new Pub();
            p2.OnChange2 += () => Console.WriteLine("This is awesome !");
            p2.Raise2();


            Pub p3 = new Pub();
            p3.ReportChange += (s, e) => Console.WriteLine("Eventhandler");
            p3.OnReportChange(null, new EventArgs());


            Console.ReadKey();
        }

        
    }
}
