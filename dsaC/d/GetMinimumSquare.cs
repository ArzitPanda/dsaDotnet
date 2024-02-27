using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace dsaC.d
{
    /*A number can always be represented as a sum of squares of other numbers.
     * Note that 1 is a square and we can always break a number as (1*1 + 1*1 + 1*1 + …). Given a number n, 
     * find the minimum number of squares that sum to X.

    Examples : 

    Input:  n = 100
    Output: 1
    Explanation:
    100 can be written as 10^2. Note that 100 can also be written as 5^2 + 5^2 + 5^2 + 5^2, but this representation requires 4 squares.

    Input:  n = 6
    Output: 3*/
    internal class GetMinimumSquare
    {
        public Dictionary<string,int>  Cache = new Dictionary<string,int>();
        public int Method(int target,int idx)
        {

        

            if(target == 0)
            {
                return 0;
            }
            int square = idx * idx;

            string key = $"{target}-{idx}";
            if(Cache.ContainsKey(key))
            {
                return Cache[key];


            }




            if(target>= square)
            {


                Cache[key] =  Math.Min((1 + Method(target - square, idx)), Method(target, idx + 1));
                return Cache[key];

            }
            else
            {
                Cache[key] = int.MaxValue-1 ;
                return int.MaxValue-1;
            }
           
           


        }




    }
}
