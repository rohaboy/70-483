using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace taskFactory
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Task<Int32[]> parent = Task.Run(() =>
        //    {
        //        var result = new Int32[3];

        //        TaskFactory tf = new TaskFactory(TaskCreationOptions.AttachedToParent,
        //            TaskContinuationOptions.ExecuteSynchronously);

        //        tf.StartNew(() => result[0] = 0);
        //        tf.StartNew(() => result[1] = 1);
        //        tf.StartNew(() => result[2] = 2);

        //        return result;
        //    });

        //    var finalTask = parent.ContinueWith(
        //        parentTask =>
        //        {
        //            foreach (int i in parentTask.Result)
        //                Console.WriteLine(i);
        //        });

        //    finalTask.Wait();


        //    Console.ReadKey();
        //}

        //static void Main(string[] args)
        //{
        //    Task[] tasks = new Task[3];

        //    tasks[0] = Task.Run(() =>
        //    {
        //        Thread.Sleep(2000);
        //        Console.WriteLine("1");
        //        return 1;
        //    });

        //    tasks[1] = Task.Run(() =>
        //    {
        //        Thread.Sleep(2000);
        //        Console.WriteLine("2");
        //        return 1;
        //    });

        //    tasks[2] = Task.Run(() =>
        //    {
        //        Thread.Sleep(2000);
        //        Console.WriteLine("3");
        //        return 1;
        //    });

        //    Task.WaitAll(tasks);

        //    Console.ReadKey();
        //}

        static void Main(string[] args)
        {
            Task<int>[] tasks = new Task<int>[3];

            tasks[0] = Task.Run(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("1");
                return 1;
            });

            tasks[1] = Task.Run(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("2");
                return 1;
            });

            tasks[2] = Task.Run(() =>
            {
                Thread.Sleep(3000);
                Console.WriteLine("3");
                return 1;
            });

            while(tasks.Length>0)
            {
                int i = Task.WaitAny(tasks);
                Task<int> completedTask = tasks[i];

                Console.WriteLine(completedTask.Result);

                var temp = tasks.ToList();
                temp.RemoveAt(i);
                tasks = temp.ToArray();
            }

            Console.ReadKey();
        }
    }
}
