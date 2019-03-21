using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace nsBinaryTree
{
    public class CommonAncestor
    {
        public static BinaryTree tree = new BinaryTree();
        public static void DriverMethod()
        {
           //Node rootNode = new Node(1);
           //tree.root = rootNode;
           //CreateBinaryTree(tree.root);
           Node rootnode = MinimalBST.DriverMethod(new int[]{1, 2, 3, 4, 5, 6, 7, 8, 9});
           //tree.print2D(rootnode);
           //Node ancestor = FindAncestor(tree.root, 10, 9);
           Node ancestor = FindAncestorBST(rootnode, 6, 9);
           if(ancestor == null){Console.WriteLine("null");return;}
           Console.WriteLine("Ancestor:" +ancestor.data);
           
        }

        public static Node FindAncestor(Node root, int p, int q)
        {
            if(root == null){
                return null;
            }

            if(root.data == p || root.data == q){
                return root;
            }
            
            Node left = FindAncestor(root.lchild, p, q);
            Node right = FindAncestor(root.rchild, p, q);

            if(left != null && right != null){
                return root;
            }

            return left == null? right: left;

        }

        public static Node FindAncestorBST(Node root, int p, int q){

            if(root == null){
                return null;

            }
            if((root.data >= p && root.data <= q) || (root.data >= q && root.data <= p)){
                return root;
            }

            if(root.data > p){
                return FindAncestorBST(root.lchild, p, q);
            }else{
                return FindAncestorBST(root.rchild, p, q);
            }

        }

        public static void CreateBinaryTree(Node root)
        {
            Node curr_node;
            curr_node = new Node(5);
            root.lchild = curr_node;
            curr_node = new Node(4);
            root.rchild = curr_node;

            curr_node = new Node(3);
            root.lchild.lchild = curr_node;
            curr_node = new Node(2);
            root.lchild.rchild = curr_node;

            curr_node = new Node(7);
            root.rchild.lchild = curr_node;
            // curr_node = new Node(7);
            // root.rchild.rchild = curr_node;

            curr_node = new Node(8);
            root.rchild.lchild.lchild = curr_node;
            curr_node = new Node(9);
            root.rchild.lchild.rchild = curr_node;

            curr_node = new Node(10);
            root.lchild.lchild.lchild = curr_node;
            curr_node = new Node(11);
            root.lchild.lchild.rchild = curr_node;
            curr_node = new Node(9);
            root.lchild.rchild.lchild = curr_node;
            curr_node = new Node(2);
            root.lchild.rchild.lchild = curr_node;

            // curr_node = new Node(11);
            // root.lchild.lchild.lchild.lchild = curr_node;
            // curr_node = new Node(12);
            // root.lchild.lchild.lchild.rchild = curr_node;

        }
    }

}