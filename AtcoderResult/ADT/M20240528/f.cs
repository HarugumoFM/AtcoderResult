namespace AtcoderResult.ADT.M20240528;

internal class F {
    public static void Solve() {
        var line = Console.ReadLine()!.Split();

        var S = line[0];
        var N = Int32.Parse(line[1]);

        var permutations = GetPermutations(S);
        permutations.Sort();
        Console.WriteLine(permutations[N-1]);


        List<string> GetPermutations(string input)
        {
            var results = new List<string>();
            var exists = new HashSet<string>();
            if (input.Length == 1)
            {
                results.Add(input);
            }
            else
            {
                for (int i = 0; i < input.Length; i++)
                {
                    var firstChar = input[i];
                    var charsLeft = input.Substring(0, i) + input.Substring(i + 1);
                    var innerPermutations = GetPermutations(charsLeft);
                    foreach (var permutation in innerPermutations)
                    {
                        if(exists.Contains(firstChar + permutation)) continue;
                        results.Add(firstChar + permutation);
                        exists.Add(firstChar + permutation);
                    }
                }
            }
            return results;
        }
    }
}