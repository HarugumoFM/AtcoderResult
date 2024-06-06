namespace AtcoderResult.ADT.M20240606;

using System.Text;
internal class F {
    public static void Solve() {
        var K = Int32.Parse(Console.ReadLine());
        var S = Console.ReadLine();

        var res = new StringBuilder();
        bool isloop = false;
        for(int i=0;i<K;i++) {
            if(S[i] == '"') {
                isloop = !isloop;
                res.Append('"');
            } else if (S[i] == ',') {
                if(isloop) {
                    res.Append(",");
                } else {
                    res.Append(".");
                }
            } else {
                res.Append(S[i]);
            }
        }
        Console.WriteLine(res.ToString());


    }
}