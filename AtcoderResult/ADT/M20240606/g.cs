namespace AtcoderResult.ADT.M20240606;
using System.Text;

internal class G {
    public static void Solve() {
        bool? isUpper = null;
        int N = Int32.Parse(Console.ReadLine());
        var S = Console.ReadLine();

        int Q = Int32.Parse(Console.ReadLine());   

        var index = new HashSet<int>();

        var status = new bool[N];
        var change = new char[N];
        var change2 = new int[N];
        int changei = -1;

        for(int i=0;i<Q;i++) {
            var query = Console.ReadLine().Split();
            if(query[0] == "1") {
                int j = Int32.Parse(query[1]) - 1;
                char x = query[2][0];
                index.Add(j);
                if(x - 'a' >= 0) {
                    status[j] = false;
                } else {
                    status[j] = true;
                }
                change[j] = char.ToLower(x);
                change2[j] = i;

            } else if(query[0] == "2") {
                isUpper = false;
                changei = i;
            } else {
                isUpper = true;
                changei = i;
            }
        }

        var sb = new StringBuilder();
        for(int i=0;i<N;i++) {
            if(index.Contains(i)) {
                if(changei > change2[i]) {
                    if(isUpper == true)
                        sb.Append(char.ToUpper(change[i]));
                    else
                        sb.Append(change[i]);
                    continue;
                }
                if(status[i]) 
                    sb.Append(char.ToUpper(change[i]));
                else 
                    sb.Append(change[i]);
            } else {
                if(isUpper == null) {
                    sb.Append(S[i]);
                } else if(isUpper == true) {
                    sb.Append(char.ToUpper(S[i]));
                } else {
                    sb.Append(char.ToLower(S[i]));
                }
                //Console.WriteLine(S[i]);
            }
        }
        Console.WriteLine(sb.ToString());


    }
}