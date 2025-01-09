namespace AtcoderResult.ADT.M20250108;

internal class G {
    public static void Solve() {
        var input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
        var N = input[0];
        var M = input[1];
        var A = new int[N+1];
        var B = new int[M+1];
        var C = new int[N+M+1];

        var inputs = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
        for (int i = 0; i <= N; i++)
        {
            A[i] = inputs[i];
        }
        inputs = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
        for (int i = 0; i <= N+M; i++)
        {
            C[i] = inputs[i];
        }
        int start2 = M;
        int count = 1;
        for(int i=N+M;i>=0;i--) {
            int start = Math.Min(i, N);
            int index = start2;
            for(int j=0;j<count;j++) {
                C[i] -= A[i-start2-j] * B[start2+j];
                //Console.WriteLine(B[start2+j]+"+"+A[i-start2-j]+" "+B[start2+j]);
            }
            //Console.WriteLine(C[i]+" "+A[start]);
            B[i-start] = C[i]/A[start];
            //Console.WriteLine(B[i-start]);
            if(start2 == 0)
                break;
            if(count<Math.Min(M,N)+1)
                count++;
            if(start2>0)
                start2--;
        }
        Console.WriteLine(string.Join(" ", B));




    }
}