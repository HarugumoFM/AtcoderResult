namespace AtcoderResult.ABC325
{
    class C 
    {
        public static void Solve()
        {
            var dic = new Dictionary<int, HashSet<int>>();

            var nums = Console.ReadLine()!.Split();

            int H = Int32.Parse(nums[0]);
            int W = Int32.Parse(nums[1]);

            var ps = new HashSet<int>();

            var lines = new string[H];
            for(int i=0;i<H;i++) {
                lines[i] = Console.ReadLine()!;
            }

            for(int i=0;i<H;i++) {
                for(int j=0;j<W;j++) {
                    if(lines[i][j] == '#') {
                        ps.Add(i*W+j);
                        if(i<H-1) {
                            if(lines[i+1][j] == '#') {
                                addPath(i*W+j, i*W+j+W);
                            }
                        }
                        if(j<W-1) {
                            if(lines[i][j+1] == '#') {
                                addPath(i*W+j,i*W+j+1);
                            }
                        }
                        if(j<W-1 && i<H-1) {
                            if(lines[i+1][j+1] == '#') {
                                addPath(i*W+j,i*W+j+1+W);
                            }
                        }
                        if(i>0 && j<W-1) {
                            if(lines[i-1][j+1] == '#') {
                                addPath(i*W+j,i*W+j+1-W);
                            }
                        }
                    }
                }
            }
            var visit = new HashSet<int>();
            long sum = 0;

            foreach(var k in ps) {
                if(!visit.Contains(k)) {
                    sum++;
                    search(k);
                }
            }
            Console.WriteLine(sum);


            void addPath(int a, int b) {
                if(!dic.ContainsKey(a))
                    dic.Add(a,new HashSet<int>());
                if(!dic.ContainsKey(b)) 
                    dic.Add(b,new HashSet<int>());
                dic[a].Add(b);
                dic[b].Add(a);
            }

            void search(int i) {
                visit.Add(i);
                if(dic.ContainsKey(i)) {
                    foreach(int k in dic[i]) {
                        if(!visit.Contains(k)) {
                            search(k);
                        }
                    }
                }
            }
        }
    }
}

