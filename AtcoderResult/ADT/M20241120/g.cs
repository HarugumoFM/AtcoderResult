namespace AtcoderResult.ADT.M20241120;

internal class G {
    public static void Solve() {
        var line = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var h = line[0];
        var w = line[1];
        var S = new string[h];
        for(int i=0;i<h;i++){
            S[i] = Console.ReadLine();
        }
        var dic = new Dictionary<char,char>();
        dic.Add('s', 'n');
        dic.Add('n', 'u');
        dic.Add('u', 'k');
        dic.Add('k', 'e');
        dic.Add('e', 's');
        var bools = new bool[h,w];
        search(0,0,'s');
        if(bools[h-1,w-1])
            Console.WriteLine("Yes");
        else
            Console.WriteLine("No");

        int search(int i, int j, char c) {
            if(bools[i,j])
                return 0;
            if(S[i][j] == c) {
                bools[i,j] = true;
                if(j<w-1)
                    search(i,j+1,dic[c]);
                if(i<h-1)
                    search(i+1,j,dic[c]);
                if(j>0)
                    search(i,j-1,dic[c]);
                if(i>0)
                    search(i-1,j,dic[c]);
            }
            return 0;
        }

    }
}