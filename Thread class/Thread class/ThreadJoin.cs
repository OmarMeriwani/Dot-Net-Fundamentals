using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Thread_class
{
    class ThreadJoin
    {
        public static void MethodA(int n)
        {
            Thread.Sleep(1);
            a = n * n;
        }
        public static void MethodB(int n)
        {
            b = n * n;
        }
        static int a = 0;
        static int b = 0;
        static void Mainn(string[] args)
        {
            //The first thread will find Square of a, second thread will find square of b and thread c will sum them
            Thread t1 = new Thread(u => MethodA(3));
            t1.Start();
            Thread t2 = new Thread(u => MethodB(4));
            t2.Start();
            //t1.Join();
            //t2.Join();
            int c = a + b;
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
}
