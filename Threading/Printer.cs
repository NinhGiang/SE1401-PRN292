using System;
using System.Threading;
using System.Runtime.Remoting.Contexts;

namespace Threading
{
    [Synchronization]
    public class Printer: ContextBoundObject
    {
        public void PrintNumbers()
        {
    
            // Display Thread info.
            Console.WriteLine("-> {0} is executing PrintNumbers()", Thread.CurrentThread.Name);
            // Print out numbers.
            Console.Write("Your numbers: ");
            for (int i = 0; i < 10; i++)
            {
                Random r = new Random();
                Thread.Sleep(1000 * r.Next(5));
                //Thread.Sleep(1000);
                Console.Write(i + ", ");
            }
            Console.WriteLine();
   
            //Monitor.Enter(this);
            //try
            //{
            //    // Display Thread info.
            //    Console.WriteLine("-> {0} is executing PrintNumbers()",
            //    Thread.CurrentThread.Name);
            //    // Print out numbers. 
            //    Console.Write("Your numbers: "); 
            //    for (int i = 0; i < 10; i++)
            //    {
            //        Random r = new Random(); 
            //        Thread.Sleep(1000 * r.Next(5)); 
            //        Console.Write(i + ", ");
            //    }
            //    Console.WriteLine();
            //}
            //finally
            //{
            //    Monitor.Exit(this);
            //}
            //lock(this) { 
            //// Display Thread info.
            //Console.WriteLine("-> {0} is executing PrintNumbers()", Thread.CurrentThread.Name);
            //// Print out numbers.
            //Console.Write("Your numbers: "); 
            //for (int i = 0; i < 10; i++)
            //{
            //    Random r = new Random(); 
            //    Thread.Sleep(1000 * r.Next(5));
            //    //Thread.Sleep(1000);
            //    Console.Write(i + ", ");
            //}
            //Console.WriteLine();
            //}
        }
    }
}
