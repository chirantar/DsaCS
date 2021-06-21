using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CP
{
    class Program
    {
        static void Main(string[] args)
        {
            long t = Int64.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                long value = Int64.Parse(Console.ReadLine());
                long div = 5;
                int i = 1;
                long sum = 0;
                double val = value;
                while (val >= div)
                {
                    double ans = 1.0 * val / div;

                    sum += (long)ans;
                    val = ans;
                }
                Console.WriteLine(sum);
            }
        }
    }
}
