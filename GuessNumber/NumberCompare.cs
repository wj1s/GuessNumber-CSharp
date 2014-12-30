using System;
using System.Linq;

namespace GuessNumber
{
    public class NumberCompare

    {
        public static String Compare(string s, string s1)
        {
            return CountA(s, s1) + "A" + ConutB(s, s1) + "B";
        }

        private static int ConutB(string s, string s1)
        {
            return SameNumberCount(s, s1) - CountA(s,s1);
        }

        private static int SameNumberCount(string s, string s1)
        {
            return s.Where((t, i) => s1.Contains(t)).Count();
        }

        private static int CountA(string s, string s1)
        {
            return s.Where((t, i) => t == s1[i]).Count();
        }
    }
}