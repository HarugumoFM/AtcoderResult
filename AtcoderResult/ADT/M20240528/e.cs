namespace AtcoderResult.ADT.M20240528;

internal class E {
    public static void Solve() {
        var line = Console.ReadLine()!.Split();

        int N = Int32.Parse(line[0]);
        int X = Int32.Parse(line[1]);

        var before = new HashSet<int>();
        var after = new HashSet<int>();

        before.Add(0);

        for(int i=0;i<N;i++) {
            line = Console.ReadLine()!.Split();
            int a = Int32.Parse(line[0]);
            foreach(var x in before) {
                after.Add(x+a);
            }
            int b = Int32.Parse(line[1]);
            foreach(var x in before) {
                after.Add(x+b);
            }
            before = after;
            after = new HashSet<int>();
        }

        if(before.Contains(X)) {
            Console.WriteLine("Yes");
        } else {
            Console.WriteLine("No");
        }
    }
}