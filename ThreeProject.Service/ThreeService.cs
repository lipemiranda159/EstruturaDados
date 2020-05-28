using System;
using ThreeProject.Models;

namespace ThreeProject.Service
{
    public static class ThreeService
    {
        public static Node AddNode(Node root,Node node){
            if (root == null)
            {
                return node;
            } else if (node.Key < root.Key)
            {
                root.LeftNode = AddNode(root.LeftNode, node);
            } else if (node.Key > root.Key)
            {
                root.RightNode = AddNode(root.RightNode, node);
            }

            return root;
        }

        public static bool SearchValue(int value, Node root){
            if (root == null)
            {
                return false;
            }

            if (root.Key == value)
            {
                return true;
            } else if (value < root.Key){
                return SearchValue(value, root.LeftNode);
            } else if (value > root.Key)
                return SearchValue(value, root.RightNode);
            return false;
            
        }

        public static int NumNodes(Node root)
        {
            if (root == null)
            {
                return 0;
            }
            return NumNodes(root.LeftNode)+1+
            NumNodes(root.RightNode);
        }
    }
}
