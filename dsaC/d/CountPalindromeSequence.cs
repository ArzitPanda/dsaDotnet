using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace dsaC.d
{

    /*Find how many palindromic subsequences(need not necessarily be distinct) can be formed in a given string. Note that the empty string is not considered a palindrome.

    Examples: 

    Input : str = "abcd"
    Output : 4
    Explanation :- palindromic subsequence are : "a" ,"b", "c" ,"d" 
    Input : str = "aab"
    Output : 4
    Explanation :- palindromic subsequence are :"a", "a", "b", "aa"
    Input : str = "aaaa"
    Output : 15
*/

    internal class CountPalindromeSequence
    {


        public int Method(int i, int j, string s, int balti)
        {
            if (i >= s.Length || j < 0 || i > j)
            {
                return 0;
            }
            if (s[i] == s[j])
            {

                Console.WriteLine(s[i] + " " + s[j]);
                return 1 + Method(i + 1, j, s, balti - 1) + Method(i, j - 1, s, balti - 1);
            }
            else
            {

                return Method(i + 1, j, s, balti) + Method(i, j - 1, s, balti) - Method(i + 1, j - 1, s, balti);
            }





        }



    }
}
