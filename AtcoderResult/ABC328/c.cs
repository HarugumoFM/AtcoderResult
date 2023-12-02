namespace AtcoderResult.ABC328;

class C{
    public static void Solve()
    {
        var line= Console.ReadLine()!.Split();

        int N = Int32.Parse(line[0]);

        int Q  = Int32.Parse(line[1]);

        var S = Console.ReadLine();

        var counts = new int[N+1];

        char lastS = '1';

        for(int i=1;i<=N;i++) {
            if(S[i-1] == lastS) 
                counts[i] = counts[i-1]+1;
            else
                counts[i] = counts[i-1];

            lastS = S[i-1];
        }
        for(int i=0;i<Q;i++) {
            line = Console.ReadLine()!.Split();
            int l = Int32.Parse(line[0]);
            int r = Int32.Parse(line[1]);
            Console.WriteLine(counts[r]-counts[l]);
        }
    }
}