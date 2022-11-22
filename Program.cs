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
            Console.WriteLine("Prime Number Program");
            Console.WriteLine("Enter the number to be checked:");
            int n = Convert.ToInt32(Console.ReadLine());
            int reverse = 0, rem;
            while (n != 0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n = n / 10;
            }
            Console.WriteLine("Reversed Number is :" + reverse);
            Console.ReadLine();
        }
    }
}
