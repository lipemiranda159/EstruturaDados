using System;
using ThreeProject.Service;
using ThreeProject.Models;

namespace ThreeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var node = new Node(100);
            var node1 = new Node(110);
            var node2 = new Node(90);
            var node3 = new Node(80);
            var root = ThreeService.AddNode(null,node);
            root = ThreeService.AddNode(root, node1);
            root = ThreeService.AddNode(root, node2);
            root = ThreeService.AddNode(root, node3);
            Console.WriteLine(ThreeService.SearchValue(1000, root));
            Console.WriteLine(ThreeService.SearchValue(80, root));
            Console.WriteLine(ThreeService.NumNodes(root));
            Console.Read();
        }
    }
}
