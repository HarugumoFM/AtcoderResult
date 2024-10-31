namespace AtcoderResult.ADT.M20241031;
internal class E {
    public static void Solve() {
        var line = Console.ReadLine().Split(' ');
        var N = Int32.Parse(line[0]);
        var M = Int32.Parse(line[1]);
        var dic1 = new Dictionary<int, HashSet<int>>();
        var dic2 = new int[M,2];
        for(int i=0;i<M;i++) {
            line = Console.ReadLine().Split(' ');
            var a = Int32.Parse(line[0]);
            var b = Int32.Parse(line[1]);
            if(!dic1.ContainsKey(a)) {
                dic1[a] = new HashSet<int>();
            }
            if(!dic1.ContainsKey(b)) {
                dic1[b] = new HashSet<int>();
            }
            dic1[a].Add(b);
            dic1[b].Add(a);
        }

        for(int i=0;i<M;i++) {
            line =  Console.ReadLine().Split(' ');
            int a = Int32.Parse(line[0]);
            int b = Int32.Parse(line[1]);
            dic2[i,0] = a;
            dic2[i,1] = b;
        }
        var p = "";
        for(int i=1;i<=N;i++) {
            p+=i.ToString();
        }
        var permutations = GetPermutations(p);
        bool res = false;
        foreach(var perm in permutations) {
            bool flag = true;
            for(int i=0;i<M;i++) {
                int a = dic2[i,0];
                int b = dic2[i,1];
                int _a = perm[a-1]- '0';
                int _b = perm[b-1] -'0';
                if(!dic1.ContainsKey(_a) || !dic1[_a].Contains(_b)) {
                    flag = false;
                    break;
                }    
            }
            if(flag) {
                res = true;
                break;
            }
        }
        Console.WriteLine(res ? "Yes" : "No");

        List<string> GetPermutations(string input)
        {
            var results = new List<string>();
            var exists = new HashSet<string>();
            if (input.Length == 1)
            {
                results.Add(input);
            }
            else
            {
                for (int i = 0; i < input.Length; i++)
                {
                    var firstChar = input[i];
                    var charsLeft = input.Substring(0, i) + input.Substring(i + 1);
                    var innerPermutations = GetPermutations(charsLeft);
                    foreach (var permutation in innerPermutations)
                    {
                        if(exists.Contains(firstChar + permutation)) continue;
                        results.Add(firstChar + permutation);
                        exists.Add(firstChar + permutation);
                    }
                }
            }
            return results;
        }


    }
}