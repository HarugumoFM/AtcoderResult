namespace AtcoderResult.ADT.M20240508;

internal class E {
    public static void Main() {
        var N = Int32.Parse(Console.ReadLine()!);

        var A = new int[N];

        var line = Console.ReadLine()!.Split();
        long sameCount = 0;

        for (var i = 0; i < N; i++)
        {
            A[i] = Int32.Parse(line[i]);
            if(A[i] == i + 1)
            {
                sameCount++;
            }
        }
        long result = 0;

        for(int i=0;i<N;i++) {
            if(A[i] == i+1)
                continue;
            if(A[A[i]-1] == i+1) 
                result++;
        }
        result = result/2;
        result += sameCount*(sameCount-1)/2;

        Console.WriteLine(result);
    }
}