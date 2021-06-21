using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coconut
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Int32.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int[] arr = Console.ReadLine().Split(' ').Select((x)=>{ return int.Parse(x); }).ToArray();
                int xa = arr[0];
                int xb = arr[1];
                int xA  = arr[2];
                int xB = arr[3];

                int sum = xA / xa + xB / xb;
                Console.WriteLine(sum);
            }

        }
    }
}
