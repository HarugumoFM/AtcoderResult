namespace AtcoderResult.ABC330;

class C{
    public static void Solve()
    {
        var num = Int64.Parse(Console.ReadLine()!);
        long min = long.MaxValue;
        long limit = (long)Math.Sqrt(num);
        for(int x=1;x<=limit;x++) {
            var x2 = Math.Pow(x,2);
            var s = num - x2;
            var y = (long)Math.Sqrt(s);
            if(y >= 0)
                min = Math.Min(min, (long)Math.Abs(Math.Pow(y,2) + x2 - num));
            y++;
            min = Math.Min(min, (long)Math.Abs(Math.Pow(y,2) + x2 -num));
        }
        Console.WriteLine(min);

    }
}