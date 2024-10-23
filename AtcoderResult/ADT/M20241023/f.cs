namespace AtcoderResult.ADT.M20241023;

using System.Text;
internal class F {
    public static void Solve() {
        var line = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
        int N = line[0];
        long A = (long)line[1];
        long B = (long)line[2];

        var S = Console.ReadLine()!;

        long min = long.MaxValue;
        for(int i=0;i<N;i++) {
            long cost = (long)i*A;
            if(cost > min) {
                break;
            }
            for(int j=0;j<N/2;j++) {
                //Console.WriteLine((i+j)%N + " " + (i+N-j-1)%N);
                if(S[(i+j)%N] != S[(i+N-j-1)%N]) {
                    cost += B;
                }
            }
            if(min > cost) {
                min = cost;
            }
        }
        Console.WriteLine(min);

    }
}