using System;

namespace BoundaryTraversal
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

        public void PrintBoundary()
        {
            PrintBoundaryUtil(root);
        }

        private void PrintBoundaryUtil(Node root)
        {
            PrintLeftBoundary(root);
            PrintLeafNode(root.left);
            PrintLeafNode(root.right);
            PrintRightBoundary(root);
        }

        public void PrintLeafNode(Node root)
        {
            if (root == null)
                return;
            PrintLeafNode(root.left);
            PrintLeafNode(root.right);

            if (root.left == null && root.right == null)
                Console.Write($"{root.data}, ");
        }

        public void PrintRightBoundary(Node root)
        {
            if (root == null)
                return;

            if (root.right != null)
            {
                PrintRightBoundary(root.right);
                Console.Write($"{root.data}, ");
            }
            else if (root.left != null)
            {
                PrintRightBoundary(root.left);
                Console.Write($"{root.data}, ");
            }
        }

        public void PrintLeftBoundary(Node root)
        {
            if (root == null)
                return;

            if (root.left != null)
            {
                Console.Write($"{root.data}, ");
                PrintLeftBoundary(root.left);
            }
            else if (root.right != null)
            {
                Console.Write($"{root.data}, ");
                PrintLeftBoundary(root.right);
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
            //tree.PrintTopView();
            //tree.PrintLeftView();
            tree.PrintBoundary();
        }
    }
}
