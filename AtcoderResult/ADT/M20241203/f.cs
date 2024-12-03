namespace AtcoderResult.ADT.M20241203;

using System.Text;
internal class F {
    public static void Solve() {
        var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var N = input[0];
        var M = input[1];

        var A = new char[N,M];

        for (int i = 0; i < N; i++)
        {
            var B = Console.ReadLine().ToCharArray();
            for (int j = 0; j < M; j++)
            {
                A[i, j] = B[j];
            }

            for(int j=0;j<M-1;j++) {
                if(A[i,j] == 'T' && A[i,j+1] == 'T') {
                    A[i,j] = 'P';
                    A[i,j+1] = 'C';
                    j++;
                }
            }
        }
        for(int i=0;i<N;i++) {
            for(int j=0;j<M;j++) {
                Console.Write(A[i,j]);
            }
            Console.WriteLine();
        }




    }
}