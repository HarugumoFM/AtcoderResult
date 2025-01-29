namespace AtcoderResult.ADT.M20250115;

internal class E {
    public static void Solve() {
       var inputs = Console.ReadLine()!.Split(' ').Select(long.Parse).ToArray();
        var N = inputs[0];
        var A = inputs[1];
        var B = inputs[2];

        inputs = Console.ReadLine()!.Split(' ').Select(long.Parse).ToArray();
        var P = inputs[0];
        var Q = inputs[1];
        var R = inputs[2];
        var S = inputs[3];

        var min0 = Math.Max(1-A,1-B);
        var max0 = Math.Min(N-A,N-B);
        var min1 = Math.Max(1-A,B-N);
        var max1 = Math.Min(N-A,B-1);

        for(long i=P;i<=Q;i++) {
            for(long j= R;j<=S;j++) {
                var res = ".";
                if(i-A == j-B) {
                    var k = i-A;
                    if(k >=min0 && k<=max0) {
                        res = "#";
                    }
                } 
                if(i-A == B-j) {
                    var k = i-A;
                    if(k >=min1 && k<=max1) {
                        res = "#";
                    }
                }
                Console.Write(res);
            }
            Console.WriteLine();
        }




    }
 
}