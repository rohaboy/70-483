﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace asyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = DownloadContent().Result;
            Console.WriteLine(result);


            Console.ReadKey();
        }

        public static async Task<string> DownloadContent()
        {
            using (HttpClient client = new HttpClient())
            {
                string result = await client.GetStringAsync("http://www.microsoft.com");
                return result;
            }
        }
    }
}
