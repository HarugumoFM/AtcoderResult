namespace AtcoderResult.ADT.M20250305;

internal class G {

    public static void Solve() {
        var Q = Int64.Parse(Console.ReadLine()!);

        for(int i=0;i<Q;i++) {
            var input = Console.ReadLine()!.Split(' ').Select(Int64.Parse).ToArray();
            var N = input[0];
            var D = input[1];
            var K = input[2];
            var couple = LCM(N,D)/D;
            K--;
            var s = K/couple;
            var p = K%couple;
            var x = (s+p*D)%N;
            Console.WriteLine(x);
        }


        long LCM (long a, long b)
        {
            return a * b / GCD(a, b);
        }

        long GCD(long a,long b) {
            if (a < b) return GCD(b, a);
            while (b != 0) {
                var remainder = a % b;
                a = b;
                b = remainder;
            }
            return a;
        }
    }
}