namespace AtcoderResult.ADT.M20241009;

using System.Text;
internal class F {
    public static void Solve() {
        var line = Console.ReadLine()!.Split(' ').Select(long.Parse).ToArray();
        long H = line[0];
        long W = line[1];
        long N = line[2];
        var P = new long[2,N];
        var setH = new SortedSet<long>();
        var setW = new SortedSet<long>();
        var dicH = new Dictionary<long,long>();
        var dicW = new Dictionary<long,long>();
        for (long i = 0; i < N; i++)
        {
            var p = Console.ReadLine()!.Split(' ').Select(long.Parse).ToArray();
            setH.Add(p[0]);
            setW.Add(p[1]);
            P[0,i] = p[0];
            P[1,i] = p[1];
        }

        long count = 1;
        foreach (var h in setH)
        {
            dicH.Add(h, count);
            count++;
        }
        count = 1;
        foreach (var w in setW)
        {
            dicW.Add(w, count);
            count++;
        }
        for(int i=0;i<N;i++) {
            Console.WriteLine(dicH[P[0,i]] + " " + dicW[P[1,i]]);
        }

    }
}