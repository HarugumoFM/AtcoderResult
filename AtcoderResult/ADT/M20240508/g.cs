namespace AtcoderResult.ADT.M20240508;

internal class G {
    public static void Main() {
        var nums = Console.ReadLine()!.Split();

        int N = int.Parse(nums[0]);
        int T = int.Parse(nums[1]);

        var Ps = new long[N];

        var dic = new Dictionary<long, int>();

        dic.Add(0,N);

        for(int i=0;i<T;i++) {
            nums = Console.ReadLine()!.Split();
            var A = Int32.Parse(nums[0]);
            long B = Int64.Parse(nums[1]);
            dic[Ps[A-1]]--;
            if(dic[Ps[A-1]] == 0) dic.Remove(Ps[A-1]);
            Ps[A-1] += B;
            if(dic.ContainsKey(Ps[A-1])) dic[Ps[A-1]]++;
            else dic.Add(Ps[A-1],1);
            Console.WriteLine(dic.Count());
        }
    }
}