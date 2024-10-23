namespace AtcoderResult.ADT.M20241023;

internal class G {
    public static void Solve() {
        var N = UInt64.Parse(Console.ReadLine()!);

        var dic = new Dictionary<ulong, ulong>();

        dic.Add(0, 1);

        Console.WriteLine(search(N));

        ulong search(ulong x) {
            if(dic.ContainsKey(x)) {
                return dic[x];
            }
            ulong x1 = x / 2;
            ulong x2 = x/3;
            ulong res = 0;
            if(dic.ContainsKey(x1)) {
                res += dic[x1];
            } else {
                var res1 = search(x1);
                dic.Add(x1, res1);
                res += res1;
            }

            if(dic.ContainsKey(x2)) {
                res += dic[x2];
            } else {
                var res2 = search(x2);
                dic.Add(x2, res2);
                res += res2;
            }
            return res;
        }

    }
}