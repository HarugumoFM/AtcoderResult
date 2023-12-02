namespace AtcoderResult.ABC329;

class D{
    public static void Solve()
    {
        var line = Console.ReadLine()!.Split();

        int N = Int32.Parse(line[0]);
        int M = Int32.Parse(line[1]);

        var dic = new Dictionary<int,int>();
        var dic2 = new Dictionary<int,SortedSet<int>>();
        int max = 1;
        line = Console.ReadLine()!.Split();

        for(int i=0;i<M;i++) {
            int num = Int32.Parse(line[i]);
            if(dic.ContainsKey(num)) {
                var last = dic[num];
                dic[num]++;
                if(!dic2.ContainsKey(last+1))
                    dic2.Add(last+1, new SortedSet<int>());
                dic2[last].Remove(num);
                dic2[last+1].Add(num);
                if(last+1>max)
                    max = last+1;
            } else {
                dic.Add(num,1);
                if(!dic2.ContainsKey(1)) {
                    dic2.Add(1,new SortedSet<int>());
                }
                dic2[1].Add(num);
            }
            
            Console.WriteLine(dic2[max].Min);
        }
    }
}