namespace AtcoderResult.ABC327;

internal class D{
    public static void Main()
    {
        var line = Console.ReadLine()!.Split();

        int N = Int32.Parse(line[0]);
        int M = Int32.Parse(line[1]);

        var A = new bool?[N];
        var visit = new HashSet<int>();

        var dic = new Dictionary<int, HashSet<int>>();
        line = Console.ReadLine()!.Split();

        var line2 = Console.ReadLine()!.Split();
        for(int i=0;i<M;i++) {
            int x = Int32.Parse(line[i]);
            int y = Int32.Parse(line2[i]);
            PathAdd(x,y);
        }

        bool res = true;

        for(int i=1;i<=N;i++) {
            if(visit.Contains(i)) {
                search(i, true);
            }
        }

        if(res) 
            Console.WriteLine("Yes");
        else
            Console.WriteLine("No");

        void search(int N, bool x) {
            //Console.WriteLine(N +"" + x);
            if(A[N-1] is null) {
                A[N-1] = x;
            } else if(x != A[N-1]){
                res = false;
            } 
            if(visit.Contains(N) && res){
                visit.Remove(N);
                if(dic.ContainsKey(N)) {
                    foreach(var n in dic[N]) {
                        search(n, !x);
                    }
                }
            }
        }



        void PathAdd(int a, int b) {
            visit.Add(a);
            visit.Add(b);
            if(!dic.ContainsKey(a)) {
                dic.Add(a, new HashSet<int>());
            }
            if(!dic.ContainsKey(b)) {
                dic.Add(b, new HashSet<int>());
            }
            dic[a].Add(b);
            dic[b].Add(a);
        }
    }
}