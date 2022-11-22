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
            Console.WriteLine("Enter the number of Coupens required:");
            int CoupenLength = Convert.ToInt32(Console.ReadLine());
            int[] totalCoupons = new int[CoupenLength];
            int randomNum;
            Random random = new Random();
            for (int i = 0; i < totalCoupons.Length; i++)
            {
            moving:
                randomNum = random.Next();
                for (int x = 0; x < totalCoupons.Length; x++)
                {
                    if (totalCoupons[x] == randomNum)
                    {
                        x--;
                        goto moving;
                    }
                }
                totalCoupons[i] = randomNum;
            }
            for (int i = 0; i < totalCoupons.Length; i++)
            {
                Console.WriteLine(totalCoupons[i] + " ");
            }
        }
    }
}
