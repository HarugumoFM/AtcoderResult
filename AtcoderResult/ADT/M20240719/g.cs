namespace AtcoderResult.ADT.M20240719;
using System.Text;

internal class G {
    public static void Solve() {
        var T = Int64.Parse(Console.ReadLine()!);
        for (int i = 0; i < T; i++)
        {
            var line = Console.ReadLine()!.Split();
            var N = Int64.Parse(line[0]);
            var D = Int64.Parse(line[1]);
            var K = Int64.Parse(line[2]);
            var L = LCM(N, D);
            var set = L/D;
            K--;
            var x = K/set;
            var y = K%set;
            var target = (y*D+x)%N;
            Console.WriteLine(target);
        }


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
            return Math.Abs(a*b)/GCD(a, b);
        }

    }
}