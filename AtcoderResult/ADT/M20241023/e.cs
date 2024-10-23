namespace AtcoderResult.ADT.M20241023;
using System.Collections.Generic;
internal class E {
    public static void Solve() {
        int N = Int32.Parse(Console.ReadLine());
        int count = N;
        var set = new SortedSet<int>();

        var list = new List<Card>();


        for(int i=1;i<=N;i++) {
            var line = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            list.Add(new Card(i, line[0], line[1]));
        }

        var cards = list.OrderByDescending(x => x.A).ToArray();
        int AMax = 0;
        int CMax = 0;

        for(int i=0;i<N;i++) {
            if(AMax == 0) {
                AMax = cards[i].A;
                CMax = cards[i].C;
                set.Add(cards[i].No);
            } else if(AMax == cards[i].A) {
                set.Add(cards[i].No);
                if(CMax < cards[i].C) {
                    CMax = cards[i].C;
                }
            } else if (CMax >= cards[i].C) {
                AMax = cards[i].A;
                CMax = cards[i].C;
                set.Add(cards[i].No);
            }
        }
        Console.WriteLine(set.Count);
        Console.WriteLine(string.Join(" ", set));
            
    }
     class Card
    {
        public int No{get;set;}
        public int A{get;set;}
        public int C{get;set;}
        public Card(int No, int A, int C)
        {
            this.No = No;
            this.A = A;
            this.C = C;
        }
    }
}