namespace AtcoderResult.ADT.M20250108;

using System.Text;
internal class F {
    public static void Solve() {
        var input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
        var N = input[0];
        var K = input[1];

        var S = new int[N,26];

        for (int i = 0; i < N; i++) {
            var c = Console.ReadLine();
            for (int j = 0; j < c.Length; j++)
            {
                S[i,c[j] - 'a']++;
            }
        }
        int max = 0;

        for(int i=1;i<Math.Pow(2,N);i++) {
            int mask = 1;
            var count = new int[26];
            for(int j=0;j<N;j++) {
                if((i & mask) != 0) {
                    for(int k=0;k<26;k++) {
                        count[k] += S[j,k];
                    }
                }
                mask <<= 1;
            }
            var c = count.Count(x => x == K);
            if(c > max) {
                max = c;
            }
        }
        Console.WriteLine(max);

    }
}