using System;
using System.Linq;
using System.Threading;

namespace Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine($"Thread Id {Thread.CurrentThread.ManagedThreadId}\n");
            new Thread(() =>
            {
                Thread.Sleep(8000);
                Console.WriteLine("\n Long running Thread ended");
                Console.WriteLine($"Thread Id {Thread.CurrentThread.ManagedThreadId}\n");
            }).Start();

            // This thread, though its in the background, it ends before the 
            // threads on the main Thread end and therefore is implemented
            new Thread(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("\n Long running background Thread ended");
                Console.WriteLine($"Thread Id {Thread.CurrentThread.ManagedThreadId}\n");
            })
            { IsBackground = true}.Start();

            // The application ends even though this thread is still running
            // because its in the background and takes much longer time than the
            // threads on the Main Thread
            new Thread(() =>
            {
                Thread.Sleep(10000);
                Console.WriteLine("\n Long running background Thread ended");
                Console.WriteLine($"Thread Id {Thread.CurrentThread.ManagedThreadId}\n");
            })
            { IsBackground = true }.Start();


            // Use a list of 10 threads
            Enumerable.Range(0, 10).ToList().ForEach(f =>
            {
                new Thread(() =>
                {
                    Thread.Sleep(1000);
                    Console.WriteLine("Thread ended");
                    Console.WriteLine($"Thread Id {Thread.CurrentThread.ManagedThreadId}\n");
                }).Start();
            });
            // this use of thread is same as using Task.Run();
            // Task.Run() is a background thread, inorder to wait for it to finish,
            // await it.
            Enumerable.Range(0, 10).ToList().ForEach(f =>
            {
                ThreadPool.QueueUserWorkItem((objectx) =>
                {
                    Thread.Sleep(1000);
                    Console.WriteLine("Thread ended");
                    Console.WriteLine($"Thread Id {Thread.CurrentThread.ManagedThreadId}\n");
                });
            });
            Console.WriteLine("\n\n All Threads Ended here");
            //  Threads are mostly used for downloading images or other files, while
            // still doing some activity on the MainThread, also called the UI thread.
            // Threads do not make the app work faster, they spread the workload
            // among the different cores of the cpu, making the processor use more 
            // resources


            // for apps that use the UI, the UI element and any other threads created 
            // are on different threads, and you need to join them first
            // use the dispatcher because every element inherits the dispatcher 
            // property
            // example would be
            // Task.Run(() => code here { Dispartcher.Invoke(() => { your UI code here});}
            // or Application.Current.Dispartcher.Invoke(() => { your UI code here});
        }

    }

}
