namespace AtcoderResult.ADT.M20241217;

internal class E {
    public static void Solve() {
        var Q = Int32.Parse(Console.ReadLine()!);
        var set = new SortedSet<int>();
        var dic = new Dictionary<int, int>();
        int max = 0;
        int min = int.MaxValue;

        for(int i=0;i<Q;i++) {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if(input[0] == 1) {
                var x = input[1];
                if(!dic.ContainsKey(x)) {
                    dic.Add(x, 0);
                }
                if(dic[x] == 0) {
                    max = Math.Max(max, x);
                    min = Math.Min(min, x);
                }
                dic[x]++;
                set.Add(x);
            } else if(input[0] == 2) {
                var x = input[1];
                var c = input[2];
                if(dic.ContainsKey(x)) {
                    dic[x] -= Math.Min(dic[x], c);
                    if(dic[x] == 0) {
                        set.Remove(x);
                        if(x == max) {
                            if(set.Count == 0) {
                                max = 0;
                            } else {
                                max = set.Max;
                            }
                        }
                        if(x == min) {
                            if(set.Count == 0) {
                                min = int.MaxValue;
                            } else {
                                min = set.Min;
                            }
                            
                        }
                    }
                }
            } else {
                Console.WriteLine(max - min);
            }
        }


    }
 
}