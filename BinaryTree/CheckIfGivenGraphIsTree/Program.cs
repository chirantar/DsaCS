using System;
using System.Collections.Generic;

namespace CheckIfGivenGraphIsTree
{
    class Graph
    {
        private int v; // No. of vertices
        private List<int> []adj; // Adjacency List

        // Constructor
        public Graph(int v)
        {
            this.v = v;
            adj = new List<int>[v];
            for (int i = 0; i < v; ++i)
                adj[i] = new List<int>();
        }

        // Function to add an edge
        // into the graph
        public void addEdge(int v, int w)
        {
            adj[v].Add(w);
            adj[w].Add(v);
        }

        bool IsCyclicUtil(int v, bool[] visited, int parent)
        {
            visited[v] = true;
            int i;

            foreach (int it in adj[v])
            {
                i = it;

                if (!visited[i])
                {
                    if (IsCyclicUtil(i, visited, v))
                        return true;
                }
                else if (i != parent)
                    return true;
            }
            return false;
        }

        public bool IsTree()
        {
            bool[] visited = new bool[v];

            if (IsCyclicUtil(0, visited, -1))
                return false;

            for (int u = 0; u < v; u++)
            {
                if (visited[u] == false)
                    return false;
            }

            return false;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Graph g1 = new Graph(5);
            g1.addEdge(1, 0);
            g1.addEdge(0, 2);
            g1.addEdge(0, 3);
            g1.addEdge(3, 4);
            if (g1.IsTree())
                Console.WriteLine("Graph is Tree");
            else
                Console.WriteLine("Graph is not Tree");

            Graph g2 = new Graph(5);
            g2.addEdge(1, 0);
            g2.addEdge(0, 2);
            g2.addEdge(2, 1);
            g2.addEdge(0, 3);
            g2.addEdge(3, 4);

            if (g2.IsTree())
                Console.WriteLine("Graph is Tree");
            else
                Console.WriteLine("Graph is not Tree");
            Console.WriteLine("Hello World!");
        }
    }
}
