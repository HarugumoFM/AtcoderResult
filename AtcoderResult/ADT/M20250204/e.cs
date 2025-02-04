namespace AtcoderResult.ADT.M20250204;
using System.Text;

internal class E {
    public static void Solve() {
        var inputs = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
        var N = inputs[0];
        var M = inputs[1];
        var S = Console.ReadLine()!.Split().ToArray();
        var T = Console.ReadLine()!.Split().ToArray();
        var stops = new HashSet<string>();
        foreach(var t in T) {
            stops.Add(t);
        }
        foreach(var s in S) {
            if(stops.Contains(s)) {
                Console.WriteLine("Yes");
            } else {
                Console.WriteLine("No");
            }
        }
    }
 
}