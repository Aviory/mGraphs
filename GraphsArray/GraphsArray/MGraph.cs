using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphsArray
{
    public class MGraph : Graph
    {
        Node[] mas = new Node[99];
        Node[] masArray = new Node[99];

        public void addNode(string val)
        {
            if (val == null || val == "")
                return;
            int i = 0;
            while (mas[i] != null)
            {
                i++;
            }
            mas[i] = new Node(val);
        }

        public void addEdge(string a, string b)
        {
            Node outEdge = null;
            Node inEdge = null;
            if (a == null || b == null || a == "" || b == "")
                return;
            int i = 0;
            while (mas[i] != null)
            {
                if (mas[i].val == a)
                {
                    outEdge = mas[i];
                }
                if (mas[i].val == b)
                {
                    inEdge = mas[i];
                }
                i++;
            }
            if (outEdge == null || inEdge == null)
                throw new Exception();
            outEdge.addEdge(inEdge);
        }

        public void delNode(Node n)
        {
            int i = 0;
            if (mas == null)
                return;
            while (mas[i] != null)
            {
                if (mas[i].val == n.val)
                {
                    mas[i].masEdge = null;
                    do
                    {
                        mas[i] = mas[i + 1];
                    }
                    while (mas[i + 1] != null);
                    return;
                }
                i++;
            }
            //throw new NotFiniteNumberException();
        }

        public void delEdge(int edge)
        {

            if (mas == null)
                return;
            else
            {
                int i = 0;
                while (mas[i] != null)
                {
                    int j = 0;
                    while (mas[i].masEdge[j] != null)
                    {
                        if (mas[i].masEdge[j].member == edge)
                        {
                            int r = 0;
                            do
                            {

                                mas[i].masEdge[r] = mas[i].masEdge[r+1];
                                r++;
                            } while (mas[i].masEdge[r+1].inNode != null);
                            return;
                        }
                        else
                            j++;
                    }
                    i++;
                }
            }
        }
        public void print()
        {
            int i = 0;
            while (mas[i] != null)
            {
                int j = 0;
                
                Console.Write(mas[i].val + ": ");
                while (mas[i].masEdge[j] != null)
                {
                    Console.Write(mas[i].masEdge[j].inNode.val + "(" + mas[i].masEdge[j].member + ")" + ", ");
                    j++;
                }
                Console.WriteLine();
                i++;
            }
        }
        public void toArrayDeep()
        {
            int i = 0;
            int k = 0;
            while (mas[i]!=null)
            {
                k+=i;
                masArray[k] = mas[i];
                int j = 0;
                i++;
                while (mas[i].masEdge[j] != null)
                {
                    masArray[i] = mas[i].masEdge[j].inNode;
                    k++;
                    j++;
                }
            }
        }
        public void toArrayWidth()
        {
            int i = 0;
            int k = 0;
            int j = 0;
            while (mas[i] != null)
            {
                k += i;
                masArray[i] = mas[i];
                i++;
            }
            while (mas[i].masEdge[j] != null)
            {
                masArray[i] = mas[i].masEdge[j].inNode;
                k++;
            }
        }
    }
}
