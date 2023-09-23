using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtcoderResult.ABC315
{
    internal class C
    {
        public static void Main()
        {

            var N = Int32.Parse(Console.ReadLine());

            var ices = new Dictionary<int, List<int>>();
            var Lices = new Dictionary<int, int>();

            for (int i = 0; i < N; i++)
            {
                var lines = Console.ReadLine().Split();
                int p = Int32.Parse(lines[0]);
                int t = Int32.Parse(lines[1]);

                if (!ices.ContainsKey(p))
                {
                    var list = new List<int>();
                    ices.Add(p, list);
                }
                ices[p].Add(t);
                if (!Lices.ContainsKey(p))
                {
                    Lices.Add(p, 0);
                }
                Lices[p] = Math.Max(Lices[p], t);
            }

            foreach (int key in ices.Keys)
            {
                ices[key].Sort();
            }
            var keys = ices.Keys.ToArray();
            int L = keys.Length;
            int max = 0;
            //同じ味のアイス
            foreach (int key in keys)
            {
                if (ices[key].Count >= 2)
                {
                    ices[key].Sort();
                    ices[key].Reverse();
                    int _max = ices[key][0] + ices[key][1] / 2;
                    max = Math.Max(max, _max);
                }
            }
            //違う味のアイス
            if (L > 1)
            {
                var tList = new List<int>();
                foreach (int key in ices.Keys)
                {
                    tList.Add(Lices[key]);
                }
                tList.Sort();
                tList.Reverse();
                max = Math.Max(max, tList[0] + tList[1]);
            }
            Console.WriteLine(max);

        }
    }
}
