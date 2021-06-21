using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MinCoinDenomReqForAmt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the denominations");
            //int[] denom = Console.ReadLine().Split(',').ToList().Select(x => int.Parse(x)).ToArray();
            int[] denom = new int[] { 186, 419, 83, 408 };

            Console.WriteLine("Enter the Amount");
            //int amount = Convert.ToInt32(Console.ReadLine());
            int amount = 6249;
            int getMinCoins = GetMinCoins(denom, amount);
            Console.WriteLine($"Ans is {getMinCoins}");
        }

        private static int GetMinCoins(int[] denom, int amount)
        {
            Array.Sort(denom);
            long[] result = new long[amount + 1];
            result[0] = 0;
            for (int i = 1; i < result.Length; i++)
            {
                result[i] = int.MaxValue;
            }
            for (int i = 0; i < denom.Length; i++)
            {
                for (int j = 1; j < result.Length; j++)
                {
                    if (denom[i] <= j)
                    {
                        result[j] = Math.Min(result[j], 1 + result[j - denom[i]]);
                    }
                }
            }

            if (result[amount] == int.MaxValue)
            {
                return -1;
            }
            else
            {
                return (int)result[amount];
            }
        }
    }
}
