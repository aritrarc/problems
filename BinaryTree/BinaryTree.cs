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

        private void CreateBinaryTree()
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

        private void displayBinaryTree()
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

        private int FindHeight(Node root)
        {
            if(root == null){
                return 0;
            }

            return 1 + Math.Max(FindHeight(root.lchild), FindHeight(root.rchild));
        }

        #region Traversal
        void PreOrder(Node root)
        {
            if(root == null){
                return;
            }
            Console.Write(root.data + " ");
            PreOrder(root.lchild);
            PreOrder(root.rchild);
        }

        void Inorder(Node root)
        {
            if(root == null){
                return;
            }
            Inorder(root.lchild);
            Console.Write(root.data + " ");
            Inorder(root.rchild);
        }

        void LevelOrder(Node root){
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root.lchild);
            queue.Enqueue(root.rchild);
            Console.Write(root.data + " ");
            while(queue.Count > 0)
            {
                Node temp = queue.Dequeue();
                Console.Write(temp.data + " ");  
                if(temp.lchild != null){
                    queue.Enqueue(temp.lchild);
                }
                if(temp.rchild != null){
                    queue.Enqueue(temp.rchild);
                } 
            }
        }
        void Postorder(Node root)
        {
            if(root == null){
                return;
            }
            Postorder(root.lchild);
            Postorder(root.rchild);
            Console.Write(root.data + " ");
        }
        #endregion

        public static void BinaryTreeImplementation()
        {
            BinaryTree tree = new BinaryTree();
            tree.CreateBinaryTree();
            Console.WriteLine("Height of Binary Tree:" + tree.FindHeight(tree.root));
            Console.WriteLine("PreOrder Traversal:");
            tree.PreOrder(tree.root);
            Console.WriteLine("");
            Console.WriteLine("Inorder Traversal:");
            tree.Inorder(tree.root);
            Console.WriteLine("");
            Console.WriteLine("Postorder Traversal:");
            tree.Postorder(tree.root);
            Console.WriteLine("");
            Console.WriteLine("Levelorder Traversal:");
            tree.LevelOrder(tree.root);
        }

    }


    
}