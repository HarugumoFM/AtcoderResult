namespace AtcoderResult.ABC331;

internal class C{
    public static void Solve()
    {
        var N = Int32.Parse(Console.ReadLine()!);

        var line = Console.ReadLine()!.Split();

        var A = new long[N];
        var list = new List<long>();

        for(int i=0;i<N;i++) {
            var num = Int64.Parse(line[i]);
            A[i] = num;
            list.Add(num);
        }
        list.Sort();
        list.Reverse();
        long sum = 0;
        var dic = new Dictionary<long,long>();
        foreach(var num in list) {
            if(!dic.ContainsKey(num)) {
                dic.Add(num,sum);
            }
            sum += num;
        }
        var res = new List<long>();
        foreach(var num in A) {
            res.Add(dic[num]);
        }
        Console.WriteLine(string.Join(" ",res));
    }
}