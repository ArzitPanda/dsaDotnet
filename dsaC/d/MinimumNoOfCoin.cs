using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsaC.d
{
    internal class MinimumNoOfCoin
    {
        public Dictionary<string, int> Coin = new Dictionary<string, int>();

        public int MinNoOfCoins(int money, int[] arr, int i)
        {
            if (money == 0)
                return 0;
            if (i >= arr.Length) return int.MaxValue - 1;


            string key = $"{money}-{i}";

            if (Coin.ContainsKey(key))
            {
                return Coin[key];
            }


            int min = int.MaxValue - 1;
            if (arr[i] <= money)
            {
                min = Math.Min(min, 1 + MinNoOfCoins(money - arr[i], arr, i));

            }

            min = Math.Min(min, MinNoOfCoins(money, arr, i + 1));

            Coin[key] = min;
            return min;



        }



    }
}
