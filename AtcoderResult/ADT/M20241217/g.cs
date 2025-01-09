namespace AtcoderResult.ADT.M20241217;

internal class G {
    public static void Solve() {
        var S = Console.ReadLine()!;
        var T = new bool[26];
        var dic = new Dictionary<int,HashSet<char>>();
        int level = 0;
        dic.Add(level,new HashSet<char>());
        bool res = true;
        for (int i=0;i<S.Length;i++)
        {
            if(S[i] == '(') {
                level++;
                if(!dic.ContainsKey(level)) {
                    dic.Add(level,new HashSet<char>());
                }
            } else if(S[i] == ')') {
                foreach(var c in dic[level]) {
                    T[c-'a'] = false;
                }
                dic[level].Clear();
                level--;
            } else {
                    dic[level].Add(S[i]);
                    if(T[S[i]-'a']) {
                        res = false;
                        break;
                    } else {
                        T[S[i]-'a'] = true;
                    }
                
            }
        }
        Console.WriteLine(res ? "Yes" : "No");

    }
}