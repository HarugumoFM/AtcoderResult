namespace AtcoderResult.ADT.M20240704;

using System.Text;
internal class E {
    public static void Solve() {
      
        var visit = new SortedSet<long>();

        var n = long.Parse(Console.ReadLine()!);

        var dic = new Dictionary<long, HashSet<long>>();

        for(int i=0;i<n;i++) {
            var line = Console.ReadLine()!.Split();
            long a = long.Parse(line[0]);
            long b = long.Parse(line[1]);
            Add(a, b);
        }

        Search(1);
        Console.WriteLine(visit.Max);

        void Add(long a, long b) {
            if(!dic.ContainsKey(a)) dic.Add(a, new HashSet<long>());
            if(!dic.ContainsKey(b)) dic.Add(b, new HashSet<long>());
            dic[a].Add(b);
            dic[b].Add(a);
        } 


        int Search(long n) {
            if(visit.Contains(n))  return -1;
            visit.Add(n);
            if(dic.ContainsKey(n)) {
                foreach(var next in dic[n]) {
                    Search(next);
                }
            }
            return 0;
        }
    }
}