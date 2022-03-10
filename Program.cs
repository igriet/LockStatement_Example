using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LockStatemenet
{
    class Program
    {
        static readonly object lockObject = new object();
        static void Iteracion()
        {
            lock (lockObject)
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine("Iteracion # " + i + Thread.CurrentThread.ThreadState + " " + Thread.CurrentThread.ManagedThreadId);
                }
            }
        }


        static void Main(string[] args)
        {
            Thread primerThread = new Thread(Iteracion);
            Thread segundoThread = new Thread(Iteracion);
            primerThread.Start();
            segundoThread.Start();
            Console.Read();
        }


    }
}
