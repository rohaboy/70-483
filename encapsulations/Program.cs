using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulations
{

    class Sample
    {
        private string dataField = "Hello World !";

        public Sample(int value)
        {
            this.ReadOnly = value;
        }

        public int ReadOnly
        {
            get;
            private set;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Value Set => {0}", this.ReadOnly);
            Console.WriteLine("Data Field => {0}", this.dataField);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Sample s1 = new Sample(100);
            s1.DisplayInfo();
            //s1.ReadOnly = 10; //not possible

            Console.ReadKey();
        }
    }
}
