using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace dsaC.d
{

/*    Given two strings ‘X’ and ‘Y’, find the length of the longest common substring.

    Examples : 

    Input : X = “GeeksforGeeks”, y = “GeeksQuiz” 
    Output : 5 
    Explanation:
    The longest common substring is “Geeks” and is of length 5.

    Input : X = “abcdxyz”, y = “xyzabcd” 
    Output : 4 
    Explanation:
    The longest common substring is “abcd” and is of length 4.*/

    internal class LongestCommonSubstring
    {

        Dictionary<string,int> Cache = new Dictionary<string,int>();    
        public int Method(string a ,string b,int i,int j )
        {

            if(i>=a.Length || j>=b.Length)
            {
                return 0;
            }


            string Key = $"{i}-{j}";

            if(Cache.ContainsKey(Key) )
            {

                return Cache[Key];

            }
            
            
            
         
            int firstChoice = 0;

            if (a[i] == b[j])
            {


               firstChoice = 1+Method(a,b,i+1,j+1);

            }
            else
            {
               
                return 0;
            }

            int secondChoice = Math.Max(Method(a, b, i + 1, j), Method(a, b, i, j + 1));


            Cache[Key]=  Math.Max(secondChoice, firstChoice);
            return Cache[Key];
           
            





        }







    }
}
