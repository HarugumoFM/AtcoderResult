namespace AtcoderResult.ADT.M20240612;

internal class G {
    public static void Solve() {
        var N = Int32.Parse(Console.ReadLine()!);

        var A = Console.ReadLine()!.Split().Select(Int32.Parse).ToArray();

        var dp = new int[10,N];
        int x = A[0];
        int y = A[1];
        dp[(x+y)%10,1]++;
        dp[(x*y)%10,1]++;
        int Z =998244353;
        for(int i = 2; i < N; i++)
        {
            for(int j = 0; j < 10; j++)
            {
                if(dp[j,i-1] > 0)
                {
                    x = j;
                    y = A[i];
                    dp[(y+x)%10,i] = (dp[(y+x)%10,i]+dp[j,i-1])%Z;
                    dp[(y*x)%10,i] = (dp[(y*x)%10,i]+dp[j,i-1])%Z;
                }
            }
        }
        for(int i=0;i<10;i++)
        {
            Console.WriteLine(dp[i,N-1]);
        }
    }
}