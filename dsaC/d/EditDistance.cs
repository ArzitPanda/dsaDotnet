using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace dsaC.d
{

    /*  Given two strings str1 and str2 of length M and N respectively and below operations that can be performed on str1.Find the minimum number of edits(operations) to convert ‘str1‘ into ‘str2‘.  

      Operation 1 (INSERT): Insert any character before or after any index of str1
      Operation 2 (REMOVE): Remove a character of str1
      Operation 3 (Replace): Replace a character at any index of str1 with some other character.*/

    /*Input:   str1 = “geek”, str2 = “gesek”
    Output:  1
    Explanation: We can convert str1 into str2 by inserting a ‘s’ between two consecutive ‘e’ in str2.*/

    internal class EditDistance
    {
        public Dictionary<string, int> Cache = new Dictionary<string, int>();



        public int Method(string m, string n, int i, int j)
        {

            if (i == m.Length) return n.Length - j;
            if (j == n.Length) return m.Length - i;


            string Key = $"{i}-{j}";
            if (Cache.ContainsKey(Key)) return Cache[Key];



            if (m[i] == n[j])
                return Method(m, n, i + 1, j + 1);






            int replace = Method(m, n, i + 1, j + 1);
            int insert = Method(m, n, i, j + 1);
            int remove = Method(m, n, i + 1, j);

            Cache[Key] = 1 + Math.Min(replace, Math.Min(insert, remove));

            return Cache[Key];













        }

        private static string ReplaceAtIndex(string input, int idx, char c)
        {
            char[] chars = input.ToCharArray();
            chars[idx] = c; // Replace with any desired character
            return new string(chars);
        }
        private static string RemoveAtIndex(string input, int idx)
        {
            return input.Remove(idx, 1);
        }
        private static string InsertAtIndex(string input, int idx, char c)
        {
            return input.Substring(0, idx) + c + input.Substring(idx);
        }



    }
}
