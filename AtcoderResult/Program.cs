var N = Int32.Parse(Console.ReadLine()!);
var A = new int[2*N+2];
var line = Console.ReadLine()!.Split();

for(int i=1;i<=N;i++) {
    var s = Int32.Parse(line[i-1]);
    A[2*i] = A[s]+1;
    A[2*i+1] = A[s]+1;
}

for(int i=1;i<=2*N+1;i++) {
    Console.WriteLine(A[i]);
}