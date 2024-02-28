// See https://aka.ms/new-console-template for more information





using dsaC.d;
using dsaC.T;

namespace dsaC
{


    public class Program
    {





        public static void Main(string[] args)
        {


            /*  MinimumNoOfCoin MN = new MinimumNoOfCoin(); 

              int val = MN.MinNoOfCoins(300,[ 18,11],0);
              Console.WriteLine(val); */

            /*
                        MaximumProductCutting maximumProductCutting = new MaximumProductCutting();
                        int val = maximumProductCutting.method(10, 1);
                        Console.WriteLine(val);*/

            /*  NumberOfWayToCoverDistance numberOfWayToCoverDistance = new NumberOfWayToCoverDistance();
          int a  = numberOfWayToCoverDistance.Method(4);
          Console.WriteLine(a);*/



            /* TransformStringMinimumOperation transformStringMinimumOperation = new TransformStringMinimumOperation();
               int a  =   transformStringMinimumOperation.Method("geeksforgeeks", "geeks");
             Console.WriteLine(a);*/


            /*
                        MinimumSubSequenceFourConsecutive min = new MinimumSubSequenceFourConsecutive();
                        min.Method([1, 2, 3, 4, 5, 6, 7, 8]);*/



            /*    SubsetSum sum = new SubsetSum();
                bool val =  sum.Method([3, 34, 3, 12, 5, 2], 9, 0);*/
            //onsole.WriteLine(val);


            /*
                        LongestIncreasingSubsequence l = new LongestIncreasingSubsequence();
                        int a = l.Method([1,2,3,4,5,6,7,3],0,0);
                        Console.WriteLine(a);*/


            /*EditDistance a = new EditDistance();
            int b = a.Method("mnijfbsbfhsbfwjhsfsokfws", "Cutsfdsfbwhfbwhtfwb",0,0);
            Console.WriteLine(b);*/

            /*  LongestPathInAMatrix aMatrix = new LongestPathInAMatrix();
              int[][] mat = new int[][]
              {
      new int[] { 1, 2},
      new int[] { 4, 3 },

              };


              int b = aMatrix.Method(mat, 0, 0);

              Console.WriteLine(b);
  */


            /*  OptimalSolution solution = new OptimalSolution();
               int a = solution.Method([5,3,7,10,12,123,4,2], 0, 7);
              Console.WriteLine(a);
  */

            /*   MinimumTimeToFinishTaskWithoutSkipTwo a = new MinimumTimeToFinishTaskWithoutSkipTwo();
               var b = a.Method([10, 5, 2, 4, 8, 6, 7, 10], 0, true);
               Console.WriteLine(b);*/

            /*
                            CountPalindromeSequence palidrome = new CountPalindromeSequence();

                        string str = "aaaa";
                                int a = palidrome.Method(0, str.Length - 1,str, 0);
                        Console.WriteLine(a);*/


            /* FormAPalindrome formAPalindrome = new FormAPalindrome();
             int a = formAPalindrome.Method("abcda", 0, "abcda".Length - 1);

             Console.WriteLine(a);*/

            /*
                        GetMinimumSquare square = new GetMinimumSquare();
                        int a = square.Method(100, 1);
                        Console.WriteLine(a);*/

            /*
                        ShortestCommonSuperSequence shortestCommonSuperSequence = new ShortestCommonSuperSequence();
                         int res =   shortestCommonSuperSequence.Method("eke", "geke");
                        Console.WriteLine(res);*/

            /*  PartitionProblem problem = new PartitionProblem();
              bool value  = problem.Method([1, 5, 11, 5]);
              Console.WriteLine(value);*/


            /*
                        RodCutting s = new RodCutting();

                         int maxx =  s.Method([0,-10,28,30], 3, 1);

                        Console.WriteLine(maxx);*/

            /*   LongestCommonSubstring L = new LongestCommonSubstring();
                  int a = L.Method("abcdexcvndsbgbsgbdsgds", "aabcldfeasfbshwfbsfbfcafda", 0, 0);
                       Console.WriteLine(a);*/

            /*  UniqueBst uniqueBst = new UniqueBst();
              int a = uniqueBst.Method(3,1);
              Console.WriteLine(a);*/

            /*
                        InterLeavedString interLeavedString = new InterLeavedString();
                        bool value = interLeavedString.Method("XXsgagsgY", "XXsvfsgdhZ", "XXXXZdhdashhY", 0, 0, 0);
                        Console.WriteLine(value);*/


            Node root = new Node(10);
            root.left = new Node(7);
            root.right = new Node(3);
            root.left.left = new Node(4);
            root.left.right = new Node(3);
            root.right.left = new Node(3);
            root.right.left.right = new Node(3);

            /* HeightOfBinaryTree heightOfBinaryTree = new HeightOfBinaryTree();
             int a =   heightOfBinaryTree.MethodLevelOrder(root);
             Console.WriteLine(a);*//*

                 DiameterBt diameterBt = new DiameterBt();
                     int a = diameterBt.Method(root);
                     Console.WriteLine(a);
 */
            ChildSum childSum = new ChildSum();
            bool val = childSum.Method(root);
            Console.WriteLine(val);


            /*   PalindrmeDelete p = new PalindrmeDelete();
               p.minStepsToDeleteStringWithPalindrome("2553432", 0, 0);*/


        }
    }



}


//Dictionary<int,int> keyValuePairs = new Dictionary<int,int>();



