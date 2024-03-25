namespace B_ForbiddenSubstring {
    using System;
    using System.Collections.Generic;
    internal class Program {
        static void Main(string[] args) {
            int numTests = int.Parse(Console.ReadLine());

            List<string> list = new List<string>();

            for (int i = 0; i < numTests; i++) {
                string s = Console.ReadLine();
                string[] strs = s.Trim().Split(' ');
                int a = int.Parse(strs[0]);
                int b = int.Parse(strs[1]);
                int c = int.Parse(strs[2]);

                if (a == 0 || b == 0) {
                    list.Add("YES");
                }else if (c == 0 && (a != 0 && b != 0)) {
                    list.Add("NO");
                } else {
                    list.Add("YES");
                }
            }

            foreach (var item in list) {
                Console.WriteLine(item);
            }
        }
    }
}
