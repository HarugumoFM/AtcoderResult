namespace AtcoderResult.ADT.M20240530;

internal class G {
    public static void Solve() {
       var N = Int32.Parse(Console.ReadLine()!);

        var dp = new long[N+1,2];

        for(int i=0;i<N;i++) {
            var line = Console.ReadLine()!.Split();
            var a = Int32.Parse(line[0]);
            var b = Int32.Parse(line[1]);
            if(a == 0) {
                dp[i+1,0] = Math.Max(dp[i,0] + b, dp[i,0]);
                dp[i+1,0] = Math.Max(dp[i+1,0],dp[i,1] + b);
                dp[i+1,1] = dp[i,1];
            } else { 
                dp[i+1,0] = dp[i,0];
                dp[i+1,1] = Math.Max(dp[i,1],dp[i,0] + b);
            }
        }
        Console.WriteLine(Math.Max(dp[N,0],dp[N,1]));
    }
}