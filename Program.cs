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
            Console.WriteLine("Monthly Payment  Program");
            Console.WriteLine("Please enter the loan amount you want to have");
            double P = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the loan time in years:");
            double Y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Rate of Interest will be :");
            double R = Convert.ToDouble(Console.ReadLine());
            //formulation steps
            double n = 12 * Y;
            double r = R / (12 * 100);
            double upsideCalculation = P * r;
            double downsideAddition = 1 + r;
            double downsideRaisedToCalculation = Math.Pow(downsideAddition, -n);
            double downsideCalculation = 1 - downsideRaisedToCalculation;
            double monthlyPayment = upsideCalculation / downsideCalculation;
            Console.WriteLine($"Monthly Payment will be : {monthlyPayment}");
            Console.ReadLine();
        }
    }
}
