using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountBasedOnClass
{
    class Program
    {
        static void Main(string[] args)
        {
            double discountPer = 0;
            double discountedAmount = 0;
            double total = 0;
            Console.Write("Enter customer, C or R type:");
            string cusType = Console.ReadLine();

            Console.Write("Enter subtotal: ");
            double subtotal = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            if(cusType=="C" && subtotal < 100)
            {
                discountPer = 0.2;
                
            }
            else
            {
                discountPer = 0.3;
            }


            if (cusType == "R" && subtotal < 100)
            {
                discountPer = 0;

            }
            else if(cusType == "R" && subtotal >= 100 && subtotal < 250)
            {
                discountPer = 0.1;
            }
            else
            {
                discountPer = 0.25;
            }

            discountedAmount = subtotal * discountPer;
            total = subtotal - discountedAmount;

            Console.WriteLine("Discount percent: " + discountPer.ToString("P1"));
            Console.WriteLine("Discounted Amount: " + discountedAmount.ToString("C"));
            Console.WriteLine("Total: " + total.ToString("C"));

            //    double total = subtotal - discountedAmount;
            //   Console.Write("Total: " + total.ToString("C"));
            Console.ReadLine();

        }
    }
}
