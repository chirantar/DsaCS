using System;

namespace ArraySumRecursive
{
    class Program
    {
        //
        static int Sum(int[] arr, int n)
        {
            if (n == 0)
                return arr[0];

            return arr[n] + Sum(arr, n - 1);
        }
        static void Main(string[] args)
        {
            int[] arr = {6 , 2, 1, 3, 10, 5}; //27

            Console.WriteLine("Sum is =" + Sum(arr, arr.Length - 1));
            Console.Read();
        }
    }
}
