using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace nsBinaryTree
{
    public class Node
    {
        public int data;
        public Node lchild;

        public Node rchild;

        public Node(int nodevalue){
            data = nodevalue;
            lchild = null;
            rchild = null;
        }
    }

    public class BinaryTree
    {
        Node root;

        public BinaryTree(){
            //Initialize root to Null. Empty Binary Tree.
            root = null;
        }

        public void CreateBinaryTree()
        {
            //Create root node first
            Node rootNode = new Node(7);
            root = rootNode;

            //Create Left children of rootnode
            Node childNode ; 
            childNode = new Node(3);
            root.lchild = childNode;
            childNode = new Node(1);
            root.lchild.lchild = childNode;
            childNode = new Node(4);
            root.lchild.rchild = childNode;
            childNode = new Node(5);
            root.lchild.rchild.rchild = childNode;

            //Create right childre on root node
            childNode = new Node(10);
            root.rchild = childNode;
            childNode = new Node(8);
            root.rchild.lchild = childNode;
            childNode = new Node(12);
            root.rchild.rchild = childNode;
            childNode = new Node(11);
            root.rchild.rchild.lchild = childNode;
            childNode = new Node(14);
            root.rchild.rchild.rchild = childNode;
        }

        public void displayBinaryTree()
        {
            displayRecursively(root,0);
        }

        void displayRecursively(Node root, int spaces)
        {
            if(root == null){
                return;
            }
            displayRecursively(root.rchild, spaces++);
            Console.Write("\n");
            for(int i=0; i<=spaces;i++){
                Console.Write(" ");
            }
            Console.Write(root.data);
            Console.Write("\n");
            displayRecursively(root.lchild, spaces++);
        }

    }

    
}