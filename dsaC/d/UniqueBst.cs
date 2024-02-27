using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml;
namespace dsaC.d
{
    /*Given N, The task is to find the total number of unique BSTs that can be made using values from 1 to N.

    Examples: 

    Input: N = 3
    Output: 5
    Explanation: For N = 3, preorder traversal of Unique BSTs are:
    1 2 3
    1 3 2
    2 1 3
    3 1 2
    3 2 1

    Input: N = 4
    Output: 14


*/    internal class UniqueBst
    {


        public int Method(int n)
        {
            if (n <= 1) { return 1; }



            int ans = 0;
            for (int i=1;i<=n; i++)
            {

                ans += Method(i - 1)* Method(n - i);
            }

            return ans;

           
            

          
             

        }




    }
}
