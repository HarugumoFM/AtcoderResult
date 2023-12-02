using System;
using System.Collections.Generic;
using System.Linq;


namespace AtcoderResult.ABC308
{

    class C 
    {  
        public static void Solve() 
        {
            int N = Int32.Parse(Console.ReadLine()!);
            var list = new List<Person>();
            for(long i=1;i<=N;i++) {
                var lines = Console.ReadLine()!.Split();
                long a = Int64.Parse(lines[0]);
                long b = Int64.Parse(lines[1]);

                list.Add(new Person(i,a,b));
            }
            var cmp = new PersonCompare();
            var sortedList = list.OrderBy(o => o, cmp).ToArray();
            var res = new long[N];
            for(int i=0;i<N;i++) {
                res[i] = sortedList[i].id;
            }
            Console.WriteLine(string.Join(" ", res));
        }

        class Person
        {
            public long id{get;set;}
            public long correct{get;set;}

            public long all{get;set;}

            public Person(long _id, long a, long b) {
                this.id =_id;
                this.correct = a;
                this.all = a+b;
            }
        }

        class PersonCompare : IComparer<Person>
        {
            public int Compare(Person p1, Person p2)
            {
                if(p1.correct * p2.all > p2.correct * p1.all) return -1;
                if(p1.correct * p2.all < p2.correct * p1.all) return 1;
                if(p1.id > p2.id) return 1;
                if(p1.id < p2.id) return -1;
                return 0;
            }
        }
    }
}