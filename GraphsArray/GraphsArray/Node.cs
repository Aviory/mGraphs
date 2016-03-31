using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphsArray
{
    public class Node
    {

        public string val = "";
        public Edge[] masEdge = new Edge[99];


        public Node(string val)
        {
            this.val = val;
        }
        public void addEdge(Node n)
        {
            if (masEdge == null)
            {
                masEdge = new Edge[99];
            }
            int i = 0;
            while (masEdge[i] != null)
            {
                i++;
            }
            masEdge[i] = new Edge(n);
        }
    }
}
