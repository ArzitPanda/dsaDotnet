using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace dsaC.d
{


   /* Given a rod of length n inches and an array of prices that includes prices of all pieces of size smaller than n.
    * Determine the maximum value obtainable by cutting up the rod and selling the pieces.For example,
    * if the length of the rod is 8 and the values of different pieces are given as the following, 
    * then the maximum obtainable value is 22 (by cutting in two pieces of lengths 2 and 6)

    length   | 1   2   3   4   5   6   7   8  
    --------------------------------------------
    price    | 1   5   8   9  10  17  17  20
    And if the prices are as follows, then the maximum obtainable value is 24 (by cutting in eight pieces of length 1) 

    length   | 1   2   3   4   5   6   7   8  
    --------------------------------------------
    price    | 3   5   8   9  10  17  17  20*/
    internal class RodCutting
    {

        Dictionary<string, int> Cache = new Dictionary<string, int>();  

        public int Method(int[] price,int length,int i)
        {
            if (length < 0 ) return int.MinValue;
            
            
            if(length == 0 || i>length) return 0;



            string Key = $"{length}-{i}";
            if(Cache.ContainsKey(Key)) return Cache[Key];   



            //goCut
            int firstPrice = price[i] + Method(price, length-i, i);

            int secondChoice = Method(price,length,i+1);


            Cache[Key] = Math.Max(firstPrice, secondChoice);

            return Cache[Key];






        }






    }
}
