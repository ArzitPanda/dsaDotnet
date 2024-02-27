using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace dsaC.d
{

    /*Consider a row of N coins of values V1. . .Vn, where N is even.We play a game against an opponent by alternating turns.In each turn,
     * a player selects either the first or last coin from the row,
     * removes it from the row permanently, and receives the value of the coin.Determine the maximum possible amount of money we can definitely win if we move first.

Note: The opponent is as clever as the user.


Examples:


Input: { 5, 3, 7, 10}
    Output: 15 -> (10 + 5)

 Input: {8, 15, 3, 7}
Output: 22-> (7 + 15)
*/


    internal class OptimalSolution
    {
        Dictionary<string, int> cache = new Dictionary<string, int>();

        public int Method(int[] coins, int start, int end)
        {
            if (start > end || start >= coins.Length || end < 0)
            {
                return 0;
            }
            int firstChoice = coins[start] + Math.Max(Method(coins, start + 2, end), Method(coins, start + 1, end - 1));
            int secondChoice = coins[end] + Math.Max(Method(coins, start, end - 2), Method(coins, start + 1, end - 1));





            int USER1 = Math.Max(firstChoice, secondChoice);


            return USER1;


        }

        public int MethodMod(int[] coins, int start, int end)
        {
            if (start > end || start >= coins.Length || end < 0)
            {
                return 0;
            }

            string key = $"{start}-{end}";


            if (cache.ContainsKey(key))
            {
                return cache[key];
            }


            int firstChoice = coins[start];
            if (coins[start + 1] > coins[end])
            {
                firstChoice += MethodMod(coins, start + 2, end);
            }
            else
            {
                firstChoice += MethodMod(coins, start + 1, end - 1);
            }


            int secondChoice = coins[end];

            if (coins[end - 1] > coins[start])
            {
                secondChoice += MethodMod(coins, start, end - 2);
            }
            else
            {
                secondChoice += MethodMod(coins, start + 1, end - 1);
            }





            int USER1 = Math.Max(firstChoice, secondChoice);
            cache[key] = USER1;

            return USER1;


        }






    }
}
