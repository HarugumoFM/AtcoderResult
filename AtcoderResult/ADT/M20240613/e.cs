namespace AtcoderResult.ADT.M20240613;

using System.Text;
internal class E {
    public static void Solve() {
      
        var N = int.Parse(Console.ReadLine()!);

        var dic = new Dictionary<string, int>();

        for (int i = 0; i < N; i++)
        {
            var s = Console.ReadLine();
            if (dic.ContainsKey(s))
            {
                dic[s]++;
                Console.WriteLine(s+"("+dic[s]+")");
            }
            else
            {
                dic.Add(s,0);
                Console.WriteLine(s);
            }
        }
    }
}