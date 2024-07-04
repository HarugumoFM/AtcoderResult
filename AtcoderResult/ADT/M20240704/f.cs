namespace AtcoderResult.ADT.M20240704;

using System.Text;
internal class F {
    public static void Solve() {
        var line = Console.ReadLine()!.Split();

        int H1 = Int32.Parse(line[0]);
        int W1 = Int32.Parse(line[1]);

        var A = new int[H1, W1];

        for(int i=0;i<H1;i++) {
            line = Console.ReadLine()!.Split();
            for(int j=0;j<W1;j++) {
                A[i, j] = Int32.Parse(line[j]);
            }
        }

        line = Console.ReadLine()!.Split();

        int H2 = Int32.Parse(line[0]);
        int W2 = Int32.Parse(line[1]);
        var B = new int[H2, W2];

        for(int i=0;i<H2;i++) {
            line = Console.ReadLine().Split();
            for(int j=0;j<W2;j++) {
                B[i, j] = Int32.Parse(line[j]);
            }
        }

        var maxH = (long)Math.Pow(2,H1) -1;
        var maxW = (long)Math.Pow(2,W1) -1;

        bool res = false;
        for(int h=1;h<=maxH;h++) {
            if(calcBit(h) != H2) continue;
            for(int w=1;w<=maxW;w++) {
                if(calcBit(w) != W2) continue;
                var y = getBit(h);
                var x = getBit(w);
                bool res1 = true;
                for(int i=0;i<H2;i++) {
                    for(int j=0;j<W2;j++) {
                        if(A[y[i], x[j]] != B[i, j]) {
                            res1 = false;
                            break;
                        }
                    }
                }
                if(res1) {
                    res = true;
                    break;
                }
            }
        }
        if(res) {
            Console.WriteLine("Yes");
        } else {
            Console.WriteLine("No");
        }
        int calcBit(int N) {
            long bit = 1;
            int count = 0;
            for(int i=0;i<11;i++) {
                if((bit & N) >0) {
                    count++;
                }
                bit *= 2;
            }
            return count;
        }

        List<int> getBit(int N) {
            var res = new List<int>();
            long bit = 1;
            for(int i=0;i<11;i++) {
                if((bit & N) >0) {
                    res.Add(i);
                }
                bit *= 2;
            }
            return res;
        }
    }
}