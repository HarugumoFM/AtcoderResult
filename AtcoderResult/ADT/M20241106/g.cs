namespace AtcoderResult.ADT.M20241106;

internal class G {
    public static void Solve() {
        var N = Int32.Parse(Console.ReadLine()!);
        var A = new long[N,3];
        for (int i = 0; i < N; i++)
        {
            var input = Console.ReadLine()!.Split(' ').Select(long.Parse).ToArray();
            A[i,0] = input[0];
            A[i,1] = input[1];
            A[i,2] = input[2];
        }
        long min = long.MaxValue;
        for (int i = 0; i < N; i++)
        {
            var pq = new PriorityQueue<int,long>();
            var visited = new long[N];
            visited[i] = -1;
            for(int j=0;j<N;j++) {
                if (j == i) continue;
                var path = Math.Abs(A[i,0] - A[j,0]) + Math.Abs(A[i,1] - A[j,1]);
                long S = path%A[i,2] == 0 ? path/A[i,2] : path/A[i,2] + 1;
                pq.Enqueue(j, S);
            }
            while(pq.TryDequeue(out int j, out long S))  {
                if (visited[j] !=0) continue;
                visited[j] = S;
                for(int k=0;k<N;k++) {
                    if (k == j) continue;
                    if(visited[k] != 0) continue;
                    var path = Math.Abs(A[j,0] - A[k,0]) + Math.Abs(A[j,1] - A[k,1]);
                    long S2 = path%A[j,2] == 0 ? path/A[j,2] : path/A[j,2] + 1;
                    if(S > S2) 
                        S2 = S;
                    pq.Enqueue(k, S2);
                }
            }
            min = Math.Min(min, visited.Max());
        }
        Console.WriteLine(min);
    }
}