namespace AtcoderResult.ADT.M20250212;

internal class G {

    public static void Solve() {
        var N = Int64.Parse(Console.ReadLine()!);
        var inputs = Console.ReadLine()!.Split(' ').Select(long.Parse).ToArray();
        var dp = new long[N+1, 2];

        for (int i = 1; i <= N; i++)
        {
            if(i== 1) {
                dp[i, 1] = inputs[i-1];
            } else {
                dp[i, 0] = Math.Max(dp[i-1,0], dp[i-1,1] + inputs[i-1]*2);
                dp[i, 1] = Math.Max(dp[i-1,1], dp[i-1,0] + inputs[i-1]);
            }
        }
        Console.WriteLine(Math.Max(dp[N,0], dp[N,1]));
    }
}