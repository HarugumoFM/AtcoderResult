namespace AtcoderResult.ADT.M20250219;

internal class G {

    public static void Solve() {
        var inputs = Console.ReadLine()!.Split().Select(long.Parse).ToArray();
        var N = inputs[0];
        var A = inputs[1];
        var B = inputs[2];

        var allSUM = (1+ N)*N/2;

        var a1 = N/A;
        long ASUM = 0;
        if(A <= N) ASUM = A*(1+a1)*a1/2;
        else ASUM = 0;

        var b1 = N/B; 
        long BSUM = 0;
        if(B <= N) BSUM = B*(1+(N/B))*((N/B))/2;
        else BSUM = 0;

        var lcm = LCM(A,B);
        var ab1 = N/lcm;
        long ABSUM = 0;
        if(lcm > N) ABSUM = 0;
        else ABSUM = lcm*(1+ab1)*ab1/2;

        Console.WriteLine(allSUM - ASUM - BSUM + ABSUM);

        long GCD(long a, long b)
            {
                while (b != 0)
                {
                    long temp = b;
                    b = a % b;
                    a = temp;
                }
                return a;
            }

            long LCM(long a, long b)
            {
                return (a / GCD(a, b)) * b;
            }
    }
}