using System;
using System.Collections.Generic;

namespace E_HideAndSeek {

    internal class Program {
        static void Main(string[] args) {
            int numTests = int.Parse(Console.ReadLine());

            List<int> output = new List<int>();

            for (int i = 0; i < numTests; i++) {
                var arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);
                
                int startMin = arr[0];
                int duration = arr[1];

                int minStartAngle = (startMin % 60) * 6;
                //Console.WriteLine("START MIN ANGLE " + minStartAngle);
                int hourStartAngle = (startMin % (360));
                //Console.WriteLine("START HOUR ANGLE " + hourStartAngle);

                int num = 0;
                for (int j = 0; j < duration; j++) {
                    int nexmin = minStartAngle + 6;
                    int nextHour = hourStartAngle + 1;

                    
                    if(minStartAngle < hourStartAngle && nexmin >= nextHour) {
                        num++;
                    }

                    if(nextHour % 30 == 0 && nexmin % 30 == 0) {
                        num++;
                    }

                    Console.WriteLine("-----------");
                    Console.WriteLine("START MIN ANGLE " + minStartAngle);
                    Console.WriteLine("START HOUR ANGLE " + hourStartAngle);

                    minStartAngle += 6;
                    minStartAngle %= 360;

                    hourStartAngle += 1;
                    hourStartAngle %= 360;
                }

                output.Add(num);
            }

            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
        }
    }
}
