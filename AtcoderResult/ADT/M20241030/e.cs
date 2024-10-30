namespace AtcoderResult.ADT.M20241030;
using System.Collections.Generic;
internal class E {
    public static void Solve() {
        var line = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
        var N = line[0];
        var Q = line[1];

        var A = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
        var dic = new Dictionary<int, int>();
        var set = new SortedSet<int>();

        foreach(var a in A) {
            set.Add(a);
            if(dic.ContainsKey(a)) {
                dic[a]++;
            } else {
                dic[a] = 1;
            }
        }
        var sum = 0;
        foreach(var a in set.Reverse()) {
            sum += dic[a];
            dic[a] = sum;
        }
        var x = set.ToArray();
        var count = x.Length;
        var Max = x[count - 1];
        var Min = x[0];
        for(int i = 0; i < Q; i++) {
            var K = int.Parse(Console.ReadLine());
            if (K > Max) 
                Console.WriteLine(0);
            else if (K <= Min) 
                Console.WriteLine(N);
            else {
                var index = Array.BinarySearch(x, K);
                if(index >= 0) {
                    Console.WriteLine(dic[x[index]]);
                } else {
                    index = ~index;
                    Console.WriteLine(dic[x[index]]);
                }
            }
        }

    }
}