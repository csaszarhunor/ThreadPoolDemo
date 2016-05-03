using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadPoolDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            WaitCallback callback = new WaitCallback(ShowMyText);
            ThreadPool.QueueUserWorkItem(callback, "Hello");
            ThreadPool.QueueUserWorkItem(callback, "Hi");
            ThreadPool.QueueUserWorkItem(callback, "Heya");
            ThreadPool.QueueUserWorkItem(callback, "Goodbye");
            Console.ReadKey();
        }

        static void ShowMyText(object state)
        {
            string stateStr = (string)state;
            Console.WriteLine("Managed Thread ID: {0}, State: {1}", 
            Thread.CurrentThread.ManagedThreadId, stateStr);
        }
    }
}
