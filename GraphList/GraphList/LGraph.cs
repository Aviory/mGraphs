using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphList
{
    class LGraph : Graph
    {
        Node root = null;
        public void addNode(string val)
        {
            if (val == null || val == "")
                return;
            if (root == null)
            {
                Node n = new Node(val);
                root = n;
                return;
            }
            else
            {
                Node next = root;
                while (next.nextNode != null)
                {
                    next = next.nextNode;
                }
                next.nextNode = new Node(val);
            }  
        }

       public void addEdge(string a, string b)
        {

            Node outEdge = null;
            Node inEdge = null;
            if (a == null || b == null || a == "" || b == "")
                return;
            Node next = root;
            while (next != null)
            {
                if (next.val == a)
                {
                    outEdge = next;
                }
                if (next.val == b)
                {
                    inEdge = next;
                }
                next = next.nextNode;
            }
            if (outEdge == null || inEdge == null)
                throw new Exception();
            outEdge.addEdge(inEdge);
        }

        public void delNode(Node n)
        {
            Node next = root;
            if (root == null)
                return;
            if (n.val == root.val)
            {
                root = null;
                return;
            }
            else
            {
                while (next != null)
                {
                    if (next.nextNode.val == n.val)
                    {
                        Node tmp = next.nextNode;
                        next.nextNode = next.nextNode.nextNode;
                        tmp.nextNode = null;
                        tmp.inEdge = null;
                        return;
                    }
                    else
                    {
                        next = n.nextNode;
                    }
                }
                throw new NotFiniteNumberException();
            }
        }

        public void delEdge(int edge)
        {
            Node next = root;
            if (root == null)
                return;
            else
            {
                while(next!=null)
                {
                    while (next.inEdge != null)
                    {    
                        if (next.inEdge.member == edge)
                        {
                            next.inEdge = null;
                            return;
                        }
                        if (next.inEdge.nextEdge.member != edge)
                        {
                            Edge tmp = next.inEdge.nextEdge;
                            next.inEdge = next.inEdge.nextEdge.nextEdge;
                            tmp.inNode = null;
                            tmp.nextEdge = null;
                            return;
                        }
                        next.inEdge = next.inEdge.nextEdge;
                    }
                    next = next.nextNode;
                }
            }
        }

        public void print()
        {
            Node next = root;
            while (next != null)
            {
                Console.Write(next.val + ": ");
                while (next.inEdge != null)
                {
                    Console.Write(next.inEdge.inNode.val + "(" + next.inEdge.member + ")");
                    next.inEdge = next.inEdge.nextEdge;
                }
                next = next.nextNode;
                Console.WriteLine();
            }
        }
        public void toArray()
        {

        }
    }
}
