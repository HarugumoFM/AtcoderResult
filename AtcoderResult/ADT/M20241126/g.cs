namespace AtcoderResult.ADT.M20241126;

internal class G {
    public static void Solve() {
        var input = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

        var a = input[0];
        var b = input[1];

        long count = 0;

        while(a!=b) {
            //Console.WriteLine($"{a} {b}");
            if(a>b) {
                count += a/b;
                a = a%b;
                if(a==0) {
                    count--;
                    break;
                }
            } else {
                count += b/a;
                b = b%a;
                if(b==0) {
                    count--;
                    break;
                }
            }
        }
        Console.WriteLine(count);
    }
}