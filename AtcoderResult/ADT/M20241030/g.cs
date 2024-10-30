namespace AtcoderResult.ADT.M20241030;

internal class G {
    public static void Solve() {
        var dic = new Dictionary<int, HashSet<int>>();
        int N = int.Parse(Console.ReadLine()!);
        var A = new int[N,2];

        for(int i=0;i<N;i++) {
            var input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
            if(!dic.ContainsKey(input[0])) {
                dic[input[0]] = new HashSet<int>();
            }
            dic[input[0]].Add(input[1]);
            A[i,0] = input[0];
            A[i,1] = input[1];
        }
        int count = 0;
        for(int i=0;i<N;i++) {
            if(search(A[i,0],A[i,1])) {
                count++;
            }
        }
        Console.WriteLine(count);

        bool search(int x, int y) {
            if (dic.ContainsKey(x) && dic[x].Contains(y)) {
                dic[x].Remove(y);
                search(x,y-1);
                search(x,y+1);
                search(x+1,y);
                search(x+1,y+1);
                search(x-1,y-1);
                search(x-1,y);
                return true;
            }else {
                return false;
            }
        }


    }
}