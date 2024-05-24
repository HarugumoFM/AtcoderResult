var N = Int32.Parse(Console.ReadLine());


for(int i=2;i<=N;i++) {
    if(N%i == 0) {
        int count = 0;
        while(N%i == 0) {
            N /= i;
            count++;
        }
        Console.WriteLine($"{i} {count}");
    }
}