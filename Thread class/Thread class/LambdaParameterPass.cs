using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Thread_class
{

    class LambdaParameterPass
    {
        public static void MethodOfThread(int a, int b)
        {
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Thread i = {0}", i);
                Thread.Sleep(b);
            }
        }

        static void Mainn(string[] args)
        {
            Thread t = new Thread(u => MethodOfThread(5, 1000));
            t.Start();
        }



    }
}
