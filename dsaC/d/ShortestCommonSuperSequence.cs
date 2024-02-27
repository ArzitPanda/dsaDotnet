using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace dsaC.d
{
/*
    Given two strings str1 and str2, the task is to find the length of the shortest string that has both str1 and str2 as subsequences.

    Examples : 

    Input:   str1 = "geek",  str2 = "eke"
    Output: 5
    Explanation: 
    String "geeke" has both string "geek" 
    and "eke" as subsequences.

    Input:   str1 = "AGGTAB",  str2 = "GXTXAYB"
    Output:  9
    Explanation: 
    String "AGXGTXAYB" has both string 
    "AGGTAB" and "GXTXAYB" as subsequences.*/

    internal class ShortestCommonSuperSequence
    {

        public Dictionary<string,int> Cache = new Dictionary<string,int>();
         public int Lcs(string a,string b,int i,int j)
        {
            if(i>=a.Length || j>=b.Length)
            {
                return 0;
            }

            string Key = $"{i}-{j}";

            if(Cache.ContainsKey(Key))
            {
                return Cache[Key];
            }

            int max = 0;

            if (a[i] == b[j])
            {
               max = Math.Max( 1+ Lcs(a, b, i + 1, j + 1),max);
               
            }

           max= Math.Max(Math.Max(Lcs(a, b, i + 1, j), Lcs(a, b, i, j+1)),max);
             Cache[Key]=max;
            return max;



        }
            

        public int Method(string a ,string b)
        {
            int subsequence = Lcs(a, b, 0, 0);

            int first = a.Length - subsequence;
            int second = b.Length - subsequence;

            return first + second + subsequence;


        }




    }
}
