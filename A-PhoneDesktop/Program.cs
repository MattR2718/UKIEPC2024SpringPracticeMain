namespace A_PhoneDesktop {
    using System;
    using System.Collections.Generic;
    using System.Security.Cryptography;

    internal class Program {
        static void Main(string[] args) {
            int numTests = int.Parse(Console.ReadLine());

            List<int> output = new List<int>();

            List<(int, int)> tests = new List<(int, int)> ();
            for (int i = 0; i < numTests; i++) {
                string s = Console.ReadLine ();
                string[] strs = s.Trim().Split (' ');
                (int, int) curr = (int.Parse(strs[0]), int.Parse(strs[1]));

                int mins = (int)Math.Ceiling(curr.Item2 / 2.0);
                if(curr.Item1 > (mins * 15 - curr.Item2 * 4)) {
                    int diff = curr.Item1 - (mins * 15 - curr.Item2 * 4);
                    mins += (int)Math.Ceiling(diff / 15.0);
                }
                output.Add(mins);
            }

            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
        }
    }
}
