using System;
using System.Collections.Generic;

namespace GraphsBasic
{
    class Graph
    {
        private int v;
        private List<int>[] adj;

        public Graph(int v)
        {
            this.v = v;
            adj = new List<int>[v];
            for (int i = 0; i < v; i++)
            {
                adj[i] = new List<int>();
            }
        }

        public void AddEdge(int u, int v)
        {
            adj[u].Add(v);
            adj[v].Add(u);
        }

        public void BFS(int s)
        {
            bool[] visited = new bool[v];

            BFSUtil(s, visited);
        }

        private void BFSUtil(int s, bool[] visited)
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(s);
            visited[s] = true;
            int count = q.Count;
            while (count > 0)
            {
                int val = q.Dequeue();
                Console.Write($"{val}, ");
                List<int> temp = adj[val];

                foreach (int i in temp)
                {
                    if (visited[i] == false)
                    {
                        visited[i] = true;
                        q.Enqueue(i);
                    }
                }

                count = q.Count;
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*   1 -----  0 ---- 3
             *            |      |
             *            |      |
             *            2 ---- 4
             *   
             *   
             * 
             */
            Graph g = new Graph(5);
            g.AddEdge(1, 0);
            g.AddEdge(0, 2);
            g.AddEdge(0, 3);
            g.AddEdge(3, 4);
            g.AddEdge(2, 4);

            g.BFS(2);

        }
    }
}
