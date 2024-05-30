namespace AtcoderResult.ADT.M20240530;

internal class E {
    public static void Solve() {
        int N = Int32.Parse(Console.ReadLine()!);
        int Q = Int32.Parse(Console.ReadLine()!);
        var dic = new Dictionary<int,List<int>>();
        for(int i=1;i<=N;i++) {
            dic.Add(i,new List<int>());
        }

        var dic2 = new Dictionary<int,SortedSet<int>>();

        for(int i=0;i<Q;i++) {
            var line = Console.ReadLine()!.Split();
            var a = Int32.Parse(line[0]);
            var b = Int32.Parse(line[1]);
            if(a == 1) {
                var c = Int32.Parse(line[2]);
                dic[c].Add(b);
                if(!dic2.ContainsKey(b))
                    dic2.Add(b,new SortedSet<int>());
                dic2[b].Add(c);
            } else if(a == 2) {
                dic[b].Sort();
                Console.WriteLine(string.Join(" ",dic[b]));
            } else {
                Console.WriteLine(string.Join(" ",dic2[b]));
            }
        }

    }
}