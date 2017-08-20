using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Demo33
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Displaying date and time of the system...........\n");
                int count = 0;
                while (count < 10)
                {
                    Console.WriteLine("\n" + DateTime.Now.ToString());
                    Thread.Sleep(2000);
                    count++;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
