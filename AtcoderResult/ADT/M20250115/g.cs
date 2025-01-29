namespace AtcoderResult.ADT.M20250115;

internal class G {
    public static void Solve() {
       var S = Console.ReadLine()!;
        var T = Int64.Parse(Console.ReadLine()!);

        var L = S.Length;
        long res = 0;
        long mask = 1;
        int index = 0;
        var set = new HashSet<long>();
        for(int i=L-1;i>=0;i--) {
            if(S[i] == '1') {
                res += mask;
            } else if(S[i] == '?') {
                set.Add(mask);
            }
            mask = mask << 1;
        }
        if(res > T) 
            Console.WriteLine(-1);
        else {
            var a = set.ToArray();
            Array.Reverse(a);
            foreach(var m in a) {
                //nsole.WriteLine(m);
                if(res + m <= T) {
                    res+=m;
                }
            }
            Console.WriteLine(res);
        }


    }
}