namespace AtcoderResult.ADT.M20250325;
internal class G {
    public static void Solve() {
        var inputs = Console.ReadLine()!.Split(' ').Select(long.Parse).ToArray();
        var a = inputs[0];
        var N = inputs[1];
        var dic = new Dictionary<long, long>();

        search(N,0);
        if(dic.ContainsKey(1))
        Console.WriteLine(dic[1]);
        else
        Console.WriteLine(-1);

        bool search(long X, long count) {
            if(dic.ContainsKey(X)) {
                if(count >= dic[X]) {
                    return false;
                }
            }
            dic[X] = count;
            if(X % a == 0) {
                search(X / a, count + 1);
            }
            long mask = 1;
            while(true) {
                if(mask*10 > X) {
                    break;
                }
                mask *= 10;
            }
            if(mask != 1) {
                string x_str = X.ToString();
                if(x_str[1] == '0') 
                return false;
                search(X % mask *10 + X/mask, count + 1);
            }

            return true;
        } 

    }
}