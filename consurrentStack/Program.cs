using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consurrentStack
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;
            ConcurrentStack<int> stack = new ConcurrentStack<int>(); //LIFO

            stack.Push(41);
            stack.Push(42);
            stack.Push(45);

            if (stack.TryPop(out result))
                Console.WriteLine("Popped : {0}", result);

            stack.PushRange(new int[] {1,2,4 });

            int[] value = new int[2];
            stack.TryPopRange(value);

            foreach (int i in value)
                Console.WriteLine(i);

            Console.ReadKey();
        }
    }
}
