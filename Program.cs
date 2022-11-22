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
            Console.WriteLine("SquareRoot Program");
            Console.WriteLine("Enter the number to find squareroot:");
            int num = Convert.ToInt32(Console.ReadLine());
            float squareRoot = num / 2;
            float temp = 0;
            while (squareRoot != temp)
            {
                temp = squareRoot;
                squareRoot = (num / temp + temp) / 2;
            }
            Console.WriteLine($"Square Root of {num} is :" + squareRoot);
            Console.ReadLine();
        }
    }
}
