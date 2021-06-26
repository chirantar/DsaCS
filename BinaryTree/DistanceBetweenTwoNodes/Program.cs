using System;

namespace DistanceBetweenTwoNodes
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

        private Node LCA(Node root, int a, int b)
        {
            if (root == null)
                return null;

            if (root.data == a || root.data == b)
                return root;
            Node left = LCA(root.left, a, b);
            Node right = LCA(root.right, a, b);

            if (left != null && right != null)
                return root;

            return left == null ? right : left;
        }

        public int FindDistance(int a, int b)
        {
            return FindDistanceUtil(root, a, b);
        }

        private int FindDistanceUtil(Node root, int a, int b)
        {
            Node lca = LCA(root, a, b);

            int d1 = Level(root, a, 0);
            int d2 = Level(root, b, 0);

            return d1 + d2;
        }

        private int Level(Node root, int a, int level)
        {
            if (root == null)
                return -1;

            if (a == root.data)
                return level;

            int val = Level(root.left, a, level +1);

            if (val == -1)
                val = Level(root.right, a, level + 1);

            return val;
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

            Console.WriteLine(tree.FindDistance(4, 1));
            Console.Read();
        }
    }
}
