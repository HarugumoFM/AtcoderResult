namespace AtcoderResult.ABC325
{
    class E
    {
        public static void Solve()
        {
            var nums = Console.ReadLine()!.Split();
            int N = Int32.Parse(nums[0]);
            long A = Int64.Parse(nums[1]);
            long B = Int64.Parse(nums[2]);
            long C = Int64.Parse(nums[3]);

            var trains = new long[N,N];
            var cars = new long[N,N];

            for(int i=0;i<N;i++) {
                nums = Console.ReadLine()!.Split();
                for(int j=0;j<N;j++) {
                    if(nums[j] != "0") {
                        var n = Int64.Parse(nums[j]);
                        trains[i,j] = n * B + C;
                        cars[i,j] = n * A;
                    }
                }
            }

            var trains2 = new long[N];
            var cars2 = new long[N];

            var que = new HashSet<int>();
            long min = 0;

            //車
            for(int i=1;i<N;i++) {
                que.Add(i);
                cars2[i] = cars[0,i];
            }

            while(que.Count>0) {
                min = long.MaxValue;
                int next = -1;
                foreach(int k in que) {
                    if(cars2[k] <min) {
                        next = k;
                        min = cars2[k];
                    }
                }
                que.Remove(next);
                foreach(int p in que) {
                    cars2[p] = Math.Min(cars2[p], cars2[next] + cars[next,p]);
                }
            }

            //電車
            for(int i=0;i<N-1;i++) {
                que.Add(i);
                trains2[i] = trains[i,N-1];
            }


            while(que.Count>0) {
                min = long.MaxValue;
                int next = -1;
                foreach(int k in que) {
                    if(trains2[k] <min) {
                        next = k;
                        min = trains2[k];
                    }
                }
                que.Remove(next);
                foreach(int p in que) {
                    trains2[p] = Math.Min(trains2[p], trains2[next] + trains[p,next]);
                }
            }

            min = long.MaxValue;

            for(int i=0;i<N;i++) {
                //Console.WriteLine(trains2[i] + cars2[i]);
                min = Math.Min(min, trains2[i] + cars2[i]);
            }


            Console.WriteLine(min);
        }
    }
}

