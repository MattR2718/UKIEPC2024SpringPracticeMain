using System;
using System.Collections.Generic;

namespace F_MoneyBuysHappiness {
    internal class Program {

        static int takePath(int currm, int currh, int x, int i, List<(int, int)> vals) {
            if (i == vals.Count) { return currh; }
            int noBuy = takePath(currm + x, currh, x, i + 1, vals);
            int buy = int.MinValue;
            if (currm >= vals[i].Item1) {
                currm -= vals[i].Item1;
                currh += vals[i].Item2;
                currm += x;
                buy = takePath(currm, currh, x, i + 1, vals);
            }
            return Math.Max(noBuy, buy);

        }

        static void Main(string[] args) {
            int numTests = int.Parse(Console.ReadLine());

            List<int> output = new List<int>();

            for (int i = 0; i < numTests; i++) {
                int m, x;
                var arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);
                m = arr[0];
                x = arr[1];

                List<(int, int)> ch = new List<(int, int)>();

                for (int j = 0; j < m; j++) {
                    arr = Array.ConvertAll(Console.ReadLine().Trim().Split(), Convert.ToInt32);
                    int c = arr[0];
                    int h = arr[1];
                    ch.Add((c, h));
                }

                int currM = 0;
                int currH = 0;
                int g = 0;

                output.Add(takePath(currM, currH, x, g, ch));
            }

            foreach (var item in output) {
                Console.WriteLine(item);
            }
        }
    }
}
