namespace AtcoderResult.ABC321;

using System;
using System.Collections.Generic;
class D{
    public static void Solve()
    {
        var line = Console.ReadLine().Split();

        int N = Int32.Parse(line[0]);

        int M = Int32.Parse(line[1]);

        var max = Int64.Parse(line[2]);

        line = Console.ReadLine().Split();

        var A = new long[N];

        for(int i=0;i<N;i++) {
            var num = Int64.Parse(line[i]);
            A[i] = num;
        }

        line = Console.ReadLine().Split();

        var list = new List<int>();

        foreach(var s in line) {
            var num = Int32.Parse(s);
            list.Add(num);
        }
        list.Sort();
        var B = list.ToArray();
        list = null;
        int index = 0;
        var subs = new int[max+1];
        var sums = new long[M+1];
        for(int i=1;i<=M;i++) {
            sums[i] = sums[i-1] + B[i-1];
        }
        for(int i=0;i<=max;i++) {
            while(true){
                if(index >= M-1)
                    break;
                if(B[index+1] <=i)
                    index++;
                else
                    break;
            }
            if(B[0] > i)
                subs[i] = 0;
            else 
                subs[i] = index+1;
        }
        long sum = 0;
        foreach(var i in A) {
            var sub = max - i;
            if(sub <0)
                sub = 0;
            long sum1 = 0;
            sum += (long)subs[sub] * i + sums[subs[sub]] + max * (M-(long)subs[sub]);
        }

        Console.WriteLine(sum);
    }
}