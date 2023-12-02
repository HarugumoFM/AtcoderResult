namespace AtcoderResult.ADT.M20231128;

internal class G{
    public static void Solve()
    {
        var N = Int32.Parse(Console.ReadLine()!);

        for(int i=0;i<N;i++) {
            var line = Console.ReadLine()!.Split();
            long a = Int64.Parse(line[0]);
            long s = Int64.Parse(line[1]);

            if(a*2>s) {
                Console.WriteLine("No");
            } else {
                long sub = s - 2 * a;
                for(long mask =1;mask<=sub;mask=mask*2) {
                    if((mask & a)==0 && (sub&mask) >0) {
                        sub-=mask;
                    }
                }
                if(sub==0)
                    Console.WriteLine("Yes");
                else
                    Console.WriteLine("No");
            }
        }
    }
}