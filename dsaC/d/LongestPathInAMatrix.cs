using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace dsaC.d
{


    /*    Given a n* n matrix where all numbers are distinct, find the maximum length path(starting from any cell) such that all cells along the path are in increasing order with a difference of 1. 
    We can move in 4 directions from a given cell(i, j), i.e., we can move to(i+1, j) or(i, j+1) or(i-1, j) or(i, j-1) with the condition that the adjacent cells have a difference of 1.

    Example: 

    Input:  mat[][] = {{1, 2, 9}
    { 5, 3, 8}
    { 4, 6, 7}}
    Output: 4
    The longest path is 6-7-8-9. */


    internal class LongestPathInAMatrix
    {


        bool CanJump(int sourceX, int sourceY, int destX, int destY, int[][] mat)
        {
            if (destX < 0 || destY < 0 || destY >= mat[0].Length || destX >= mat.Length)
            {
                return false;
            }

            Console.WriteLine($"{destX}-{destY}-mat[d]={mat[destX][destY]}  and {sourceX}-{sourceY}-mat[s]-{mat[sourceX][sourceY]}");
            int C = mat[destX][destY] - mat[sourceX][sourceY];


            if (C == 1) return true;

            return false;

        }

        int[] U = [0, 1, 0, -1];
        int[] D = [1, 0, -1, 0];





        public int Method(int[][] matrix, int i, int j)
        {


            if (i >= matrix.Length || j >= matrix[0].Length || i < 0 || j < 0)
            {

                return 0;


            }

            int Max = 0;

            for (int l = i; l < matrix.Length; l++)
            {
                for (int k = j; k < matrix[0].Length; k++)
                {
                    string key = $"{l}-{k}";


                    for (int M = 0; M < U.Length; M++)
                    {


                        int distance = matrix[l][k];


                        if (CanJump(l, k, l + U[M], k + D[M], matrix))
                        {


                            Console.WriteLine($"{l}-{k}");

                            distance += Method(matrix, i + U[M], j + D[M]);





                        }
                        Max = Math.Max(Max, distance);


                    }






                }



            }


            return Max;








        }






    }
}
