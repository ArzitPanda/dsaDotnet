using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsaC.T
{



    /*Given a binary tree, the task is to check for every node,
    its value is equal to the sum of values of its immediate left and right child.For NULL values,
    consider the value to be 0.*/
    internal class ChildSum
    {


        public bool Method(Node a)
        {
            if (a == null) { return true; }

            if(a.left ==null && a.right ==null) { return true; }

            int left;
            if (a.left == null)
            {
                left = 0;
            }
            else
            {
                left = a.left.data;
            }

            int right;
            if (a.right == null)
            {
                right = 0;
            }
            else
            {
                right = a.right.data;
            }

            if (left+right == a.data)
            {
               bool val = true && Method(a.left) && Method(a.right);

                return val;
            }
            else
            {
                return false;
            }






        }
    }
}
