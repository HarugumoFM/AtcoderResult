namespace AtcoderResult.ADT.M20250108;

internal class E {
    public static void Solve() {
        var AN = Int32.Parse(Console.ReadLine());
        var A = Console.ReadLine()!.Split().Select(Int32.Parse).ToArray();
        var set = new HashSet<int>();
        for (int i = 0; i < AN; i++)
        {
            set.Add(A[i]);
        }
        var BN = Int32.Parse(Console.ReadLine()!);
        var B = Console.ReadLine().Split().Select(Int32.Parse).ToArray();
        var set2 = new HashSet<int>();
        for (int i = 0; i < BN; i++)
        {
            foreach(var item in set)
            {
                set2.Add(item + B[i]);
            }
        }
        set = set2;

        var CN = Int32.Parse(Console.ReadLine()!);
        var C= Console.ReadLine()!.Split().Select(Int32.Parse).ToArray();
        var set3 = new HashSet<int>();
        for (int i = 0; i < CN; i++)
        {
            foreach (var item in set)
            {
                set3.Add(item + C[i]);
            }
        }
        set = set3;
        var XN = Int32.Parse(Console.ReadLine());
        var X = Console.ReadLine()!.Split().Select(Int32.Parse).ToArray();
        foreach (var item in X)
        {
            if (set.Contains(item))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }


    }
 
}