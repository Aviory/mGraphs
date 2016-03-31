using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphList
{
    class Program
    {
        static void Main(string[] args)
        {
            LGraph mg = new LGraph();
            mg.addNode("Germany");
            mg.addNode("Ingland");
            mg.addNode("Scotland");
            mg.addNode("USA");
            mg.addEdge("Germany", "USA");
            mg.delEdge(1);
            mg.print();
            Console.ReadKey();
        }
    }
}
