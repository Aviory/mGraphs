using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphList
{
    public class Node
    {
        public string val="";
        public Edge inEdge = null;
        public Node nextNode = null;
        
        public Node(string val) 
        {
            this.val = val;
        }
        public void addEdge(Node n)
        {
            if (inEdge == null)
            {
                inEdge = new Edge(n);
            }
            else
            {
                if (inEdge.nextEdge == null)
                {
                    inEdge.nextEdge = new Edge(n);
                }
                else
                    addEdge(inEdge.nextEdge.inNode);
            }
        }
    }
}
