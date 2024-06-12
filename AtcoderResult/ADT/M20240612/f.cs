namespace AtcoderResult.ADT.M20240612;
internal class F {
    public static void Solve() {
        var line = Console.ReadLine()!.Split();
        int H = int.Parse(line[0]);
        int W = int.Parse(line[1]);
        int K = int.Parse(line[2]);

        var Ps = new int[K,2];
        var Hs = new HashSet<int>();
        var Ws = new HashSet<int>();
        var newH = new Dictionary<int,int>();
        var newW = new Dictionary<int,int>();

        for(int i=0;i<K;i++) {
            line = Console.ReadLine()!.Split();
            Ps[i,0] = int.Parse(line[0]);
            Ps[i,1] = int.Parse(line[1]);
            Hs.Add(Ps[i,0]);
            Ws.Add(Ps[i,1]);
        }

        var listH = Hs.OrderBy(x => x).ToList();
        int index = 1;
        foreach(var h in listH) {
            newH.Add(h,index);
            index++;
        }
        var listW = Ws.OrderBy(x => x).ToList();
        index = 1;
        foreach(var w in listW) {
            newW.Add(w,index);
            index++;
        }

        for(int i=0;i<K;i++) {
            Console.WriteLine($"{newH[Ps[i,0]]} {newW[Ps[i,1]]}");
        }
    }
}