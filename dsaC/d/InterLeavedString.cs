using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace dsaC.d
{


/*    Given three strings A, B and C.Write a function that checks whether C is an interleaving of A and B. C is said to be interleaving
 *    A and B, if it contains all and only characters of A and B and order of all characters in individual strings is preserved.

    Example: 

    Input: strings: "XXXXZY", "XXY", "XXZ"
    Output: XXXXZY is interleaved of XXY and XXZ
    The string XXXXZY can be made by
    interleaving XXY and XXZ
    String:    XXXXZY
    String 1:    XX Y
    String 2:  XX Z

    Input: strings: "XXY", "YX", "X"
    Output: XXY is not interleaved of YX and X
    XXY cannot be formed by interleaving YX and X.
    The strings that can be formed are YXX and XYX*/
    internal class InterLeavedString
    {
        HashSet<string>  Cache = new HashSet<string>(); 
        public bool Method(string a,string b,string target,int i,int j,int tIdx)
        {

            if (tIdx == target.Length)
            {
                return true;
            }
            string Key = $"{i}-{j}-{tIdx}";
            if (Cache.Contains(Key))
            {
                return true;
            }


          
           



            bool val1 = false;
            if (i<a.Length &&   a[i] == target[tIdx])
            {
               val1= true&&Method(a,b,target,i+1,j,tIdx+1);
            }

            bool val2 =false;
            if (j < b.Length && b[j] == target[tIdx])
            {

                val2 = true && Method(a,b,target,i,j+1,tIdx+1);
            }


           bool valc = val1||val2;
            if(valc==true)
            {

                Cache.Add(Key);
                return true;
            }
            else
            {
                return false;
            }
        }



    }
}
