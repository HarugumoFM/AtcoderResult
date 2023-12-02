
namespace AtcoderResult.ADT.M20231128;

internal class E{
    public static void Solve()
    {
        var N = Int32.Parse(Console.ReadLine()!);

        var dic = new Dictionary<int,long>();
        for(int i=1;i<N;i++) {
            long tSum = 0;
            long limit = (long)Math.Sqrt(i);
            for(int j=1;j<=limit;j++) {
                if(i%j==0)
                    tSum++;
            }
            if(limit * limit == i) {
                dic.Add(i,tSum*2-1);
            } else {
                dic.Add(i,tSum*2);
            }
        }


        long sum = 0;

        for(int i=1;i<N;i++) {
            sum += dic[i] * dic[N-i];
        }
        Console.WriteLine(sum);
    }
}