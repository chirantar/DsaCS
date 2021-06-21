using System;
using System.Collections.Generic;

namespace TopAndOtherViews
{
    public class Node
    {
        public int data;
        public Node left;
        public Node right;
        public Node(int data)
        {
            this.data = data;
        }
    }
    class Pair
    {
        public int first, second;

        public Pair(int f, int s)
        {
            first = f;
            second = s;
        }
    }

    public class BinaryTree
    {
        public Node root;

        public void PrintLeftView()
        {
            List<int> ans = new List<int>();
            PrintLeftViewRec(root, ans);

            foreach (int i in ans)
            {
                Console.Write($"{i}, ");
            }
        }

        private void PrintLeftViewRec(Node root, List<int> ans)
        {
            if (root == null)
            {
                return;
            }
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(root);

            while (q.Count > 0)
            {
                int count = q.Count;
                for (int i = 1; i <= count; i++)
                {
                    Node temp = q.Dequeue();
                    if (i == 1)
                        ans.Add(temp.data);

                    if (temp.left != null)
                        q.Enqueue(temp.left);
                    if (temp.right != null)
                        q.Enqueue(temp.right);
                }
            }

        }

        public void PrintTopView()
        {
            SortedDictionary<int, Pair> m = new SortedDictionary<int, Pair>();
            PrintTopViewRec(root, 0, 0, m);
            foreach (Pair pair in m.Values)
            {
                Console.Write(pair.first + ", ");
            }
        }


        private void PrintTopViewRec(Node root, int d, int l, SortedDictionary<int, Pair> m)
        {
            if (root == null)
                return;
            if (m.ContainsKey(d) == false)
            {
                m[d] = new Pair(root.data, l);
            }
            else if (m[d].second > l)
            {
                m[d] = new Pair(root.data, l);
            }

            PrintTopViewRec(root.left, d - 1, l + 1, m);
            PrintTopViewRec(root.right, d + 1, l + 1, m);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //  1 |
            // 2  3 |
            // 4 5  6 7 |
            // 8 N  N N  N N  N N
            BinaryTree tree = new BinaryTree();

            // Let us create trees shown in above diagram
            tree.root = new Node(1);
            tree.root.left = new Node(2);
            tree.root.right = new Node(3);
            tree.root.left.left = new Node(4);
            tree.root.left.right = new Node(5);
            tree.root.right.left = new Node(6);
            tree.root.right.right = new Node(7);
            tree.root.left.left.left = new Node(8);
            //tree.PrintTopView();
            tree.PrintLeftView();
        }
    }
}
