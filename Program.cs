using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRIME_TASK11
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("start number");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("end number");
            int end = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = start; i <= end; i++)
            {
                for (int x = 1; x <= i; x++)
                {
                    if (i % x == 0)
                        sum++;
                }
                if (sum == 2)
                {
                    Console.WriteLine("PERFECT IS:"+i);
                    sum = 0;
                }
                else
                {
                    sum = 0;
                }
            }
        }
    }
}