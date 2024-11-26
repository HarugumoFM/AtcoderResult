namespace AtcoderResult.ADT.M20241126;

using System.Text;
internal class F {
    public static void Solve() {
        var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var x = input[0];
        var y = input[1];
        var x1 = input[2];
        var y1 = input[3];

        var dic = new Dictionary<int, HashSet<int>>();

        dic.Add(x+1, new HashSet<int>());
        dic.Add(x-1, new HashSet<int>());
        dic.Add(x+2, new HashSet<int>());
        dic.Add(x-2, new HashSet<int>());

        dic[x+1].Add(y+2);
        dic[x+1].Add(y-2);
        dic[x-1].Add(y+2);
        dic[x-1].Add(y-2);
        dic[x+2].Add(y+1);
        dic[x+2].Add(y-1);
        dic[x-2].Add(y+1);
        dic[x-2].Add(y-1);
        bool res = false;

        if(dic.ContainsKey(x1+1) && dic[x1+1].Contains(y1+2)) {
            res = true;
        }
        if(dic.ContainsKey(x1+1) && dic[x1+1].Contains(y1-2)) {
            res = true;
        }
        if(dic.ContainsKey(x1-1) && dic[x1-1].Contains(y1+2)) {
            res = true;
        }
        if(dic.ContainsKey(x1-1) && dic[x1-1].Contains(y1-2)) {
            res = true;
        }
        if(dic.ContainsKey(x1+2) && dic[x1+2].Contains(y1+1)) {
            res = true;
        }
        if(dic.ContainsKey(x1+2) && dic[x1+2].Contains(y1-1)) {
            res = true;
        }
        if(dic.ContainsKey(x1-2) && dic[x1-2].Contains(y1+1)) {
            res = true;
        }
        if(dic.ContainsKey(x1-2) && dic[x1-2].Contains(y1-1)) {
            res = true;
        }

        Console.WriteLine(res ? "Yes" : "No");


    }
}