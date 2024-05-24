namespace AtcoderResult.ADT.M20240524;

internal class G {
    public static void Solve() {
        var line = Console.ReadLine()!.Split();

        int H = Int32.Parse(line[0]);

        int W = Int32.Parse(line[1]);
        var A = new string[H];
        var Av = new bool[H,W];

        for(int i=0;i<H;i++) {
            A[i] = Console.ReadLine()!;
        }
        int max = 0;
        search(0,0);
        void search(int x, int y) {
            Av[x,y] = true;
            if(x+y+1 >max) {
                max = x+y+1;
            }
            if(x+1 < H && A[x+1][y] == '.') {
                if(!Av[x+1,y])
                    search(x+1,y);
            }

            if(y+1 < W && A[x][y+1] == '.') {
                if(!Av[x,y+1])
                    search(x,y+1);
            }
        }
        Console.WriteLine(max);
    }
}