namespace AtcoderResult.ADT.M20250129;
using System.Text;

internal class E {
    public static void Solve() {
        var N = Int64.Parse(Console.ReadLine()!);
        var S = Console.ReadLine()!;

        var sb = new StringBuilder();

        bool flg = false;
        foreach(var c in S) {
            if(c == '"') {
                flg = !flg;
                sb.Append(c);
            } else if(!flg && c == ',') {
                sb.Append('.');
            } else {
                sb.Append(c);
            }
        }
        Console.WriteLine(sb.ToString());
    }
 
}