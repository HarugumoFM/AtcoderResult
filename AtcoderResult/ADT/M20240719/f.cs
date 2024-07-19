namespace AtcoderResult.ADT.M20240719;

using System.Text;
internal class F {
    public static void Solve() {
        var line = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int N = line[0];
        int M = line[1];

        var A = new long[M];
        var line2 = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
        var list = new List<Test>();
        for(int i = 0; i < M; i++){
            A[i] = line2[i];
            list.Add(new Test(A[i], i));
        }
        var MaxA = list.OrderByDescending(x => x.point).ToArray();

        var ACs = new bool[N,M];
        var Ps = new long[N];
        long max = 0;
        long max2 = 0;

        for(int i = 0; i < N; i++){
            var line3 = Console.ReadLine();
            for(int j=0;j<M;j++) {
                if(line3[j] == 'o'){
                    ACs[i,j] = true;
                    Ps[i] += A[j];
                }
            }
            Ps[i] +=i+1;
            if(max <Ps[i]) {
                max = Ps[i];
            }
            //Console.WriteLine(Ps[i]);
        }

        for(int i = 0;i<N;i++) {
            if(max == Ps[i]) {
                Console.WriteLine(0);
            } else {
                int count = 0;
                for(int j=0;j<M;j++) {
                    if(!ACs[i,MaxA[j].index]) {
                        Ps[i]+= A[MaxA[j].index];
                        count++;
                        if(max <= Ps[i]) {
                            Console.WriteLine(count);
                            break;
                        }
                    }
                }
            }
        }



    }

    
    class Test {
        public long point{get; set;}
        public int index{get; set;}
        public Test(long point, int index){
            this.point = point;
            this.index = index;
        }

    }
}