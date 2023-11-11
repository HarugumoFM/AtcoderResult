using System;
using System.Collections.Generic;
using System.Linq;

var S = Console.ReadLine();
var L = S.Length;

var line = new char[L];
int count = 0;
for(int i=0;i<L;i++) {
    line[count] = S[i];
    if(S[i] == 'C' && count>=2) {
        if(line[count-1] == 'B' && line[count-2] == 'A') {
            count-=3;
        }
    }
    count++;
}
for(int i=0;i<count;i++) {
    Console.Write(line[i]);
}