var inputs = Console.ReadLine().Split().Select(long.Parse).ToArray();
long n = inputs[0];
long m = inputs[1];
var set = new HashSet<long>();
var sums = new long[n + 1];
var a = Console.ReadLine().Split().Select(long.Parse).ToArray();
long sum = 0;
set.Add(0);
for (int i = 0; i < n; i++)
{
    sum += a[i];
    sums[i + 1] = sum;
}
foreach (var s in sums) {
    set.Add(s);
    set.Add(s + sum);
}
m = m % sum;
bool res = false;
for(int i=0;i<=n;i++) {
    if (set.Contains(m + sums[i])) {
        res = true;
        break;
    }
}
if (res) {
    Console.WriteLine("Yes");
} else {
    Console.WriteLine("No");
}