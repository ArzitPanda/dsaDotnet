using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace dsaC.d
{

    /*
        Given string str, the task is to find the minimum number of characters to be inserted to convert it to a palindrome.

        Before we go further, let us understand with a few examples: 

        ab: Number of insertions required is 1 i.e.bab
        aa: Number of insertions required is 0 i.e.aa
        abcd: Number of insertions required is 3 i.e.dcbabcd
        abcda: Number of insertions required is 2 i.e.adcbcda which is the same as the number of insertions in the substring bcd(Why?).
        abcde: Number of insertions required is 4 i.e.edcbabcde*/




    internal class FormAPalindrome
    {
        Dictionary<string, int> Cache = new Dictionary<string, int>();
        public int Method(string a, int i, int j)
        {
            if (i >= a.Length || j < 0 || i > j)
            {
                return 0;
            }
            string Key = $"{i}-{j}";
            if (Cache.ContainsKey(Key))
            {
                return Cache[Key];
            }

            if (a[i] == a[j])
            {


                Cache[Key] = Method(a, i + 1, j - 1);
                return Cache[Key];

            }
            else
            {
                Cache[Key] = 1 + Math.Min(Method(a, i, j - 1), Method(a, i + 1, j));
                return Cache[Key];
            }





        }





    }
}
