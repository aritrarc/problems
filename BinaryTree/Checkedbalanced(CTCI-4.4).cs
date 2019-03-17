using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace nsBinaryTree
{
    public class CheckBalanced
    {
        public static BinaryTree tree = new BinaryTree();
        public static Boolean isbalanced = true;
        public static void DriverMethod()
        {
           Node rootNode = new Node(4);
           tree.root = rootNode;
           CreateBinaryTree(tree.root);
           tree.print2D(tree.root);
           int treeDepth = Depth(tree.root);
           Console.WriteLine(treeDepth);
           Console.WriteLine(isbalanced ? "Balanced":"Not Balanced");
           
        }

        public static int Depth(Node root)
        {
            if(root == null){
                return 0;
            }
            int dLeft = Depth(root.lchild);
            int dRight = Depth(root.rchild);

            if(Math.Abs(dLeft - dRight) > 1){
                isbalanced = false;
            }

            return 1 + Math.Max(dLeft, dRight);
        }

        public static void CreateBinaryTree(Node root)
        {
            Node curr_node;
            curr_node = new Node(2);
            root.lchild = curr_node;
            curr_node = new Node(3);
            root.rchild = curr_node;

            curr_node = new Node(2);
            root.lchild.lchild = curr_node;
            curr_node = new Node(1);
            root.lchild.rchild = curr_node;

            curr_node = new Node(6);
            root.rchild.lchild = curr_node;
            curr_node = new Node(7);
            root.rchild.rchild = curr_node;

            // curr_node = new Node(13);
            // root.rchild.rchild.lchild = curr_node;
            // curr_node = new Node(14);
            // root.rchild.rchild.rchild = curr_node;

            curr_node = new Node(8);
            root.lchild.lchild.lchild = curr_node;
            curr_node = new Node(15);
            root.lchild.lchild.rchild = curr_node;
            curr_node = new Node(9);
            root.lchild.rchild.lchild = curr_node;
            curr_node = new Node(10);
            root.lchild.rchild.rchild = curr_node;

            curr_node = new Node(11);
            root.lchild.lchild.lchild.lchild = curr_node;
            curr_node = new Node(12);
            root.lchild.lchild.lchild.rchild = curr_node;

        }
    }

}