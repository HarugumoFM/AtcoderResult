namespace AtcoderResult.ADT.M20241031;
using System.Collections.Generic;

internal class G {
    public static void Solve() {
        var M = Int32.Parse(Console.ReadLine()!);
        var routes = new Dictionary<int, HashSet<int>>();

        for(int i=0;i<M;i++) {
            var line = Console.ReadLine()!.Split();
            var a = Int32.Parse(line[0]);
            var b = Int32.Parse(line[1]);
            if(!routes.ContainsKey(a)) routes[a] = new HashSet<int>();
            if(!routes.ContainsKey(b)) routes[b] = new HashSet<int>();
            routes[a].Add(b);
            routes[b].Add(a);
        }
        var line2 = Console.ReadLine()!.Split();
        var X = new int[9]{9,9,9,9,9,9,9,9,9};
        string start = "123456789";

        for(int i=0;i<8;i++) {
            var a = Int32.Parse(line2[i]);
            X[a-1] = i+1;
        }
        string S = string.Join("", X);

        var costs = new Dictionary<string, int>();

        var queue = new PriorityQueue<string,int>();
        queue.Enqueue(start,0);
        search();
        if(costs.ContainsKey(S)) {
            Console.WriteLine(costs[S]);
        } else {
            Console.WriteLine(-1);
        }

        void search() {
            //123456789からダイクストラ法
            while(queue.TryDequeue(out string current, out int cost)) { 
                if(costs.ContainsKey(current)) continue;
                costs[current] = cost;
                int index = current.IndexOf('9');
                if(!routes.ContainsKey(index+1)) continue;
                foreach(var x in routes[index+1]) {
                    var next = current.ToCharArray();
                    next[index] = next[x-1];
                    next[x-1] = '9';
                    var nextStr = new string(next);
                    if(!costs.ContainsKey(nextStr)) {
                        queue.Enqueue(nextStr, cost+1);
                    }
                }
            }
        }
    }
}