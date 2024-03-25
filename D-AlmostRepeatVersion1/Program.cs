using System;
using System.Linq;
using System.Collections.Generic;

namespace D_AlmostRepeatVersion1 {
    internal class Program {
        static void Main(string[] args) {
            string s = Console.ReadLine();

            string front = s.Substring(0, s.Length / 2);
            string back = s.Substring(s.Length / 2, s.Length/2);

            front = String.Concat(front.OrderBy(c => c));
            back = String.Concat(back.OrderBy(c => c));

            if(front == back) {
                Console.WriteLine("YES");
            } else {
                Console.WriteLine("NO");
            }
        }
    }
}
