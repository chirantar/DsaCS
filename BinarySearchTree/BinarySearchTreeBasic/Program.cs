using System;

namespace BinarySearchTreeBasic
{
    class Node
    {
        public int data;
        public Node left, right;
        public Node(int data)
        {
            this.data = data;
            left = right = null;
        }
    }

    class BST
    {
        Node root = null;
        public void Insert(int data)
        {
            root = InsertRec(root, data);
        }

        public Node Search(int data)
        {
            return SearchRec(root, data);
        }

        private Node SearchRec(Node root, int data)
        {
            if (root == null || root.data == data)
                return root;

            if (root.data < data)
            {
                return SearchRec(root.right, data);
            }

            return SearchRec(root.left, data);
        }

        private Node InsertRec(Node root, int data)
        {
            if (root == null)
            {
                root = new Node(data);
                return root;
            }

            if (root.data < data)
            {
                root.right = InsertRec(root.right, data);
            }
            else
            {
                root.left = InsertRec(root.left, data);
            }

            return root;
        }

        public void InOrder()
        {
            InOrderRec(root);
        }

        public void Deletion(int data)
        {
            root = DeletionRec(root, data);
        }

        private Node DeletionRec(Node root, int data)
        {
            if (root == null)
                return null;

            if (root.data > data)
            {
                root.left = DeletionRec(root.left, data);
            }
            else if (root.data < data)
            {
                root.right = DeletionRec(root.right, data);
            }
            else
            {
                if (root.left == null)
                    return root.right;
                else if (root.right == null)
                    return root.left;

                int min = GetMin(root.right);

                root.data = min;

                root.right = DeletionRec(root.right, min);
            }

            return root;
        }

        public int GetMin()
        {
            return GetMinRec(root);
        }

        private int GetMinRec(Node root)
        {
            int minVal = root.data;
            while (root.left != null)
            {
                minVal = root.left.data;
                root = root.left;
            }

            return minVal;
        }
        public int GetMax()
        {
            return GetMaxRec(root);
        }
        private int GetMaxRec(Node root)
        {
            int maxVal = root.data;
            while (root.right != null)
            {
                maxVal = root.right.data;
                root = root.right;
            }

            return maxVal;
        }

        private void InOrderRec(Node root)
        {
            if (root == null)
                return;

            InOrderRec(root.left);
            Console.Write(root.data + ", ");
            InOrderRec(root.right);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            BST bst = new BST();
            bst.Insert(6);
            bst.Insert(5);
            bst.Insert(4);
            bst.Insert(2);
            bst.Insert(7);
            bst.Insert(11);
            bst.InOrder();
            Console.WriteLine();

            if (bst.Search(4) != null)
                Console.WriteLine("Found 4");
            else
                Console.WriteLine("4 Not found");

            if (bst.Search(11) != null)
                Console.WriteLine("Found 11");
            else
                Console.WriteLine("11 Not found");

            if (bst.Search(3) != null)
                Console.WriteLine("Found 3");
            else
                Console.WriteLine("3 Not found");

            bst.Deletion(7);
            bst.InOrder();
            bst.Deletion(6);
            bst.InOrder();

            Console.Read();
        }
    }
}
