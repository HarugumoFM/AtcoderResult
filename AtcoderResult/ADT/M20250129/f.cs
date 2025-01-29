namespace AtcoderResult.ADT.M20250129;

using System.Text;
internal class F {
    public static void Solve() {
        var N = Int64.Parse(Console.ReadLine());
        var S = Console.ReadLine();

        long x = 0;
        long y = 0;

        var dic = new Dictionary<long, HashSet<long>>();
        dic[0] = new HashSet<long>();
        dic[0].Add(0);

        bool res = false;
        for(int i=0;i<N;i++) {
            if(S[i] == 'U') {
                res |= go(0, 1);
            } else if(S[i] == 'D') {
                res |= go(0, -1);
            } else if(S[i] == 'L') {
                res |= go(-1, 0);
            } else if(S[i] == 'R') {
                res |= go(1, 0);
            }
        }
        if(res) {
            Console.WriteLine("Yes");
        } else {
            Console.WriteLine("No");
        }

        bool go(long xi, long yi) {
            x+=xi;
            y+=yi;
            if(dic.ContainsKey(x) && dic[x].Contains(y)) {
                return true;
            } else {
                if(!dic.ContainsKey(x)) {
                    dic[x] = new HashSet<long>();
                }
                dic[x].Add(y);
                return false;
            }
        }
    }
}