using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphList
{
    public class Edge
    {
        public int member = 0;
        private static int count=0;
        public Node inNode=null;
        public Edge nextEdge = null;
        public Edge(Node inNode)
        {
            this.inNode = inNode;
            count++;
            member = count;
        }
        public static int setCount()
        {
            return count;
        }
    }
}

