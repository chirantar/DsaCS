using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _71AWayToLongWrd
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            while (n-- > 0)
            {
                string s = Console.ReadLine();

                if (s.Length <= 10)
                    Console.WriteLine(s);
                else
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append(s[0]);
                    sb.Append(s.Length - 2);
                    sb.Append(s[s.Length - 1]);
                    Console.WriteLine(sb.ToString());
                }
            }

        }
    }
}
