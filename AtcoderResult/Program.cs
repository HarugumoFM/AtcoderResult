var line = Console.ReadLine()!.Split();
int N = Int32.Parse(line[0]);
int M = Int32.Parse(line[1]);
var route = new List<Point>();
var visit = new bool[N,N];
var A = new long[N,N];


for(int i=0;i<N;i++) {
    for(int j=0;j<N;j++) {
        A[i,j] = -1;
    }
}

for(int i=0;i<Math.Sqrt(M);i++) {
    int j = (int)Math.Sqrt(M-i*i); 
    if(j*j == M-i*i) {
        if(i!=j) {  
            route.Add(new Point(i,j));
            route.Add(new Point(j,i));
        } else {
            route.Add(new Point(i,j));
        }   
    }
}
A[0,0] = 0;
visit[0,0] = true;
var queue = new Queue<Point>();
foreach(var r in route) {
    int rx = r.X;
    int ry = r.Y;
    if(rx<N && ry<N) {
        queue.Enqueue(new Point(rx,ry));
        A[rx,ry] = 1; 
    }
}
//Console.WriteLine(string.Join(",",route));
while(queue.Count>0) {
    var point = queue.Dequeue();
    int x = point.X;
    int y = point.Y;
    if(!visit[x,y]) {
        visit[x,y] = true;
        long cost = A[x,y];
        
        foreach(var r in route) {
            int rx = r.X;
            int ry = r.Y;
            if(x+rx<N && y+ry<N) {
                Enqueue(x+rx,y+ry,cost+1);
            }
            if(x-rx>=0 && y+ry<N) {
                Enqueue(x-rx,y+ry,cost+1);
            }
            if(x-rx>=0 && y-ry>=0) {
                Enqueue(x-rx,y-ry,cost+1);
            }
            if(x+rx<N && y-ry>=0) {
                Enqueue(x+rx,y-ry,cost+1);
            }
        }
    }
}

for(int i=0;i<N;i++) {
    for(int j=0;j<N;j++) {
        if(j==N-1)
            Console.WriteLine(A[i,j]);
        else
            Console.Write(A[i,j]+" ");
    }
}


void Enqueue(int x,int y,long cost) {
    if(!visit[x,y]) {
        queue.Enqueue(new Point(x,y));
        A[x,y] = cost;
    }
}

class Point
{
    public int X {get;set;}
    public int Y {get;set;}

    public Point(int _x, int _y) {
        this.X = _x;
        this.Y = _y;
    }
}