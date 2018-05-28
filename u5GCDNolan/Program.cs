using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u5GCDNolan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First Number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Second Number: ");
            int num2 = int.Parse(Console.ReadLine());
            int min = Math.Min(num1, num2);
            int max = Math.Max(num1, num2);
            num1 = max;
            num2 = min;
            while (num2 > 0) {

                int temp = num1 % num2;
                num1 = num2;
                num2 = temp;
             }
            Console.WriteLine("GCD is {0}", num1);
            Console.ReadLine();
        }
    }
}
