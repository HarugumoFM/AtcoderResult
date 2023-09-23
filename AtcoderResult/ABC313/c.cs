using System;
using System.Collections.Generic;
using System.Linq;

namespace AtcoderResult.ABC313 {
    internal class C {
    //.NET 7出の書き方
        static void Main() {
            var N = Int32.Parse(Console.ReadLine());

            var lines = Console.ReadLine().Split();

            var nums = new long[N];
            int index = 0;
            long sum = 0;
            foreach(var x in lines) {
                nums[index] = Int64.Parse(x);
                sum += nums[index];
                index++;
            }

            if(sum%N == 0) {
                long mid = sum/N;
                Console.WriteLine(count(mid));
            } else {
                long mid = sum/N;
                long c1 = count2(mid);
                long c2 = count2(mid+1);
                if(c1 == -1) 
                    Console.WriteLine(c2);
                else if (c2 == -1)
                    Console.WriteLine(c1);
                else if(c1 > c2)
                    Console.WriteLine(c2);
                else
                    Console.WriteLine(c1);
            }

            long count2 (long mid) {
                long plus = 0;
                long minus = 0;
                var pDic = new Dictionary<long,int>();
                var mDic = new Dictionary<long,int>();
                foreach(var i in nums) {
                    if(mid>i) {
                        var sub = mid-i;
                        plus += sub;
                        addP(sub);
                    } else if (i>mid) {
                        var sub = i-mid;
                        minus += i-mid;
                        addM(sub);
                    }
                }
                if(plus > minus) {
                    var keys = new List<long>(pDic.Keys);
                    keys.Sort();
                    var _minus = minus;
                    bool can = true;
                    foreach(var key in keys) {
                        if(key <= 1) continue;
                        if(_minus >= pDic[key]*(key-1))
                            _minus -= pDic[key]*(key-1);
                        else {
                            can = false;
                            break;
                        } 
                    }
                    if(can)
                        return minus;
                    else
                        return -1;
                } else {
                    var keys = new List<long>(mDic.Keys);
                    keys.Sort();
                    var _plus = plus;
                    bool can = true;
                    foreach(var key in keys) {
                        if(key <= 1) continue;
                        if(_plus >= mDic[key]*(key-1))
                            _plus -= mDic[key]*(key-1);
                        else {
                            can = false;
                            break;
                        } 
                    }
                    if(can)
                        return plus;
                    else
                        return -1;
                }

                void addP(long x){
                    if(pDic.ContainsKey(x)) {
                        pDic[x]++;
                    } else {
                        pDic.Add(x,1);
                    }
                }
                void addM(long x){
                    if(mDic.ContainsKey(x)) {
                        mDic[x]++;
                    } else {
                        mDic.Add(x,1);
                    }
                }

            }

            long count (long mid) {
                long plus = 0;
                long minus = 0;
                foreach(var i in nums) {
                    if(mid>i) {
                        plus += mid-i;
                    } else if (i>mid) {
                        minus += i-mid;
                    }
                }
                if(plus > minus) 
                    return minus;
                else 
                    return plus;
            }
        }
    }
}