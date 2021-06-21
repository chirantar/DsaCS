using System;
using System.Collections.Generic;
using System.Text;

namespace DigitSumRecursive
{
    class Program
    {
        static int DigitSum(int n)
        {
            if (n <= 0)
                return 0;
            return n % 10 + DigitSum(n / 10);
        }
        static void Main(string[] args)
        {
            int num = 1234;
            StringBuilder sb = new StringBuilder();
            sb.Remove(sb.Length - 1, 1);
            List<string> ls = new List<string>();
            ls.Add(sb.ToString());
            Console.WriteLine("Digit sum is =" + DigitSum(num));
            Console.Read();
        }
    }
}
