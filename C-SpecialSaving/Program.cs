namespace C_SpecialSaving {
    using System;
    using System.Collections.Generic;
    internal class Program {
        static void Main(string[] args) {
            int numTests = int.Parse(Console.ReadLine());

            List<string> output = new List<string>();

            for (int i = 0; i < numTests; i++) {
                int n, x, y;
                string[] strs = Console.ReadLine().Trim().Split(' ');
                n = int.Parse(strs[0]);
                x = int.Parse(strs[1]);
                x *= 100;
                y = int.Parse(strs[2]);
                y *= 100;

                List<int> bills = new List<int>();
                for (int j = 0; j < n; j++) {
                    string s = Console.ReadLine();
                    s = s.Substring(0, s.Length - 1);
                    bills.Add((int)(double.Parse(s) * 100));
                }

                int sum = 0;
                foreach(var bill in bills) {
                    sum += ((int)(Math.Ceiling(bill / (double)y) * y - bill));
                }

                if (sum >= x) {
                    output.Add("YES");
                } else {
                    output.Add("NO");
                }
            }

            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
        }
    }
}
