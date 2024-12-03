namespace AtcoderResult.ADT.M20241203;

internal class G {
    public static void Solve() {
        var Q = int.Parse(Console.ReadLine()!);

        const long mask = 998244353;
        var dp = new long[Q+1, 10];
        for(long i=1;i<=9;i++) {
            dp[1, i] = i;
        }

        for(var i=2;i<=Q;i++) {
            for(int j=1;j<=9;j++) {
                dp[i, j] = (dp[i-1, j] * 10)%mask;
            }
        }

        var ans = new long[Q+1];
        var start =0;
        var end = 0;
        ans[0] = 1;

        long answer = 1;
        for(int i=0;i<Q;i++) {
            var input = Console.ReadLine()!.Split(' ').Select(long.Parse).ToArray();
            var q1 = input[0];
            if(q1 == 1) {
                var q2 = input[1];
                end++;
                ans[end] = q2;
                answer = (answer*10 + q2)%mask;
            } else if(q1 == 2) {
                int count = end - start + 1;
                answer = (mask+answer - dp[count, ans[start]])%mask;
                start++;
            } else {
                Console.WriteLine(answer);
            }
        }



    }
}