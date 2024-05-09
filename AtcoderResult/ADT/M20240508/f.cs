namespace AtcoderResult.ADT.M20240508;

internal class F {
    public static void Main() {
        var N = Int32.Parse(Console.ReadLine()!);

        var A = new int[N];

        long sum = 0;

        var sums = new long[N+1];

        var nums = Console.ReadLine()!.Split();
        for (int i = 0; i < N; i++)
        {
            A[i] = Int32.Parse(nums[i]);
            sum += A[i];
            sums[i+1] = sum;
        }
        long count = 0;
        long X = Int64.Parse(Console.ReadLine()!);

        count += X/sum;

        count *= N; 

        X = X%sum;

        for(int i=1;i<=N;i++)
        {
            if(sums[i] > X)
            {
                count += i;
                break;
            }
            
        }

        Console.WriteLine(count);
    }
}