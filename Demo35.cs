using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Demo35
{
    class MyClass
    {
        public static void Run()
        {
            int count = 0;
            while (count < 5)
            {
                Console.WriteLine("Calling thread {0} time", count + 1);
                Console.WriteLine("\n" + Thread.CurrentThread.Name);
                Console.WriteLine("------------------------------------------------------\n");
                Console.WriteLine("\n----------------------------------------------------------------------------------------------\n");
                Thread.Sleep(2000);
                count++;
            }
        }
    }
    class ThreadDemo
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(new ThreadStart(MyClass.Run));
            thread.Name = "Main Thread";
            thread.Start();
            thread.Join();
            Console.WriteLine("Calling thread five times.............\n");
            Console.WriteLine("\nCalling three child threads at the same time.................\n");
            Thread firstChild = new Thread(new ThreadStart(MyClass.Run));
            firstChild.Name = "First Thread";
            Thread secondChild = new Thread(new ThreadStart(MyClass.Run));
            secondChild.Name = "Second Thread";
            Thread thirdChild = new Thread(new ThreadStart(MyClass.Run));
            thirdChild.Name = "Third Thread";
            firstChild.Start();
            secondChild.Start();
            thirdChild.Start();
        }
    }
}
