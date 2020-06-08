using System;
using System.Threading;

namespace Threading
{
    class Program
    {
        static void Ex1()
        {
            Console.WriteLine("***** The Amazing Thread App *****\n");
            Console.Write("Do you want [1] or [2] threads? ");
            string threadCount = Console.ReadLine();
            // Name the current thread.
            Thread primaryThread = Thread.CurrentThread;
            primaryThread.Name = "Primary";
            // Display Thread info.
            Console.WriteLine("-> {0} is executing Main()", Thread.CurrentThread.Name);
            // Make worker class.
            Printer p = new Printer();
            switch (threadCount)
            {
                case "2":
                    // Now make the thread.
                    Thread backgroundThread = new Thread(new ThreadStart(p.PrintNumbers));
                    backgroundThread.Name = "Secondary";
                    backgroundThread.Start();
                    break;
                case "1":
                    p.PrintNumbers();
                    break;
                default:
                    Console.WriteLine("I don't know what you want...you get 1 thread.");
                    goto case "1";
            }
            // Do some additional work.
            Console.WriteLine("Work on main thread...");
            Console.ReadLine();
        }
        static void Ex2()
        {
            Console.WriteLine("*****Synchronizing Threads *****\n");
            Printer p = new Printer();
            // Make 10 threads that are all pointing to the same // method on the same object.
            Thread[] threads = new Thread[10];
            for (int i = 0; i < 10; i++)
            {
                threads[i] = new Thread(new ThreadStart(p.PrintNumbers)); 
                threads[i].Name = string.Format("Worker thread #{0}", i);
            }
            // Now start each one.
            foreach (Thread t in threads) t.Start();
            Console.ReadLine();

        }
        static void Ex3()
        {
            Console.WriteLine("***** Working with Timer type *****\n");
            // Create the delegate for the Timer type.
            TimerCallback timeCB = new TimerCallback(PrintTime);
            // Establish timer settings.
            Timer t = new Timer(
                timeCB, // The TimerCallback delegate type.
                "Hi", // Any info to pass into the called method (null for no info). 
                0, // Amount of time to wait before starting.
                1000 // Interval of time between calls (in milliseconds).
            );
            Console.WriteLine("Hit key to terminate...");
            Console.ReadLine();

        }
        static void Ex4()
        {
            Console.WriteLine("Main thread started. ThreadID = {0}", Thread.CurrentThread.GetHashCode());
            Printer p = new Printer();
            WaitCallback workItem = new WaitCallback(PrintTheNumbers);
            // Queue the method 10 times
            for (int i = 0; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem(workItem, p);
            }
            Console.WriteLine("All tasks queued");
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Ex4();
        }
        static void PrintTime(object state)
        {
            Console.WriteLine("Time is: {0}, Param is: {1}", DateTime.Now.ToLongTimeString(), state.ToString());
        }
        static void PrintTheNumbers(object state)
        {
            Printer task = (Printer)state;
            task.PrintNumbers();
        }
    }
}
