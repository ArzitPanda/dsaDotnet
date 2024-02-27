using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsaC.d
{
    internal class PalindrmeDelete
    {

        Dictionary<string, int> cache = new Dictionary<string, int>();

        public static bool IsPalindrome(string s)
        {
            int i = 0, j = s.Length - 1;
            while (i < j)
            {
                if (s[i] != s[j])
                {
                    return false;
                }
                i++;
                j--;
            }
            return true;


        }

        public int minStepsToDeleteStringWithPalindrome(string s, int start, int end)
        {


            if (s == "")
            {
                return 0;
            }


            if (start > end)
            {
                return int.MaxValue - 1;
            }

            string combined = $"{s}-{start}-{end}";

            if (cache.ContainsKey(combined))
            {
                return cache[combined];
            }


            if (end == s.Length)
            {
                if (start == s.Length)
                {
                    return int.MaxValue - 1;

                }
                if (start < s.Length)
                {
                    return minStepsToDeleteStringWithPalindrome(s, start + 1, start + 1);
                }


            }

            int min = int.MaxValue - 1;
            if (IsPalindrome(s.Substring(start, end - start + 1)))
            {


                string newstring = s.Substring(0, start) + s.Substring(end + 1);
                int min1 = Math.Min(1 + minStepsToDeleteStringWithPalindrome(newstring, 0, 0), min);
                min = min1;

            }

            int min2 = minStepsToDeleteStringWithPalindrome(s, start, end + 1);
            min = Math.Min(min, min2);

            cache[combined] = min;


            return min;





        }


    }
}
