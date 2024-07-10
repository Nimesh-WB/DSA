using System;
using System.Collections.Generic;
using System.Linq;

namespace ValidAnagram
{
    internal class ValidAnagram
    {
        public static void Main(String[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();

            if (IsAnagram(str1, str2))
            {
                Console.WriteLine("Valid Anagram");
            } else
            {
                Console.WriteLine("Not Valid Anagram");
            }
        }


        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length) return false;

            Dictionary<char, int> map = new Dictionary<char, int>();

            string s1 = new string(s.OrderBy(c => c).ToArray();
            string s2 = new string(t.OrderBy(c => c).ToArray());

            for (int i = 0; i < s.Length; i++)
            {
                if (s1[i] != s2[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
