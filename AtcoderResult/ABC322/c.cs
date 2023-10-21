using System;
using System.Collections.Generic;
using System.Linq;

namespace AtcoderResult.ABC322
{
    internal class C
    {
        public static void Main()
        {
            var line = Console.ReadLine()!.Split();

            int N = Int32.Parse(line[0]);
            int M = Int32.Parse(line[1]);

            line = Console.ReadLine()!.Split();
            var A = new int[M+1];
            for(int i=0;i<M;i++) {
                A[i+1] = Int32.Parse(line[i]);
            }

            int index = 0;

            for(int i=1;i<=N;i++) {
                bool same = false;
                if(index<N && i==A[index+1]){
                    index++;
                    same = true;
                }
                if(same) {
                    Console.WriteLine(0);
                } else {
                    Console.WriteLine(A[index+1] -i);
                }

            }
        }
    }
}


