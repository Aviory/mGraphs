using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphsArray
{
    interface Graph
    {
        void addNode(string val);
        void addEdge(string a, string b);
        void delNode(Node n);
        void delEdge(int edge);
        void print();
    }
}
