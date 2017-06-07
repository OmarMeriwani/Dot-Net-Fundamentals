using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Thread_class
{

    class Program
    {
        public static void MethodA()
        {
            Console.WriteLine("Thread A is running");
            Thread.Sleep(1000);
        }
        public static void MethodB()
        {
            for (int i = 0; i < 100; i ++  )
            {
                if (i == 90)
                {
                    stopA = true;
                    Console.WriteLine("B has gave an order to stop A");
                }
                Thread.Sleep(100);

            }
        }
        static bool stopA = false ;
        static void Main(string[] args)
        {
            Thread a  = new Thread (new ThreadStart(() => 
                {
                    while (stopA != true )
                        MethodA();
                }));
            a.Start();
            Console.WriteLine("A has started");
            Thread b = new Thread(new ThreadStart(MethodB));
            b.Start();
            Console.WriteLine("B has started");
            Console.ReadLine();

        }
     


    }
}
