namespace AtcoderResult.ADT.M20250401;
internal class G {
    public static void Solve() {
        var inputs = Console.ReadLine()!.Split(' ').Select(long.Parse).ToArray();
        var N = inputs[0];
        var x = inputs[1];
        var y = inputs[2];
        var A = Console.ReadLine()!.Split(' ').Select(long.Parse).ToArray();
        var setX = new HashSet<long>();
        var setY = new HashSet<long>();
        setX.Add(A[0]);
        setY.Add(0);
        for (long i=1; i<N; i++)
        {
            var a = A[i];
            if(i%2 == 0) {
                var newSetX = new HashSet<long>();
                foreach (var x1 in setX) {
                    var x2 = x1 + a;
                    newSetX.Add(x2);
                    x2 = x1 - a;
                    newSetX.Add(x2);
                }
                setX = newSetX;
            } else {
                var newSetY = new HashSet<long>();
                foreach (var y1 in setY) {
                    //Console.WriteLine("t:"+y1);
                    var y2 = y1 + a;
                    newSetY.Add(y2);
                    y2 = y1 - a;
                    newSetY.Add(y2);
                }
                setY = newSetY;
            }
        }
        if(setX.Contains(x) && setY.Contains(y)) {
            Console.WriteLine("Yes");
        } else {
            Console.WriteLine("No");
        }

    }
}