using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsaC.T
{
    internal class DiameterBt
    {
        HeightOfBinaryTree height = new HeightOfBinaryTree();
        public int Method(Node node)
        {
            if(node==null)
            {
                return 0;
            }

            int ldiameter = height.Method(node.left);
            int rdiameter = height.Method(node.right);



            int dia = ldiameter+1+rdiameter;

             int max = Math.Max(dia, Math.Max(Method(node.left), Method(node.right)));

            return max;



        }


    }
}
