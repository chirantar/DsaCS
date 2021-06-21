using System;
using System.Linq;

namespace LongestPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();

            int maxLength = 1;
            string subToCheck = "";
            for (int i = 2; i <= str.Length; i++)
            {
                for (int j = 0; j < str.Length - i + 1; j++)
                {
                    int k = j + i - 1;

                    bool res = CheckIfPalindrome(str, j, i, ref maxLength);

                    
                    if (res == true)
                    {
                        subToCheck = str.Substring(j, i);
                        if (maxLength < i)
                        {
                            maxLength = i;
                        }
                    }
                }
            }

            Console.WriteLine($"MaxLength of LongestPalindrome is = {subToCheck}");
        }

        private static bool CheckIfPalindrome(string str, int j, int i, ref int maxLength)
        {
            string subToCheck = str.Substring(j, i);
            string val = str.Substring(j, i);
            char[] arr = val.ToCharArray();
            Array.Reverse(arr);
            val =  new string(arr);
            if (val == subToCheck)
            {
                return true;
            }
            
            return false;
        }
    }
}
