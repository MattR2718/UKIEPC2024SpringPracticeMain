using System;
using System.Collections.Generic;

namespace G_2DRace {
    internal class Program {
        static void Main(string[] args) {
            int numTests = int.Parse(Console.ReadLine());

            List<string> output = new List<string>();

            for (int i = 0; i < numTests; i++) {
                var arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);
                int ax = arr[0];
                int ay = arr[1];
                int bx = arr[2];
                int by = arr[3];
                int gx= arr[4];
                int gy = arr[5];
                int s = arr[6];
                int k = arr[7];

                float alicex = gx - ax;
                float alicey = gy - ay;
                double alicedistance = Math.Sqrt(alicex * alicex + alicey * alicey);

                float bobx = gx - bx;
                float boby = gy - by;
                double bobdistance = Math.Sqrt(bobx * bobx + boby * boby);

                double alicetime = alicedistance / s;
                double bobtime = bobdistance / s;

                if((alicetime > k && bobtime > k) || alicedistance == bobdistance) {
                    output.Add("Draw");
                }
                else if(alicedistance < bobdistance) {
                    output.Add("Alice");
                } else {
                    output.Add("Bob");
                }

            }

            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
        }
    }
}
