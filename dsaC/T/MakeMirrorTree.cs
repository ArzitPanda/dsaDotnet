using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsaC.T
{
    internal class MakeMirrorTree
    {

        public Node Method(Node node,Node temp)
        {

            if(node== null)
            {
                return temp;
            }

            temp = new Node(node.data);
            if(node.left != null)
            {

                temp.right = Method(node.left,temp.right);

            }
            if(node.right != null)
            {

                temp.left = Method(node.right,temp.left);
            }

            return temp;

            



        }



    }
}
