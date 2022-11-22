using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sw = stopwatch.StartNew();
            Console.WriteLine("Start the timer by pressing any key");
            String timerStart = Console.ReadLine();
            while (timerStart != null)
            {
                sw.Start(); //to start the timer 
                Console.WriteLine("Stop the timer by pressing any key");
                Console.ReadLine();
                sw.Stop(); //To stop the timer
                break;
            }
            Console.WriteLine("Time elapsed :{0}ms", sw.ElapsedTicks);
            Console.ReadLine();
        }
    }
}
