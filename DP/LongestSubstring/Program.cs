using System;
using System.Globalization;

namespace LongestSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input String");
            string s = Console.ReadLine();
            
            int maxLength = -1;
            for(int i = 2; i <= s.Length; i = i+2)
            {
                for (int j = 0; j < s.Length -i +1; j++)
                {
                    int k = j + i - 1;
                    bool res = CheckIfSumEqual(s, j, k);

                    if (res == true)
                    {
                        int len = k - j + 1;

                        if (maxLength < len)
                        {
                            maxLength = len;
                        }
                    }
                }
            }

            Console.WriteLine($"Output is {maxLength}");
        }

        private static bool CheckIfSumEqual(string s, int i, int k)
        {
            int mid = (i + k) / 2;
            int sum1 = 0, sum2 = 0;
            for(int a = i; a <= mid; a++)
            {
                sum1= sum1 + s[a] - '0';
            }
            for (int a = mid+1; a <= k; a++)
            {
                sum2 = sum2 + s[a] - '0';
            }

            if(sum1 == sum2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
