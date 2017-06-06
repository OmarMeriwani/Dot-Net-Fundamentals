﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Thread_class
{
    class Program
    {
        public static void MethodOfThread(object a)
        {
            for (int i = 0; i < (int)a; i++)
            {
                Console.WriteLine("Thread i = {0}", i);
                Thread.Sleep(1000);
            }
        }

        static void Main(string[] args)
        {
            Thread t = new Thread(new ParameterizedThreadStart(MethodOfThread));
            t.IsBackground = true;
            t.Start(7);
        }
     


    }
}
