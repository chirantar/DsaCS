using System;
using System.Collections.Generic;

namespace ZIgZagTraversal
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

        public void PrintZigzagTraversal()
        {
            PrintZigzagTraversalUtil(root);
        }

        private void PrintZigzagTraversalUtil(Node root)
        {
            if (root == null)
            {
                return;
            }
            Stack<Node> s1 = new Stack<Node>();
            Stack<Node> s2 = new Stack<Node>();
            s1.Push(root);
            bool odd = true;
            while (s1.Count > 0)
            {
                Node temp = s1.Pop();
                Console.Write($"{temp.data}, ");
                if (odd)
                {
                    if (temp.left != null)
                        s2.Push(temp.left);
                    if (temp.right != null)
                        s2.Push(temp.right);
                }
                else
                {
                    if (temp.right != null)
                        s2.Push(temp.right);
                    if (temp.left != null)
                        s2.Push(temp.left);
                }

                if (s1.Count == 0)
                {
                    Stack<Node> stemp = s1;
                    s1 = s2;
                    s2 = stemp;
                    odd = !odd;
                }
            }
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
            tree.root.left.left.right = new Node(9);
            tree.root.left.right.left = new Node(10);
            tree.root.left.right.right = new Node(11);

            tree.root.right.left.left = new Node(12);
            tree.root.right.left.right = new Node(13);
            tree.root.right.right.left = new Node(14);
            tree.root.right.right.right = new Node(15);
            tree.PrintZigzagTraversal();
            Console.WriteLine("Hello World!");
        }
    }
}
