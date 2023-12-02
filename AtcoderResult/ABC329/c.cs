namespace AtcoderResult.ABC329;

class C{
    public static void Solve()
    {
        var N = Int32.Parse(Console.ReadLine()!);

        var set = new Dictionary<char,long>();

        var line = Console.ReadLine();
        var last = 'Z';
        long length = 0;

        for(int i=0;i<N;i++) {
            if(line![i] == last) {
                length++;
            } else {
                length = 1;
                last = line[i];
            }
            if(set.ContainsKey(last)) {
                if(set[last] < length) 
                    set[last] = length;
            } else {
                set.Add(last,length);
            }
        }
        long sum = 0;

        foreach((var key, var l) in set) {
            sum+=l;
        }

        Console.WriteLine(sum);
    }
}