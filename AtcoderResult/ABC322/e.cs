using System;
using System.Collections.Generic;
using System.Linq;

namespace AtcoderResult.ABC322
{
    internal class E
    {
        public static void Main()
        {
            var line = Console.ReadLine().Split();

            int N = Int32.Parse(line[0]);
            int K = Int32.Parse(line[1]);
            int P = Int32.Parse(line[2]);
            long max = 0;
            if(K==1) {
                var dp = new long[N+1,P+1];
                var item = new long[N,2];
                long s = 0;
                for(int i=0;i<N;i++) {
                    line = Console.ReadLine().Split();
                    item[i,0] = Int64.Parse(line[0]);
                    item[i,1] = Int64.Parse(line[1]);
                    max += item[i,0];
                    s += item[i,1];
                }
                if(s>=P) {
                    for(int i=0;i<=N;i++) {
                        for(int j=1;j<=P;j++) {
                            dp[i,j] = max;
                        }
                    }
                    for(int i=1;i<=N;i++) {
                        long num = item[i-1,1];
                        for(int j=1;j<=P;j++) {
                            var index = j-num <0 ? 0 : (j-num);
                            dp[i,j] = Math.Min(dp[i-1,j], dp[i-1,index] + item[i-1,0]);
                        }
                    }
                    Console.WriteLine(dp[N,P]);
                } else {
                    Console.WriteLine(-1);
                }
            } else if(K==2){
                var dp = new long[N+1,P+1,P+1];
                var item = new long[N,3];
                long p1 =0;
                long p2 =0;
                for(int i=0;i<N;i++) {
                    line = Console.ReadLine().Split();
                    item[i,0] = Int64.Parse(line[0]);
                    item[i,1] = Int64.Parse(line[1]);
                    item[i,2] = Int64.Parse(line[2]);
                    max += item[i,0];
                    p1 += item[i,1];
                    p2 += item[i,2];
                }
                if(p1>=P && p2>=P) {
                    for(int i=0;i<=N;i++) {
                        for(int j=0;j<=P;j++) {
                            for(int k=0;k<=P;k++){
                                if(j+k !=0) {
                                    dp[i,j,k] = max;
                                }
                            }
                        }
                    }
                    for(int i=1;i<=N;i++) {
                        long n1 = item[i-1,1];
                        long n2 = item[i-1,2];
                        for(int j=0;j<=P;j++) {
                            var ij = j-n1 <0 ? 0 : (j-n1);
                            for(int k=0;k<=P;k++) {
                            var ik = k-n2 <0 ? 0 : (k-n2);
                                dp[i,j,k] = Math.Min(dp[i-1,j,k], dp[i-1,ij,ik] + item[i-1,0]);
                            }
                        }
                    }
                    Console.WriteLine(dp[N,P,P]);

                } else {
                    Console.WriteLine(-1);
                }
            } else if(K==3) {
                var dp = new long[N+1,P+1,P+1,P+1];
                var item = new long[N,4];
                long p1 = 0;
                long p2 = 0;
                long p3 = 0;
                for(int i=0;i<N;i++) {
                    line = Console.ReadLine().Split();
                    item[i,0] = Int64.Parse(line[0]);
                    item[i,1] = Int64.Parse(line[1]);
                    item[i,2] = Int64.Parse(line[2]);
                    item[i,3] = Int64.Parse(line[3]);
                    max += item[i,0];
                    p1 += item[i,1];
                    p2 += item[i,2];
                    p3 += item[i,3];
                }
                if(p1>=P && p2>=P && p3>=P) {
                    for(int i=0;i<=N;i++) {
                        for(int j=0;j<=P;j++) {
                            for(int k=0;k<=P;k++){
                                for(int l=0;l<=P;l++) {
                                    if(j+k+l !=0) {
                                        dp[i,j,k,l] = max;
                                    }
                                }
                            }
                        }
                    }
                    for(int i=1;i<=N;i++) {
                        long n1 = item[i-1,1];
                        long n2 = item[i-1,2];
                        long n3 = item[i-1,3];
                        for(int j=0;j<=P;j++) {
                            var ij = j-n1 <0 ? 0 : (j-n1);
                            for(int k=0;k<=P;k++) {
                                var ik = k-n2 <0 ? 0 : (k-n2);
                                for(int l=0;l<=P;l++) {
                                    var il = l-n3 <0 ? 0 : (l-n3);
                                    dp[i,j,k,l] = Math.Min(dp[i-1,j,k,l], dp[i-1,ij,ik,il] + item[i-1,0]);
                                }
                            }
                        }
                    }
                    Console.WriteLine(dp[N,P,P,P]);

                } else {
                    Console.WriteLine(-1);
                }
            } else if(K==4) {
                var dp = new long[N+1,P+1,P+1,P+1,P+1];
                var item = new long[N,5];
                long p1 = 0;
                long p2 = 0;
                long p3 = 0;
                long p4 = 0;
                for(int i=0;i<N;i++) {
                    line = Console.ReadLine().Split();
                    item[i,0] = Int64.Parse(line[0]);
                    item[i,1] = Int64.Parse(line[1]);
                    item[i,2] = Int64.Parse(line[2]);
                    item[i,3] = Int64.Parse(line[3]);
                    item[i,4] = Int64.Parse(line[4]);
                    max += item[i,0];
                    p1 += item[i,1];
                    p2 += item[i,2];
                    p3 += item[i,3];
                    p4 += item[i,4];
                }
                if(p1>=P && p2>=P && p3>=P && p4>=P) {
                    for(int i=0;i<=N;i++) {
                        for(int j=0;j<=P;j++) {
                            for(int k=0;k<=P;k++){
                                for(int l=0;l<=P;l++) {
                                    for(int x=0;x<=P;x++) {
                                        if(j+k+l+x !=0) {
                                            dp[i,j,k,l,x] = max;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    for(int i=1;i<=N;i++) {
                        long n1 = item[i-1,1];
                        long n2 = item[i-1,2];
                        long n3 = item[i-1,3];
                        long n4 = item[i-1,4];
                        for(int j=0;j<=P;j++) {
                            var ij = j-n1 <0 ? 0 : (j-n1);
                            for(int k=0;k<=P;k++) {
                                var ik = k-n2 <0 ? 0 : (k-n2);
                                for(int l=0;l<=P;l++) {
                                    var il = l-n3 <0 ? 0 : (l-n3);
                                    for(int x=0;x<=P;x++) {
                                        var ix = x-n4 <0 ? 0 : (x-n4);
                                        dp[i,j,k,l,x] = Math.Min(dp[i-1,j,k,l,x], dp[i-1,ij,ik,il,ix] + item[i-1,0]);
                                    }
                                }
                            }
                        }
                    }
                    Console.WriteLine(dp[N,P,P,P,P]);

                } else {
                    Console.WriteLine(-1);
                }
            } else {
                var dp = new long[N+1,P+1,P+1,P+1,P+1,P+1];
                var item = new long[N,6];
                long p1 = 0;
                long p2 = 0;
                long p3 = 0;
                long p4 = 0;
                long p5 = 0;
                for(int i=0;i<N;i++) {
                    line = Console.ReadLine().Split();
                    item[i,0] = Int64.Parse(line[0]);
                    item[i,1] = Int64.Parse(line[1]);
                    item[i,2] = Int64.Parse(line[2]);
                    item[i,3] = Int64.Parse(line[3]);
                    item[i,4] = Int64.Parse(line[4]);
                    item[i,5] = Int64.Parse(line[5]);
                    max += item[i,0];
                    p1 += item[i,1];
                    p2 += item[i,2];
                    p3 += item[i,3];
                    p4 += item[i,4];
                    p5 += item[i,5];
                }
                if(p1>=P && p2>=P && p3>=P && p4>=P && p5>=P) {
                    for(int i=0;i<=N;i++) {
                        for(int j=0;j<=P;j++) {
                            for(int k=0;k<=P;k++){
                                for(int l=0;l<=P;l++) {
                                    for(int x=0;x<=P;x++) {
                                        for(int y=0;y<=P;y++) {
                                            if(j+k+l+x+y !=0) {
                                                dp[i,j,k,l,x,y] = max;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    for(int i=1;i<=N;i++) {
                        long n1 = item[i-1,1];
                        long n2 = item[i-1,2];
                        long n3 = item[i-1,3];
                        long n4 = item[i-1,4];
                        long n5 = item[i-1,5];
                        for(int j=0;j<=P;j++) {
                            var ij = j-n1 <0 ? 0 : (j-n1);
                            for(int k=0;k<=P;k++) {
                                var ik = k-n2 <0 ? 0 : (k-n2);
                                for(int l=0;l<=P;l++) {
                                    var il = l-n3 <0 ? 0 : (l-n3);
                                    for(int x=0;x<=P;x++) {
                                        var ix = x-n4 <0 ? 0 : (x-n4);
                                        for(int y=0;y<=P;y++) {
                                            var iy = y-n5 <0 ? 0 : (y-n5);
                                            dp[i,j,k,l,x,y] = Math.Min(dp[i-1,j,k,l,x,y], dp[i-1,ij,ik,il,ix,iy] + item[i-1,0]);
                                        }
                                        
                                    }
                                }
                            }
                        }
                    }
                    Console.WriteLine(dp[N,P,P,P,P,P]);

                } else {
                    Console.WriteLine(-1);
                }
            }
        }
    }
}


