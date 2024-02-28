using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace dsaC.T
{

    /*A height balanced binary tree is a binary tree in which the height of the
    left subtree and right subtree of any node does not differ by more than 1 and both the left and right subtree are also height balanced.*/
    internal class BalancedHeight
    {


        HeightOfBinaryTree heightOfBinaryTree = new HeightOfBinaryTree();
        public bool Method(Node a)
        {
            if(a==null)
            {
                return true;
            }

            int Ltree = heightOfBinaryTree.Method(a.left);
            int rtee = heightOfBinaryTree.Method(a.right);



            if(Ltree-rtee > 2 || rtee-Ltree >2) {
                return false;
            
            }
            else
            {
                bool va = true && Method(a.left) && Method(a.right);
                return va;
            }




        }



    }
}
