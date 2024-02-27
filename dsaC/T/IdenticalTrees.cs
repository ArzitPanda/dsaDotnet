using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsaC.T
{




    internal class IdenticalTrees
    {


        public bool Method(Node a ,Node b)
        {
            if(a.data!=b.data) return false;


            return true && Method(a.left,b.left)&&Method(a.right,b.right);



        }

    }
}
