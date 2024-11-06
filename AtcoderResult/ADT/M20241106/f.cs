namespace AtcoderResult.ADT.M20241106;

using System.Text;
internal class F {
    public static void Solve() {
        var line = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
        var N = line[0];
        var T = line[1];

        var H = new int[N];
        var W = new int[N];
        var cross1 = 0;
        var cross2 = 0;

        line = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
        bool res = false;
        for(int i=0;i<T;i++) {
            res = mark(line[i]);
            if(res) {
                Console.WriteLine(i+1);
                return;
            }
        }
        if(!res) {
            Console.WriteLine(-1);
        }

        bool mark(int X) {
            int h = (X-1)/N;
            int w = (X-1)%N;
            H[h]++;
            W[w]++;
            if(h == w) cross1++;
            if(h+w == N-1) cross2++;
            if(H[h] == N || W[w] == N|| cross1 == N || cross2 == N) return true;
            return false;
        }

    }
}