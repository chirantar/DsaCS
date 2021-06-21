using System;
using System.Collections.Generic;

namespace ReverseLevelOrder
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

    public class BinaryTree
    {
        public Node root;

        public List<int> TopView(Node root)
        {

        }

        public Node Mirror(Node root)
        {
            if (root == null)
            {
                return null;
            }

            Node left = Mirror(root.left);
            Node right = Mirror(root.right);

            root.left = right;
            root.right = left;

            return root;
        }

        public int Height(Node root)
        {
            if (root == null)
                return 0;

            int leftHeight = Height(root.left);
            int rightHeight = Height(root.right);

            return Math.Max(leftHeight, rightHeight) + 1;
        }

        public int Diameter(Node root)
        {
            if (root == null)
                return 0;

            int leftHeight = Height(root.left);
            int rightHeight = Height(root.right);

            return Math.Max(leftHeight + rightHeight + 1, Math.Max(Diameter(root.left), Diameter(root.left)));
        }

        public void PrintLevelOrder(Node root)
        {
            if (root == null)
                return;

            Queue<Node> q = new Queue<Node>();

            q.Enqueue(root);

            while (q.Count > 0)
            {
                Node temp = q.Dequeue();
                Console.Write($"{temp.data}, ");

                if (temp.left != null)
                {
                    q.Enqueue(temp.left);
                }
                if (temp.right != null)
                {
                    q.Enqueue(temp.right);
                }
            }
        }
        public void PrintReverseLevelOrder()
        {
            if (root == null)
                return;

            Queue<Node> q = new Queue<Node>();
            Stack<Node> s = new Stack<Node>();

            q.Enqueue(root);

            while (q.Count > 0)
            {
                Node temp = q.Dequeue();
                s.Push(temp);

                if (temp.left != null)
                {
                    q.Enqueue(temp.left);
                }
                if (temp.right != null)
                {
                    q.Enqueue(temp.right);
                }
            }

            while (s.Count > 0)
            {
                Console.Write($"{s.Pop().data}, ");
            }
        }
    }

    class Program
    {

        static void Main(string[] args)
        {

            // 1 | 2 3 | 4 5  6 7 | 8 N  N N  N N  N N
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

            tree.PrintReverseLevelOrder();
            Console.WriteLine();
            tree.PrintLevelOrder(tree.root);
            Console.WriteLine($"Height of tree {tree.Height(tree.root)}");
            Console.WriteLine($"Diameter of tree {tree.Diameter(tree.root)}");
            Node mirror = tree.Mirror(tree.root);
            tree.PrintLevelOrder(mirror);

            Console.Read();

        }
    }
}
