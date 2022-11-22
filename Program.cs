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
            Console.WriteLine("Temperature Conversion  Program");
            Console.WriteLine("Press 1 for temperature conversion from celsius to fahrenheit \n" +
                               "Press 1 for temperature conversion from fahrenheit to celsius\n");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("Enter temperature in Fahrenheit:");
                    double fahrenheitInput = Convert.ToDouble(Console.ReadLine());
                    double celsiusOutput = (fahrenheitInput - 32) * 5 / 9;
                    Console.WriteLine("Temperature in Celsius is :" + celsiusOutput);
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Enter temperature in celsius:");
                    double celsiusInput = Convert.ToDouble(Console.ReadLine());
                    double fahrenheitOutput = (celsiusInput * 9 / 5) + 32;
                    Console.WriteLine("Temperature in fahrenheit is :" + fahrenheitOutput);
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
        }
    }
}
