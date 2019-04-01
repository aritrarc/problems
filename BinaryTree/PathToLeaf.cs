using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace nsBinaryTree
{
    public class PathToLeaf
    {
        public static BinaryTree tree = new BinaryTree();
        public static IList<IList<int>> pathsum = new List<IList<int>>();
        public static void DriverMethod()
        {
            Node rootNode = new Node(1);
            tree.root = rootNode;
            CreateBinaryTree(tree.root);
            //Node rootnode = MinimalBST.DriverMethod(new int[]{1, 2, 3, 4, 5, 6, 7, 8, 9});
            tree.print2D(tree.root);
            int[] pathArray = new int[1000];
            pathsum.Clear();
            //Node ancestor = FindAncestor(tree.root, 10, 9);
            //FindPathToLeaf(tree.root, pathArray, 0);
            ListPathSum(tree.root, 0, 2, new List<int>(), 0);
            foreach(List<int> list in pathsum){
                foreach(int val in list){
                    Console.Write(val + ",");
                }
                Console.WriteLine("");
            }

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
            curr_node = new Node(-2);
            root.lchild = curr_node;
            curr_node = new Node(-3);
            root.rchild = curr_node;

            curr_node = new Node(1);
            root.lchild.lchild = curr_node;
            curr_node = new Node(3);
            root.lchild.rchild = curr_node;

            curr_node = new Node(-2);
            root.rchild.lchild = curr_node;

            curr_node = new Node(-1);
            root.lchild.lchild.lchild = curr_node;

            // curr_node = new Node(2);
            // root.lchild.rchild.lchild = curr_node;

            // curr_node = new Node(11);
            // root.lchild.lchild.lchild.lchild = curr_node;
            // curr_node = new Node(12);
            // root.lchild.lchild.lchild.rchild = curr_node;

        }

        public static Boolean isPathSum = false;
        public static void FindPathSum(Node root, int curr_sum, int sum)
        {
            if (root == null)
            {
                return;
            }


            curr_sum = curr_sum + root.data;

            if (curr_sum == sum)
            {
                if (root.lchild == null && root.rchild == null)
                {
                    isPathSum = true;
                    return;
                }
            }

            FindPathSum(root.lchild, curr_sum, sum);
            FindPathSum(root.rchild, curr_sum, sum);
        }

        public static void ListPathSum(Node root, int curr_sum, int sum, List<int> path, int index)
        {
            if (root == null)
            {
                return;
            }

            if(path.Count > 0 && index < path.Count){
                path[index] = root.data;
            }else{
                path.Add(root.data);
            }
            index++;

            curr_sum = curr_sum + root.data;

            if (curr_sum == sum)
            {
                if (root.lchild == null && root.rchild == null)
                {
                    pathsum.Add(path.ToList().GetRange(0, index));
                    return;
                }
            }

            
            ListPathSum(root.lchild, curr_sum, sum, path, index);
            ListPathSum(root.rchild, curr_sum, sum, path, index);
        }
    }

}