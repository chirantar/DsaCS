using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSumPathBT
{
    public class Node
    {
        public int data;
        public Node left,right;
        public Node(int x)
        {
            data = x;
            left = right = null;
        }
    }
    class KSumPath
    {
        static void Main(string[] args)
        {
            Node root = new Node(1);
            root.left = new Node(3);
            root.left.left = new Node(2);
            root.left.right = new Node(1);
            root.left.right.left = new Node(1);
            root.right = new Node(-1);
            root.right.left = new Node(4);
            root.right.left.left = new Node(1);
            root.right.left.right = new Node(2);
            root.right.right = new Node(5);
            root.right.right.right = new Node(2);

            int k =5;
            PrintKSumPath(root, k);

        }
        private static void PrintList(List<int> path, int j)
        {
            for (int i = path.Count - 1; i >= j; i--)
            {
                Console.Write($"{path[i]}, ");
            }
            Console.WriteLine();
        }
        static List<int> path = new List<int>();
        private static void PrintKSumPath(Node root, int k)
        {
            if (root == null)
                return;

            path.Add(root.data);

            PrintKSumPath(root.left, k);
            PrintKSumPath(root.right, k);

            int f = 0;
            for (int i = path.Count - 1; i >= 0; i--)
            {
                f += path[i];

                if (f == k)
                    PrintList(path, i);
            }

            path.RemoveAt(path.Count - 1);
        }
    }
}
