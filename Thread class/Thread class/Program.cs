using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Thread_class
{
    class Program
    {
        public static void MethodOfThread()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Thread i = {0}", i);
                Thread.Sleep(1);
            }
        }

        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(MethodOfThread));
            t.Start();
            for (int i = 0 ; i < 4; i++)
            {
                Console.WriteLine("Main thread");
                Thread.Sleep(2);
            }
            t.Join();
            Console.ReadLine();
        }
     


    }
}
