using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Thread_class
{
    class BackgroundThread
    {
        public static void MethodOfThread()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Thread i = {0}", i);
                Thread.Sleep(10000);
            }
        }

        static void Mainn(string[] args)
        {
            Thread t = new Thread(new ThreadStart(MethodOfThread));
            t.IsBackground = true;
            t.Start();
        }
     
    }
}
