using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overriding
{
    class Base
    {
        public virtual int MyMethod()
        {
            return 42;
        }

        class Derived : Base
        {
            public sealed override int MyMethod()
            {
                return base.MyMethod() * 2;
            }
        }

        class Derived2 : Derived
        {
            //public override int MyMethod(){return 1;}  //will not compile as method is sealed in based
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
