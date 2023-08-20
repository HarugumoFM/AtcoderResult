using System;
using System.Collections.Generic;
using System.Linq;

namespace AtcoderResult.ABC308 {


    class d{
        static Dictionary<int, HashSet<int>> list;
        static bool[] visit;
        public static void Main() {
            var lines = Console.ReadLine().Split();
            int H = Int32.Parse(lines[0]);
            int W = Int32.Parse(lines[1]);
            list = new Dictionary<int, HashSet<int>>();
            visit = new bool[H*W];
            var map = new string[H];
            for(int i=0;i<H;i++) {
                map[i] = Console.ReadLine();
            }

            for(int i=0;i<H;i++) {
                for(int j = 0;j<W;j++) {
                    int num = i*W+ j;
                    var root = new HashSet<int>();
                    var here = map[i][j];
                    char next = 'A';
                    switch(here) {
                        case 's':
                            next = 'n';
                            break;
                        case 'n':
                            next = 'u';
                            break;
                        case 'u':
                            next = 'k';
                            break;
                        case 'k':
                            next = 'e';
                            break;
                        case 'e':
                            next = 's';
                            break;
                        default:
                            next = 'A';
                            break;
                    }
                    if(i+1<H && next == map[i+1][j] )
                        root.Add(num+W);
                    if(i>0 && next == map[i-1][j])
                        root.Add(num-W);
                    if(j>0 && next == map[i][j-1])
                        root.Add(num-1);
                    if(j+1<W && next == map[i][j+1])
                        root.Add(num+1);
                    list.Add(num, root);
                }
            }
            search(0);
            if(visit[H*W-1]) {
                Console.WriteLine("Yes");
            } else {
                Console.WriteLine("No");
            }
        }
        
        static void search(int n)
        {
            if(!visit[n])
            {
                visit[n] = true;
                if(list.ContainsKey(n)){
                    foreach(var num in list[n]){
                        //Console.WriteLine("n:"+num);
                        if(!visit[num])
                            search(num);
                    }
                }
            }
        }

    }

}