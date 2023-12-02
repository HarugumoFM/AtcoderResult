namespace AtcoderResult.ABC331;

class E {

    public static void Solve()
    {
            var line = Console.ReadLine()!.Split();
        int N = Int32.Parse(line[0]);
        int M = Int32.Parse(line[1]);
        int L = Int32.Parse(line[2]);

        var AList = new List<Product>();
        var BList = new List<Product>();
        var A = new long[N];
        var B = new long[M];
        line = Console.ReadLine()!.Split();
        for(int i=0;i<N;i++) {
            var price = Int64.Parse(line[i]);
            AList.Add(new Product(price,i+1));
            A[i] = price;
        }
        var SortA = AList.OrderByDescending(x => x.price).ToArray();

        line = Console.ReadLine()!.Split();
        for(int i=0;i<M;i++) {
            var price = Int64.Parse(line[i]);
            BList.Add(new Product(price,i+1));
            B[i] = price;
        }

        var SortB = BList.OrderByDescending(x => x.price).ToArray();
        var dic= new Dictionary<int,HashSet<int>>();
        var dic2= new Dictionary<int,HashSet<int>>();

        for(int i=0;i<L;i++) {
            line = Console.ReadLine()!.Split();
            var c = Int32.Parse(line[0]);
            var d = Int32.Parse(line[1]);
            PathAdd2(c,d);
        }
        long max = 0;
        int indexA = 0;
        int indexB = 0;

        while(indexA<N && indexB<M) {
            
            if(SortA[indexA].price < SortB[indexB].price) {
                //Console.WriteLine("B"+SortB[indexB].index);
                foreach(var a in SortA) {
                    if(!dic2.ContainsKey(SortB[indexB].index) || !dic2[SortB[indexB].index].Contains(a.index)) {
                        max = Math.Max(max, a.price + SortB[indexB].price);
                        break;
                    }
                }
            } else {
                //Console.WriteLine("A"+SortA[indexA].index);
                foreach(var b in SortB) {
                    if(!dic.ContainsKey(SortA[indexA].index) || !dic[SortA[indexA].index].Contains(b.index)) {
                        max = Math.Max(max, b.price + SortA[indexA].price);
                        break;
                    }
                }
            }
            if(max>=SortA[indexA].price + SortB[indexB].price)
                break;

            if(indexA==N-1) {
                indexB++;
            } else if(indexB == M-1) {
                indexA++;
            } else if(SortA[indexA].price < SortB[indexB].price) {
                indexB++;
            } else {
                indexA++;
            }
        }

        Console.WriteLine(max);


        void PathAdd2(int a,int b) {
            if(!dic.ContainsKey(a))
                dic.Add(a,new HashSet<int>());
            if(!dic2.ContainsKey(b))
                dic2.Add(b, new HashSet<int>());
            dic[a].Add(b);
            dic2[b].Add(a);
        }

        
    }
    class Product{
        public long price{get;set;}
        public int index{get;set;}
        public Product(long p, int i) {
            price = p;
            index = i;
        }
    }
}
