namespace AtcoderResult.ADT.M20241203;

internal class E {
    public static void Solve() {
        var input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
        var N = input[0];
        var M = input[1];

        int ans = (int)Math.Pow(2, N) -1;
        //Console.WriteLine(ans);
        var C = new int[M];

        long count = 0;
        for(int i=0;i<M;i++) {
            var num = Int32.Parse(Console.ReadLine()!);
            var A = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
            foreach(var a in A) {
                C[i] |= 1 << (a-1);
            }
            //Console.WriteLine(C[i]);
        }

        for(int i=1;i<Math.Pow(2,M);i++) {
            int k = 0;
            for(int j=0;j<M;j++) {
                if((i &((int)Math.Pow(2,j))) >0) {
                    k |= C[j];
                }
            }
            //Console.WriteLine(k);
            if(k == ans)
                count++;
        }
        Console.WriteLine(count);

    }
 
}