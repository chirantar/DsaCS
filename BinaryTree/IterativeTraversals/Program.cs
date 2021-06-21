using System;
using System.Collections.Generic;

namespace IterativeTraversals
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
    public class BinaryTree
    {
        public Node root;

        public void IterativeInOrder()
        {
            IterativeInOrderUtil(root);
        }

        public void IterativePreorder()
        {
            IterativePreorderUtil(root);
        }

        private void IterativePreorderUtil(Node root)
        {
            Stack<Node> s = new Stack<Node>();
            Node temp = root;
            s.Push(temp);

            while (s.Count > 0 || temp != null)
            {
                if (temp != null)
                {
                    Console.Write($"{temp.data}, ");
                    s.Push(temp);
                    temp = temp.left;
                }
                else
                {
                    temp = s.Pop();
                    temp = temp.right;
                }
            }
        }

        private void IterativeInOrderUtil(Node root)
        {
            Stack<Node> s = new Stack<Node>();

            Node temp = root;
            s.Push(temp);
            while (s.Count > 0 || temp != null)
            {
                while (temp != null)
                {
                    s.Push(temp);
                    temp = temp.left;
                }


                temp = s.Pop();
                Console.Write(temp.data + ", ");
                //if (temp.right != null)
                temp = temp.right;
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

            tree.IterativeInOrder();
            Console.WriteLine();
            tree.IterativePreorder();

            Console.WriteLine("Hello World!");
        }
    }
}
