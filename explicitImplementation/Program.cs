using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace explicitImplementation
{
    class Program
    {
        public interface IInterfaceA
        {
            void MyMethod();
        }

        public class InterfaceImplA : IInterfaceA
        {
            void IInterfaceA.MyMethod()
            {
                Console.WriteLine("This is method A");
            }
        }

        public class InterfaceImplB : IInterfaceA
        {
            public void MyMethod()
            {
                Console.WriteLine("My Method in Second Implementation");
            }
        }


        static void Main(string[] args)
        {
            //InterfaceImplA obj = new InterfaceImplA();
            //obj.MyMethod();  //Not possible since it's explicit implementation

            IInterfaceA obj1 = (InterfaceImplA)new InterfaceImplA();
            obj1.MyMethod();

            InterfaceImplB obj2 = new InterfaceImplB();
            obj2.MyMethod();


            Console.Read();

        }
    }
}
