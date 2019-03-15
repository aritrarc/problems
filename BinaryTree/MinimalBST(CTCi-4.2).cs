using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace nsBinaryTree
{
    public class MinimalBST
    {
        public static BinaryTree tree = new BinaryTree();
        public static void DriverMethod(int[] arr)
        {
            Node rootNode = CreateBST(0, arr.Length-1, arr);
            tree.root = rootNode;
            tree.print2D(tree.root);
        }

        public static Node CreateBST(int left, int right, int[] arr)
        {
            if(left > right){
                return null;
            }
            
            if(left == right){
                Node temp =new Node(arr[left]);
                return temp;
            }
            int mid = (right + left)/2;
            Node root = new Node(arr[mid]);
            root.lchild = CreateBST(left, mid - 1, arr);
            root.rchild = CreateBST(mid + 1, right, arr);
            return root;
        }
    }

}