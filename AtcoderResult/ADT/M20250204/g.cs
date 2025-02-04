namespace AtcoderResult.ADT.M20250204;

internal class G {
    public static void Solve() {
        long mask = 998244353;
        var n = int.Parse(Console.ReadLine()!);

        var A = Console.ReadLine()!.Split().ToArray();
        var Ax = new long[n,2];
        for(int i=0;i<n;i++) {
            Ax[i,0] = long.Parse(A[i]);
            Ax[i,1] = A[i].Length;
        }
        var B = new long[11];
        long t = 1;
        for(int i=0;i<11;i++) {
            B[i] = t;
            t = (t*10)%mask;
        }
        var Ay = new long[n,2];
        var s = 0L;
        for(int i=n-1;i>=0;i--) {
            Ay[i,0] = Ax[i,0];
            //Console.WriteLine(Ay[i,0]+" "+s);
            Ay[i,1] = s;
            s = (s + B[Ax[i,1]])%mask;
        }
        var sum = 0L;
        for(int i=0;i<n;i++) {
            sum = (sum + (Ax[i,0]*Ay[i,1])%mask)%mask;
            sum = (sum + (Ay[i,0]* i)%mask)%mask;
        }
        Console.WriteLine(sum);
    }
}