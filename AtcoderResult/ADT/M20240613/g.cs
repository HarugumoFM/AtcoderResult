namespace AtcoderResult.ADT.M20240613;
using System.Text;

internal class G {
    public static void Solve() {
        var line = Console.ReadLine()!.Split();
        var N = int.Parse(line[0]);
        var M = int.Parse(line[1]);

        var X = new bool?[N];

        var S = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
        var T = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

        var dic = new Dictionary<int, HashSet<int>>();

        bool res = true;
        for(int i=0;i<M;i++) {
            Add(S[i],T[i]);
        }
        void Add(int x, int y) {
            if(!dic.ContainsKey(x)) {
                dic.Add(x,new HashSet<int>());
            }
            if(!dic.ContainsKey(y)) {
                dic.Add(y,new HashSet<int>());
            }
            dic[x].Add(y);
            dic[y].Add(x);

        }

        for(int i=1;i<=N;i++) {
            if(X[i-1] is null) {
                res &= write(i, true);
            }
        }
        Console.WriteLine(res ? "Yes" : "No");

        bool write(int i, bool b) {
            if(X[i-1] is null) {
                X[i-1] = b;
                var res1 = true;
                if(dic.ContainsKey(i)) {
                    foreach(var j in dic[i]) {
                        res1 &= write(j, !b);
                    }
                }
                return res1;
            } else if(X[i-1] == b){
                return true;
            } else {
                return false;
            }
        }

    }
}