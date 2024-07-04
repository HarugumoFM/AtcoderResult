namespace AtcoderResult.ADT.M20240704;
using System.Text;

internal class G {
    public static void Solve() {
        var nums = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

        int N = nums[0];
        int M = nums[1];
        var votes = new int[N+1];
        nums = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

        var dict = new Dictionary<int, SortedSet<int>>();
        int max = 0;

        foreach(int v in nums) {
            votes[v]++;
            if(votes[v]>max) {
                max = votes[v];
            }
            if(votes[v]!=1) dict[votes[v]-1].Remove(v);
            if(!dict.ContainsKey(votes[v])) dict.Add(votes[v], new SortedSet<int>());
            dict[votes[v]].Add(v);
            Console.WriteLine(dict[max].Min);
        }

    }
}