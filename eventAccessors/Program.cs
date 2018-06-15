using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventAccessors
{
    class Program
    {
        public class MyArgs :EventArgs
        {
            public MyArgs(int v)
            {
                this.SomeVal = v;
            }
            public int SomeVal { get; set; }
        }

        public class Pub
        {
            private event EventHandler<MyArgs> onChange = delegate { };
            public event EventHandler<MyArgs> OnChange
            {
                add
                {
                    lock(onChange)
                    {
                        onChange += value;
                    }
                }
                remove
                {
                    lock(onChange)
                    {
                        onChange -= value;
                    }
                }
            }

            public void Raise()
            {
                onChange(this, new MyArgs(100));
            }
        }


        static void Main(string[] args)
        {

        }
    }
}
