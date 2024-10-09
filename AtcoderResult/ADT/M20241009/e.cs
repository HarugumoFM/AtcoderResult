namespace AtcoderResult.ADT.M20241009;

using System.Text;
internal class E {
    public static void Solve() {
      
        var line = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
        long count = 0;
        for(int i=1;i<line[0];i++) {
            for(int j=1;j<line[4];j++) {
                for(int k=1;k<line[1];k++) {
                    for(int l=1;l<line[4];l++) {
                        int x = line[0] - i -j;
                        int y = line[1] - k - l;
                        int z = line[3] - i - k;
                        int a = line[4] - j - l;
                        int b = line[2] - z - a;
                        if(x <=0 || y <=0 || z <=0 || a <=0 || b <=0) continue;
                        if(b != line[5] - x - y) continue;
                        count++;
                    }
                }
            }
        }
        Console.WriteLine(count);

            
    }
}