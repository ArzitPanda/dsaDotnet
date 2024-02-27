using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;



/*problem statement:
Given a positive integer K, the task is to find the minimum number of operations of the following two types, required to change 0 to K:  
Add one to the operand
Multiply the operand by 2.
*/


namespace dsaC.d
{
    public class MinimumOperation
    {


        public int[] dp;
        public MinimumOperation(int start, int end)
        {

            dp = new int[end + 1];
            Array.Fill(dp, int.MaxValue);


            int a = MinimumOperationF(start, end);

            Console.WriteLine(1 + a);
        }

        public int MinimumOperationF(int start, int end)
        {

            if (end == 0) return 0;
            if (start > end) { return int.MaxValue - 1; }

            if (start == end) return 0;


            if (dp[start] != int.MaxValue) return dp[start];


            dp[start] = Math.Min(1 + MinimumOperationF(start + 1, end), 1 + MinimumOperationF(start * 2, end));

            return dp[start];

        }


    }
}
