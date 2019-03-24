using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace nsBinaryTree
{
    public class CheckSubTree
    {
        public static BinaryTree tree1 = new BinaryTree();
        public static BinaryTree tree2 = new BinaryTree();
        public static Boolean isbalanced = true;
        public static void DriverMethod()
        {
           Node rootNode = new Node(1);
           tree1.root = rootNode;
           Node subTreeRoot = CreateBinaryTree(tree1.root);
           tree2.root = subTreeRoot;
           Node subTreeNode;
           subTreeNode = new Node(66);
           tree2.root.lchild = subTreeNode;
           subTreeNode = new Node(77);
           tree2.root.rchild = subTreeNode;
           Console.WriteLine("Primary Tree:");
           tree1.print2D(tree1.root);
           Console.WriteLine("Sub Tree:");
           tree2.print2D(tree2.root);
           Console.WriteLine(isSubTree(tree1.root, tree2.root)? "YES":"NO");
        }

        public static Boolean isSubTree(Node root, Node subTreeRoot)
        {
            if(root == null){
                return false;
            }
            
            if(root == subTreeRoot){
                return true;
            }

            return isSubTree(root.lchild, subTreeRoot) || isSubTree(root.rchild, subTreeRoot);
        }

        public static Node CreateBinaryTree(Node root)
        {
            Node curr_node;
            Node rootOfSubtree;
            curr_node = new Node(2);
            root.lchild = curr_node;
            curr_node = new Node(3);
            root.rchild = curr_node;

            curr_node = new Node(11);
            root.lchild.lchild = curr_node;

            curr_node = new Node(4);
            root.rchild.lchild = curr_node;
 
            curr_node = new Node(5);
            root.rchild.rchild = curr_node;

            curr_node = new Node(10);
            root.rchild.rchild.lchild = curr_node;
            curr_node = new Node(6);
            root.rchild.lchild.lchild = curr_node;
            curr_node = new Node(7);
            root.rchild.lchild.rchild = curr_node;

            curr_node = new Node(13);
            root.lchild.lchild.lchild = curr_node;
            curr_node = new Node(12);
            root.lchild.lchild.rchild = curr_node;

            // curr_node = new Node(11);
            // root.lchild.lchild.lchild.lchild = curr_node;
            // curr_node = new Node(12);
            // root.lchild.lchild.lchild.rchild = curr_node;
            rootOfSubtree = new Node(4);
            return rootOfSubtree;
        }
    }

}