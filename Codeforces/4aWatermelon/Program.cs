using System;

namespace _4aWatermelon
{
    class Program
    {
        static void Main(string[] args)
        {
            int w = Int32.Parse(Console.ReadLine());
            if (w % 2 != 0 || w <= 2)
            {
                Console.WriteLine("NO");
                return;
            }
            Console.WriteLine("YES");
        }
    }
}
