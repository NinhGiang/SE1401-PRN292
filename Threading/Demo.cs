using System;
using System.Threading;
using System.Runtime.Remoting.Messaging;

namespace Threading
{
    class Demo
    {
        public delegate int BinaryOp(int x, int y);
        static void Active(string[] args)
        {
            Console.WriteLine("***** Synch Delegate Review *****");
            // Print out the ID of the executing thread.
            Console.WriteLine("Main() invoked on thread {0}.", Thread.CurrentThread.GetHashCode());

            // Invoke Add() in a synchronous manner.
            BinaryOp b = new BinaryOp(Add);
            bool flag = true;
            IAsyncResult iftAR = b.BeginInvoke(10, 10, AddComplete, "Main() thanks you for adding these numbers.");

            while (!iftAR.IsCompleted && flag)
            {
                Console.WriteLine("Doing more work in Main()");
                flag = false;
            }

            // Obtain the result of the Add()
            // method when ready.
            //int answer = b(10, 10);
            //int answer = b.EndInvoke(iftAR);

            //Console.WriteLine("10 + 10 is {0}.", answer);

            Console.ReadLine();
        }
        static int Add(int x, int y)
        {
            // Print out the ID of the executing thread.
            Console.WriteLine("Add() invoked on thread {0}.", Thread.CurrentThread.GetHashCode());
            // Pause to simulate a lengthy operation.
            Thread.Sleep(5000);
            return x + y;
        }
        static void AddComplete(IAsyncResult itfAR)
        {
            Console.WriteLine("AddComplete() invoked on thread {0}.", Thread.CurrentThread.GetHashCode());
            Console.WriteLine("Your addition is complete");


            AsyncResult ar = (AsyncResult)itfAR;
            BinaryOp b = (BinaryOp)ar.AsyncDelegate;
            Console.WriteLine("10 + 10 is {0}.", b.EndInvoke(itfAR));

            string msg = (string)itfAR.AsyncState;
            Console.WriteLine(msg);
        }

    }
}
