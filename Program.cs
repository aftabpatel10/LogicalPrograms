using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Logical Programs");
            Console.WriteLine("Fibonacci Program");
            Console.WriteLine("Enter the number of elements:");
            int n = Convert.ToInt32(Console.ReadLine());
            int n1 = 0, n2 = 1, n3;
            Console.Write(n1 + " " + n2 + " ");
            for (int i = 2; i < n; i++)
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;

            }
            Console.ReadLine();
        }
    }
}
