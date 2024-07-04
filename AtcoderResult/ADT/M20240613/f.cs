namespace AtcoderResult.ADT.M20240613;

using System.Text;
internal class F {
    public static void Solve() {
        var N = int.Parse(Console.ReadLine()!);

        var count = new int[N+1];

        var result = new List<int>();

        var nums = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
        int index = 1;
        foreach(var num in nums)
        {
            count[num]++;
            if(count[num] == 2) {
                result.Add(num);
            }
            index++;
        }

        Console.WriteLine(string.Join(" ", result));
    }
}