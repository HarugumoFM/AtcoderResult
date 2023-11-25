var line = Console.ReadLine()!.Split();
int N = Int32.Parse(line[0]);
int Q = Int32.Parse(line[1]);
var dic = new Dictionary<int,int>();
var mins = new SortedSet<int>();
var A = new int[N];
line = Console.ReadLine()!.Split();
for(int i=0;i<N;i++) {
    int num = Int32.Parse(line[i]);
    A[i] = num;
    Add(num);
}
SetMin();
//Console.WriteLine(min);
for(int i=0;i<Q;i++) {
    var query = Console.ReadLine()!.Split();
    int I = Int32.Parse(query[0]);
    int X = Int32.Parse(query[1]);
    if(A[I-1] != X) {
        Remove(A[I-1]);
        A[I-1] = X;
        Add(X);
    }
    Console.WriteLine(mins.Min);
}

void Add(int N) {
    if(!dic.ContainsKey(N)) {
        dic.Add(N,1);
        mins.Remove(N);
    } else {
        dic[N]++;
    }
}

void Remove(int N) {
    dic[N]--;
    if(dic[N] == 0) {
        dic.Remove(N);
        mins.Add(N);
    }
}

void SetMin()
{
    for(int i=0;i<=N;i++) {
        if(!dic.ContainsKey(i))
            mins.Add(i);
    }
}