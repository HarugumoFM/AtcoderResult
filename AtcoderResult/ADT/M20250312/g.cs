namespace AtcoderResult.ADT.M20250312;
internal class G {
    public static void Solve() {
        var inputs = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
        long N = inputs[0];
        long S = inputs[1];
        long T = inputs[2];
        var X = new double[5,N];

        for(int i=0;i<N;i++) {
            inputs = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            var a = inputs[0];
            var b = inputs[1];
            var c = inputs[2];
            var d = inputs[3];
            X[0,i] = a;
            X[1,i] = b;
            X[2,i] = c;
            X[3,i] = d;
            X[4,i] = Math.Sqrt(Math.Pow((a-c),2) + Math.Pow((b-d),2));
        }

        double min = double.MaxValue;
        var list = GetPermutations(Enumerable.Range(0, (int)N).ToArray(), (int)N);
        var count = 0L;
        foreach(var item in list) {
            for(int i=0;i<Math.Pow(2,N);i++) {
                count++;
                double time = 0;
                double lastx = 0;
                double lasty = 0;
                for(int j=0;j<N;j++){
                    var index = item[j];
                    if((i & (1 << j)) == 0) {
                        time += Math.Sqrt(Math.Pow(lastx - X[2,index],2) + Math.Pow(lasty - X[3,index],2))/S;
                        lastx = X[0,index];
                        lasty = X[1,index];
                    } else {
                        time += Math.Sqrt(Math.Pow(lastx - X[0,index],2) + Math.Pow(lasty - X[1,index],2))/S;
                        lastx = X[2,index];
                        lasty = X[3,index];
                    }
                    time += X[4,index]/T;
                }
                min = Math.Min(min,time);
            }
        }
        //Console.WriteLine(count);
        Console.WriteLine(min);
        List<int[]> GetPermutations(int[] array, int length)
        {
            if (length == 1)
                return array.Select(t => new int[] { t }).ToList();

            var permutations = GetPermutations(array, length - 1);

            return array.SelectMany(t => permutations.Where(p => !p.Contains(t)),
                                    (t, p) => p.Concat(new int[] { t }).ToArray()).ToList();
        }
    }
}