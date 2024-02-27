using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsaC.T
{
    internal class MirrorTree
    {

        public bool Method(Node a,Node b)
        {
            if (a == null || b == null) return true;

              


            if(a.data==b.data)
            {
                return Method(a.left,b.right)&&Method(a.right,b.left);

            }
            else
            {
                return false;
            }



        }


    }
}
