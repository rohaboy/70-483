using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace concurrentDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcurrentDictionary<string, int> dic = new ConcurrentDictionary<string, int>();
            if(dic.TryAdd("k1",41))
            {
                Console.WriteLine("Added");
            }

            if (dic.TryUpdate("k1", 21, 41))
            {
                Console.WriteLine("41 updated to 21");
            }

            dic["k1"] = 42;

            int r1 = dic.AddOrUpdate("k1", 3, (s, i) => i * 2);
            int r2 = dic.GetOrAdd("k2", 10);

            Console.WriteLine(r1);
            Console.WriteLine(r2);

            Console.ReadKey();
        }
    }
}
