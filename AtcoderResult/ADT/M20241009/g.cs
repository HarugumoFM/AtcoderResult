namespace AtcoderResult.ADT.M20241009;

internal class G {
    public static void Solve() {
        var line = Console.ReadLine()!.Split(' ');
        int N = int.Parse(line[0]);
        int M = int.Parse(line[1]);

        var A = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var B = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        var dp = new bool?[N];
        var dic = new Dictionary<int, HashSet<int>>();
        for (int i = 0; i < M; i++)
        {
            if (!dic.ContainsKey(A[i]))
            {
                dic[A[i]] = new HashSet<int>();
            }
            if (!dic.ContainsKey(B[i]))
            {
                dic[B[i]] = new HashSet<int>();
            }
            dic[A[i]].Add(B[i]);
            dic[B[i]].Add(A[i]);
        }

        bool result = true;
        for(int i=1;i<=N;i++) {
            if(dp[i-1] == null) {
                result &= search(i, true);
            }
            if(!result)
                break;
        }
        if(result) {
            Console.WriteLine("Yes");
        } else {
            Console.WriteLine("No");
        }

        bool search(int x, bool mark) {
            bool res = true;
            if(dp[x-1] != null ) {
                return dp[x-1] == mark;
            } else {
                dp[x-1] = mark;
            }
            if(dic.ContainsKey(x)) {
                foreach (var item in dic[x])
                {
                    res &= search(item, !mark);
                }
            }
            return res;
        }

    }
}