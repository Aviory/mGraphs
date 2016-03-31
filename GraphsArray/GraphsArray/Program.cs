using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphsArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Node g = new Node("USA");
            MGraph mg = new MGraph();
            mg.addNode("Germany");
            mg.addNode("Ingland");
            mg.addNode("Scotland");
            mg.addNode("USA");
            mg.addEdge("Germany", "USA");
            mg.addEdge("Germany", "Scotland");
            mg.delNode(g);
            
            mg.print();
            Console.ReadKey();
        }
    }
}
