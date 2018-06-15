﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blockingCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            BlockingCollection<string> col = new BlockingCollection<string>();
            Task read = Task.Run(() =>
            {
                //while (true)
                //{
                //    Console.WriteLine(col.Take());
                //}
                foreach (string v in col.GetConsumingEnumerable())
                    Console.WriteLine(v);
            });

            Task write = Task.Run(() =>
            {
                while(true)
                {
                    string s = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(s)) break;
                    col.Add(s);
                }
            });

            write.Wait();
        }
    }
}
