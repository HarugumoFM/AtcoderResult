using System;
using System.Collections.Generic;
using System.Linq;

namespace AtcoderResult.ABC315
{
    internal class e
    {
         Dictionary<int, HashSet<int>> graph;
         HashSet<int> visit;

        public void Main()
        {
            graph = new Dictionary<int, HashSet<int>>();
            visit = new HashSet<int>();

            var N = Int32.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                var list = new HashSet<int>();
                var lines = Console.ReadLine().Split();
                var num = Int32.Parse(lines[0]);
                if (num > 0)
                {
                    for (int j = 1; j <= num; j++)
                    {
                        int x = Int32.Parse(lines[j]);
                        list.Add(x);
                    }
                }
                graph.Add(i, list);
            }

            search(1);

            var result = tsort(graph);
            visit.Remove(1);
            var res = new List<int>();
            foreach (int i in result)
            {
                if (visit.Contains(i))
                {
                    res.Add(i);
                }
            }
            res.Reverse();
            Console.WriteLine(string.Join(" ", res));
        }



void search(int n)
{
    if (!visit.Contains(n))
    {
        visit.Add(n);
        foreach (var num in graph[n])
        {
            if (!visit.Contains(num))
                search(num);
        }
    }
}


List<int> tsort(Dictionary<int, HashSet<int>> graph)
{
    List<int> result = new List<int>();

    Dictionary<int, int> indegree = new Dictionary<int, int>();

    foreach (var node in graph.Keys)
    {
        if (!indegree.ContainsKey(node))
        {
            indegree[node] = 0;
        }
        foreach (var neighbor in graph[node])
        {
            if (!indegree.ContainsKey(neighbor))
            {
                indegree[neighbor] = 0;
            }
            indegree[neighbor]++;
        }
    }

    // 入次数が0のノードをキューに入れる
    Queue<int> queue = new Queue<int>();
    foreach (var node in indegree.Keys)
    {
        if (indegree[node] == 0)
            queue.Enqueue(node);
    }

    while (queue.Count > 0)
    {
        //点を一つ消す
        int node = queue.Dequeue();
        result.Add(node);
        //消した点との隣接数を減らす
        foreach (var neighbor in graph[node])
        {
            indegree[neighbor]--;
            if (indegree[neighbor] == 0)
            {
                queue.Enqueue(neighbor);
            }
        }
    }
    return result;
}

        



    }
}
