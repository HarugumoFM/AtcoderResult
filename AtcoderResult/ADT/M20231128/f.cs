namespace AtcoderResult.ADT.M20231128;

internal class F{
    public static void Main()
    {
        var line = Console.ReadLine()!.Split();

        int N = Int32.Parse(line[0]);
        int K = Int32.Parse(line[1]);
        var dic = new Dictionary<int,List<int>>();
        var dic2 = new Dictionary<int,int[]>();

        for(int i=0;i<K;i++) {
            dic.Add(i,new List<int>());
        }
        line = Console.ReadLine()!.Split();
        for(int i=0;i<N;i++) {
            int num = Int32.Parse(line[i]);
            dic[i%K].Add(num);
        }
        for(int i=0;i<K;i++) {
            dic[i].Sort();
            dic2.Add(i,dic[i].ToArray());
        }

        bool res = true;
        var seed = 0;
        for(int i=0;i<N;i++) {
            int s = i%K;
            int l = i/K;
            if(seed > dic2[s][l]) {
                res = false;
                break;
            } 
            seed = dic2[s][l];
        }
        if(res)
            Console.WriteLine("Yes");
        else
            Console.WriteLine("No");
    }
}