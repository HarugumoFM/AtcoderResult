namespace AtcoderResult.ADT.M20250129;

internal class G {
    public static void Solve() {
        var inputs = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
        var H = inputs[0];
        var W = inputs[1];

        var A = new string[H];
        var res = new bool[H, W];
        for (int i = 0; i < H; i++)
        {
            A[i] = Console.ReadLine()!;
        }
        search(1,1);
        if(res[H-1,W-1]) Console.WriteLine("Yes");
        else Console.WriteLine("No");

        void search(int x, int y) {
            if(res[x-1,y-1]) return;
            res[x-1,y-1] = true;
            char next = Next(A[x-1][y-1]);
            if(x > 1 && A[x-2][y-1] == next) search(x-1, y);
            if(x < H && A[x][y-1] == next) search(x+1, y);
            if(y > 1 && A[x-1][y-2] == next) search(x, y-1);
            if(y < W && A[x-1][y] == next) search(x, y+1);
        }



        char Next(char c)
        {
            if(c == 's') return 'n';
            if(c == 'n') return 'u';
            if(c == 'u') return 'k';
            if(c == 'k') return 'e';
            if(c == 'e') return 's';
            return ' ';
        }

    }
}