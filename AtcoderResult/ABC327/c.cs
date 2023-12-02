namespace AtcoderResult.ABC327;

class C{
    public static void Solve()
    {
        var A = new int[9,9];
        for(int i=0;i<9;i++) {
            var line = Console.ReadLine()!.Split();
            for(int j=0;j<9;j++) {
                A[i,j] = Int32.Parse(line[j]);
            }
        }
        bool res = true;

        for(int i=0;i<9;i++) {
            var map = new HashSet<int>();
            for(int j=0;j<9;j++) {
                map.Add(A[i,j]);
            }
            if(map.Count != 9) {
                res = false;
                break;
            }
        }

        for(int j=0;j<9;j++) {
            var map = new HashSet<int>();
            for(int i=0;i<9;i++) {
                map.Add(A[i,j]);
            }
            if(map.Count != 9) {
                res = false;
                break;
            }
        }

        for(int i=0;i<3;i++) {
            for(int j=0;j<3;j++) {
                var map = new HashSet<int>();
                for(int k=0;k<3;k++) {
                    for(int l=0;l<3;l++) {
                        map.Add(A[i*3+k,j*3+l]);
                    }
                }
                if(map.Count != 9) {
                    res = false;
                    break;
                }
            }
            if(!res)
                break;
        }

        if(res)
            Console.WriteLine("Yes");
        else
            Console.WriteLine("No");
    }
}