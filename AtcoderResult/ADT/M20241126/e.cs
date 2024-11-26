namespace AtcoderResult.ADT.M20241126;

internal class E {
    public static void Solve() {
        var N = int.Parse(Console.ReadLine());
        var array = new int[N,10];

        for (int i = 0; i < N; i++)
        {
            var input = Console.ReadLine();
            for (int j = 0; j < 10; j++)
            {
                array[i,(int)(input[j] - '0')] = j;
            }
        }
        int max = int.MaxValue;
        for(int i=0;i<10;i++) {
            int _max = 0;
            var dic = new Dictionary<int,int>();
            for(int j=0;j<N;j++) {
                if(dic.ContainsKey(array[j,i])) {
                    dic[array[j,i]]++;
                } else {
                    dic[array[j,i]] = 1;
                }
            }
            foreach(var item in dic) {
                int time = item.Key + (item.Value-1) * 10;
                _max = Math.Max(_max,time);
            }
            max = Math.Min(max,_max);
        }
        Console.WriteLine(max);

    }
 
}