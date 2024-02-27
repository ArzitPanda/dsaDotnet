using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsaC.T
{
    internal class HeightOfBinaryTree
    {


        public int Method(Node a )
        {
            if(a ==null)
            {
                return 0;
            }
            



            int leftDepth = Method(a.left);
            int rightDepth = Method(a.right);   

            return 1+Math.Max(leftDepth, rightDepth);



        }

        Queue<Node> queue = new Queue<Node>();

        public int MethodLevelOrder(Node a)
        {
            if(a ==null) { return 0; }

            queue.Enqueue(a);

            int depth =0;
           

            while(queue.Count >0)
            {
                int size = queue.Count;

                for (int i = 0; i < size; i++)
                {
                  
                    Node n = queue.Dequeue();
                    if(n.left !=null)
                    {
                        queue.Enqueue(n.left);
                    }
                    if(n.right !=null)
                    {
                        queue.Enqueue(n.right);
                    }
                }
                depth++;

            }
          


          return depth;


        }




    }
}
