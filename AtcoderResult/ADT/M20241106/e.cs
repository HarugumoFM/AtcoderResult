namespace AtcoderResult.ADT.M20241106;

internal class E {
    public static void Solve() {
        long N = Int64.Parse(Console.ReadLine()!);
        long[] A = Console.ReadLine()!.Split().Select(Int64.Parse).ToArray();
        long X = Int64.Parse(Console.ReadLine()!);
        long sum = A.Sum();
        long count = X / sum;
        long sub = X % sum;
        long ans = count * N;
        for(int i=0;i<N;i++) {
            if(sub < 0) {
                break;
            }
            sub -= A[i];
            ans++;
        }
        Console.WriteLine(ans);
            
    }
 
}