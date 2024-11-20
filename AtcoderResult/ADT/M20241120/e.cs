namespace AtcoderResult.ADT.M20241120;

internal class E {
    public static void Solve() {
        var line = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int N = line[0];
        int X = line[1];
        int Y = line[2];
        var dic = new Dictionary<int, HashSet<int>>();

        for (int i = 1; i < N; i++)
        {
            line = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if(!dic.ContainsKey(line[0]))
                dic[line[0]] = new HashSet<int>();
            if(!dic.ContainsKey(line[1]))
                dic[line[1]] = new HashSet<int>();
            dic[line[0]].Add(line[1]);
            dic[line[1]].Add(line[0]);
        }
        var visit = new bool[N+1];
        visit[X] = true;
        var stack = new Stack<int>();
        search(X,Y);

        void search(int a, int b) {
            visit[a] = true;
            //Console.WriteLine(a);
            stack.Push(a);
            if (a == b) 
            {
                Console.WriteLine(string.Join(" ", stack.Reverse()));
            }
            if(dic.ContainsKey(a))
            {
                foreach (var next in dic[a])
                {
                    if (visit[next]) continue;
                    search(next, b);
                }
            }
            stack.Pop();
        }

            
    }
 
}