using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace nsBinaryTree
{
    public class DepthLinkedList
    {
        public static BinaryTree tree = new BinaryTree();
        public static void DriverMethod()
        {

            BinaryTree btree = new BinaryTree();
            btree.root = MinimalBST.DriverMethod(new int[]{2, 4, 8, 9, 10, 12, 15, 17, 18, 20, 21});
            //btree.print2D(btree.root);
            List<int> depth = new List<int>();
            Queue<Node> bfs = new Queue<Node>();
            List<LinkedList<Node>> result = new List<LinkedList<Node>>();

            bfs.Enqueue(btree.root);
            depth.Add(1);
            int i=0;
            int curr_depth = 1;
            LinkedList<Node> tempList = new LinkedList<Node>();

            while(bfs.Count > 0)
            {
                Node curr_node = bfs.Dequeue();

                if(curr_node.lchild != null){
                    bfs.Enqueue(curr_node.lchild);
                    depth.Add(depth[i]+1);
                }
                if(curr_node.rchild != null){
                    bfs.Enqueue(curr_node.rchild);
                    depth.Add(depth[i]+1);
                }

                if(curr_depth == depth[i]){
                    tempList.AddLast(curr_node);
                }else{
                    result.Add(tempList);
                    curr_depth++;
                    tempList = new LinkedList<Node>();
                    tempList.AddLast(curr_node);
                }
                i++;
            }
            if(tempList.Count > 0){
                result.Add(tempList);
            }
        }
    }

}