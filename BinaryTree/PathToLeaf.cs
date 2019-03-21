using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace nsBinaryTree
{
    public class PathToLeaf
    {
        public static BinaryTree tree = new BinaryTree();
        public static void DriverMethod()
        {
            Node rootNode = new Node(1);
            tree.root = rootNode;
            CreateBinaryTree(tree.root);
            //Node rootnode = MinimalBST.DriverMethod(new int[]{1, 2, 3, 4, 5, 6, 7, 8, 9});
            tree.print2D(tree.root);
            int[] pathArray = new int[1000];
            //Node ancestor = FindAncestor(tree.root, 10, 9);
            FindPathToLeaf(tree.root, pathArray, 0);

        }

        public static void FindPathToLeaf(Node root, int[] path, int len)
        {
            if (root == null)
            {
                return;
            }

            path[len] = root.data;
            len++;
            if (root.lchild == null && root.rchild == null)
            {
                PrintPath(path, len);
            }
            else
            {
                FindPathToLeaf(root.lchild, path, len);
                FindPathToLeaf(root.rchild, path, len);
            }
        }

        private static void PrintPath(int[] path, int len)
        {
            for (int i = 0; i < len; i++)
            {
                Console.Write(path[i] + " ");
            }
            Console.WriteLine();
        }
        public static void CreateBinaryTree(Node root)
        {
            Node curr_node;
            curr_node = new Node(2);
            root.lchild = curr_node;
            curr_node = new Node(3);
            root.rchild = curr_node;

            curr_node = new Node(4);
            root.lchild.lchild = curr_node;
            curr_node = new Node(5);
            root.lchild.rchild = curr_node;

            curr_node = new Node(6);
            root.rchild.lchild = curr_node;
            curr_node = new Node(7);
            root.rchild.rchild = curr_node;

            curr_node = new Node(8);
            root.lchild.lchild.lchild = curr_node;
            curr_node = new Node(9);
            root.lchild.rchild.lchild = curr_node;
            curr_node = new Node(10);
            root.lchild.rchild.rchild = curr_node;

            curr_node = new Node(11);
            root.rchild.lchild.lchild = curr_node;
            curr_node = new Node(12);
            root.rchild.lchild.rchild = curr_node;
            curr_node = new Node(13);
            root.rchild.rchild.rchild = curr_node;
            // curr_node = new Node(2);
            // root.lchild.rchild.lchild = curr_node;

            // curr_node = new Node(11);
            // root.lchild.lchild.lchild.lchild = curr_node;
            // curr_node = new Node(12);
            // root.lchild.lchild.lchild.rchild = curr_node;

        }
    }

}