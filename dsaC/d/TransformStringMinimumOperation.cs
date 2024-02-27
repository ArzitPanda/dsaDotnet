using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsaC.d
{
    internal class TransformStringMinimumOperation
    {
        /*  Given two strings ‘str1’ and ‘str2’ of size m and n
          respectively.The task is to remove/delete and insert the
              minimum number of characters from/in str1 to transform it into str2.
              It could be possible that the same character needs to be removed/deleted
              from one point of str1 and inserted at some another point.*/


        public int Method(string a, string b)
        {
            int longestSubSequence = Lcs(a, b, 0, 0);

            int toDelete = a.Length - longestSubSequence;
            int toInset = b.Length - longestSubSequence;

            Console.WriteLine($"total no of letter to delete {toDelete}");
            Console.WriteLine($"total no of letter to insert {toInset}");

            return toDelete + toInset;


        }

        public Dictionary<string, int> cache = new Dictionary<string, int>();
        public int Lcs(string a, string b, int i, int j)
        {


            if (i >= a.Length || j >= b.Length)
            {
                return 0;
            }


            string keys = $"{i}-{j}";

            if (cache.ContainsKey(keys))
            {
                return cache[keys];
            }




            int max = 0;
            if (a[i] == b[j])
            {
                max = Math.Max(1 + Lcs(a, b, i + 1, j + 1), max);
            }

            int secondChoice = Math.Max(Lcs(a, b, i + 1, j), Lcs(a, b, i, j + 1));



            cache[keys] = Math.Max(max, secondChoice);

            return cache[keys];





        }

    }
}
