using System;

namespace HeapsImplementation
{
    class MaxHeap
    {
        int size;
        int[] arr;
        public MaxHeap(int[] arr, int size)
        {
            this.arr = arr;
            this.size = size;

            int i = (size -1)/2;

            while (i >= 0)
            {
                Heapify(arr, i, size);
                i--;
            }
        }

        public int Parent(int i)
        {
            return (i - 1) / 2;
        }
        public int Left(int i)
        {
            return 2 * i + 1;
        }
        public int Right(int i)
        {
            return 2 * i + 2;
        }

        public void Heapify(int[] arr, int i, int n)
        {
            int largest = i;
            int left = Left(i);
            int right = Right(i);
            if (left < n && arr[largest] < arr[left])
            {
                largest = left;
            }
            if (right < n && arr[largest] < arr[right])
            {
                largest = right;
            }

            if (largest != i)
            {
                int temp = arr[largest];
                arr[largest] = arr[i];
                arr[i] = temp;
                Heapify(arr, largest, n);
            }
        }

        public int RemoveMax()
        {
            if (size == 1)
            {
                return Int32.MinValue;
            }
            int max = arr[0];
            if (size > 1)
            {
                arr[0] = arr[size - 1];
                Heapify(arr, 0, size);
            }
            size--;
            return max;
        }
    }

    class MinHeap
    {
        int size;
        int[] arr;
        public MinHeap(int[] arr, int size)
        {
            this.arr = arr;
            this.size = size;

            int i = (size -1)/2;

            while (i >= 0)
            {
                Heapify(arr, i, size);
                i--;
            }
        }

        public int Parent(int i)
        {
            return (i - 1) / 2;
        }
        public int Left(int i)
        {
            return 2 * i + 1;
        }
        public int Right(int i)
        {
            return 2 * i + 2;
        }

        public void Heapify(int[] arr, int i, int n)
        {
            int smallest = i;
            int left = Left(i);
            int right = Right(i);
            if (left < n && arr[smallest] > arr[left])
            {
                smallest = left;
            }
            if (right < n && arr[smallest] > arr[right])
            {
                smallest = right;
            }

            if (smallest != i)
            {
                int temp = arr[smallest];
                arr[smallest] = arr[i];
                arr[i] = temp;
                Heapify(arr, smallest, n);
            }
        }

        public int RemoveMin()
        {
            if (size == 1)
            {
                return Int32.MaxValue;
            }
            int min = arr[0];
            if (size > 1)
            {
                arr[0] = arr[size - 1];
                Heapify(arr, 0, size);
            }
            size--;
            return min;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {10, 13, 7, 5, 14, 2, 23};
            //MaxHeap maxHp = new MaxHeap(arr, arr.Length);
            //Console.WriteLine(maxHp.RemoveMax());
            //Console.WriteLine(maxHp.RemoveMax());
            //Console.WriteLine(maxHp.RemoveMax());

            MinHeap minHp = new MinHeap(arr, arr.Length);
            Console.WriteLine(minHp.RemoveMin());
            Console.WriteLine(minHp.RemoveMin());
            Console.WriteLine(minHp.RemoveMin());

            Console.Read();


        }
    }
}
