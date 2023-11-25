namespace AtcoderResult.ABC330;

internal class D{
    public static void Main()
    {
        var N = Int32.Parse(Console.ReadLine()!);

        var W = new long[N];//横の合計

        var H = new long[N];//縦の合計

        var A = new string[N];

        for(int i=0;i<N;i++) {
            var line = Console.ReadLine()!;
            A[i] = line;
            for(int j=0;j<N;j++) {
                if(line[j]=='o') {
                    W[i]++;
                    H[j]++;
                }
            }
        }
        long sum = 0;

        for(int i=0;i<N;i++) {
            for(int j=0;j<N;j++) {
                if(A[i][j]=='o') {
                    sum += (W[i]-1) * (H[j]-1);
                }
            }
        }

        Console.WriteLine(sum);
    }
}