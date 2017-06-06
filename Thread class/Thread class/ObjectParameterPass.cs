using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Thread_class
{
    class paramsClass
    {
        public int a;
        public int b;
        public paramsClass(int aa, int bb)
        {
            a = aa;
            b = bb;
        }
    }
    class ObjectParameterPass
    {
        public static void MethodOfThread(object a)
        {
            paramsClass c = (paramsClass)a;
            for (int i = 0; i < (int)c.a; i++)
            {
                Console.WriteLine("Thread i = {0}", i);
                Thread.Sleep(c.b);
            }
        }

        static void Mainn(string[] args)
        {
            Thread t = new Thread(new ParameterizedThreadStart(MethodOfThread));
            paramsClass c = new paramsClass(5, 1000);
            t.Start(c);
        }



    }
}
