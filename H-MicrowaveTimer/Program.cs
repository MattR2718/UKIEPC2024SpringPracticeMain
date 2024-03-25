using System;
using System.Collections.Generic;

namespace H_MicrowaveTimer {
    internal class Program {
        static void Main(string[] args) {
            var l1 = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt64);

            int numModes = (int)l1[0];
            Int64 m = l1[1];

            List<(int, int)> td = new List<(int, int)>();
            for (int j = 0; j < numModes; j++) {
                var l = Array.ConvertAll(Console.ReadLine().Trim().Split(), Convert.ToInt32);
                td.Add((l[0], l[1]));
            }

            int timer = 0;
            int currMode = 1;

            List<(int, int)> hist = new List<(int, int)>();
            hist.Add((timer, currMode));
            int i = 0;
            for (i = 0; i < m; i++) {
                timer += td[(int)(currMode - 1)].Item2;
                while (timer >= td[(int)(currMode - 1)].Item1) {
                    currMode++;
                    if(currMode == numModes + 1) {
                        currMode = 1;
                        timer = 0;
                    }
                }
                if (hist.Contains((timer, currMode))) {
                    break;
                }
                hist.Add((timer, currMode));
            }

            int idx = hist.FindIndex(d => d == (timer,  currMode));
            /*Console.WriteLine("IDX: " + idx);
            foreach (var item in hist)
            {
                Console.WriteLine("ITEM: " + item);
            }*/

            Console.WriteLine(hist[((int)((m - (Int64)idx) % (long)idx) + idx)].Item1);

        }
    }
}
