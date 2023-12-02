namespace AtcoderResult.ABC321;

using System;

class C
{
    public static void Solve()
    {
        int K = Int32.Parse(Console.ReadLine()!);
        Console.WriteLine(answer(K));

        long answer(int K){
            var C = new int[10];
            C[0] = 9;
            C[1] = 10*9/2;
            C[2] = C[1]*8/3;
            C[3] = C[2]*7/4;
            C[4] = C[3]*6/5;
            C[5] = C[4]*5/6;
            C[6] = C[5]*4/7;
            C[7] = C[6]*3/8;
            C[8] = C[7]*2/9;
            C[9] = C[8]/10;
            int count = 0;
            //１けた
            if(K <=C[0]) {
                return K;
            } 
            count += C[0];
            //2桁
            if(K<= C[1]+count) {
                for(int i=10;i<100;i++) {
                    if(check(i)){
                        count++;
                    }
                    if(count==K){
                        return i;
                    }
                }
            }
            count += C[1];
            //３桁
            if(K<=C[2]+count) {
                for(int i=210;i<=987;i++) {
                    if(check(i))
                        count++;
                    if(count == K)
                        return i;
                }
            }
            count += C[2];
            //4桁
            if(K<=C[3]+count) {
                for(int i=3210;i<=9876;i++) {
                    if(check(i))
                        count++;
                    if(count == K)
                        return i;
                }
            }
            count += C[3];
            //5桁
            if(K<=C[4]+count) {
                for(int i=43210;i<=98765;i++) {
                    if(check(i))
                        count++;
                    if(count == K)
                        return i;
                }
            }
            count += C[4];
            //6桁
            if(K<=C[5]+count) {
                for(int i=543210;i<=987654;i++) {
                    if(check(i))
                        count++;
                    if(count == K)
                        return i;
                }
            }
            count += C[5];
            //7桁
            if(K<=C[6]+count) {
                for(int i=6543210;i<=9876543;i++) {
                    if(check(i))
                        count++;
                    if(count == K)
                        return i;
                }
            }
            count += C[6];
            //8桁
            if(K<=C[7]+count) {
                for(int i=76543210;i<=98765432;i++) {
                    if(check(i))
                        count++;
                    if(count == K)
                        return i;
                }
            }
            count += C[7];
            //8桁
            if(K<=C[8]+count) {
                for(int i=876543210;i<=987654321;i++) {
                    if(check(i))
                        count++;
                    if(count == K)
                        return i;
                }
            }
            return 9876543210;
        }



        bool check(int N) {
        int last = -1;
        bool res = true;
        var num = N;
        for(int i=1;i<=10;i++) {
            if(num == 0)
                break;
            int x = num%10;
            num = num/10;
            
            if(x > last) {
                last = x;
            } else {
                res = false;
                break;
            }
        }
        return res;
        }
    }
}