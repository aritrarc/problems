using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace nsBinaryTree
{
    public class InorderSuccessor
    {
        public class BNode
        {
            public int data;
            public BNode lchild;

            public BNode rchild;

            public BNode next;

            public BNode(int nodevalue)
            {
                data = nodevalue;
                lchild = null;
                rchild = null;
                next = null;
            }
        }

        public class BTree
        {

            public BNode root;

            public BTree()
            {
                root = null;
            }

            public BNode CreateBTree()
            {
                BNode node;
                node = new BNode(1);
                root = node;

                node = new BNode(2);
                root.lchild = node;
                node = new BNode(3);
                root.rchild = node;
                node = new BNode(4);
                root.lchild.lchild = node;
                node = new BNode(5);
                root.rchild.lchild = node;
                node = new BNode(6);
                root.rchild.rchild = node;

                return root;

            }

            public void Display(BNode root, int level)
            {
                // Base case 
                int i;
                if (root == null)
                    return;


                // Process right child first  
                Display(root.rchild, level + 1);

                Console.WriteLine("");
                for (i = 0; i < level; i++)
                    Console.Write("   ");

                Console.WriteLine(root.data);

                // Process left child  
                Display(root.lchild, level + 1);
            }

            // Wrapper over Display function
            public void print2D(BNode root)
            {
                // Pass initial level as 0  
                Display(root, 0);
            }
        }
        public static void DriverMethod()
        {
            BTree tree = new BTree();
            BNode root = tree.CreateBTree();
            tree.print2D(tree.root);
            Successor(tree.root);
            Inorder(tree.root);

        }
        public static BNode next_node = null;
        public static void Successor(BNode root)
        {
            if(root != null){

                Successor(root.rchild);
                root.next = next_node;
                next_node = root;

                Successor(root.lchild);
            }
            
        }

        public static void Inorder(BNode root){
            if(root == null){
                return;
            }
            Inorder(root.lchild);
            Console.Write(root.next == null? "-1":root.next.data + " ");
            Inorder(root.rchild);
        }

    }

}