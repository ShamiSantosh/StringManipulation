using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            String S1 = "aaa";
            String S2 = "bca";

            //Has unique characters?
            bool hasuniquechar = HasUniqueCharacters(S1);
            if (hasuniquechar)
                Console.WriteLine(S1 + " has all unique characters");
            else
                Console.WriteLine(S1 + " does not have all unique characters");

            //Are S1 and S2 anagrams?
            bool isanagram = IsAnagram(S1, S2);
            if (isanagram)
                Console.WriteLine(S1 + " and " + S2 + " are anagrams");
            else
                Console.WriteLine(S1 + " and " + S2 + " are not anagrams");

            //Is S2 Rotation of S1?
            bool isrotation = IsRotation(S1, S2);
            if (isrotation)
                Console.WriteLine(S2 + " is rotation of " + S1);
            else
                Console.WriteLine(S2 + " is not rotation of " + S1);
            Console.ReadLine();
        }

        private static bool HasUniqueCharacters(string s1)
        {
            if (s1.Length > 256)
                return false;

            HashSet<char> set = new HashSet<char>();
            foreach(char c in s1)
            {
                if (set.Contains(c))
                    return false;
                else
                    set.Add(c);
            }
            return true;
        }

        private static bool IsAnagram(string s1, string s2)
        {
            int[] a = new int[256];
            if (s1.Length != s2.Length)
                return false;
            foreach (char c in s1)
            {
                a[c]++;
            }
            foreach(char c in s2)
            {
                a[c]--;
            }
            for(int i = 0; i < 256; i++)
            {
                if (a[i] != 0)
                    return false;
            }
            return true;
        }

        private static bool IsRotation(string s1, string s2)
        {
            if (s1.Length != s2.Length)
                return false;
            if ((s1 + s2).Contains(s2))
            {
                return true;
            }
            return false;
        }
    }
}
