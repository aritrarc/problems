using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace nsBinaryTree
{
    public class SwapNodesAlgo
    {

        //static BinaryTree tree = new BinaryTree();
        static BTree tree = new BTree();

        #region CommentedRegion
        public static void CreateInitialBinaryTree(int[][] indexes)
        {

            // Node rootNode = new Node(1);
            // rootNode.depth = 1;
            // tree.root = rootNode;
            // Node currentNode = rootNode;

            // Node[] treeNodes = new Node[indexes.GetLength(0)];
            // treeNodes[0] = rootNode;
            // int index = 1;
            // for (int i = 0; i < indexes.GetLength(0); i++)
            // {
            //     currentNode = treeNodes[i];
            //     int left = indexes[i][0];
            //     int right = indexes[i][1];

            //     if (left != -1)
            //     {
            //         Node leftNode = new Node(left);
            //         currentNode.lchild = leftNode;
            //         leftNode.depth = currentNode.depth + 1;
            //         treeNodes[index] = leftNode;
            //         index++;
            //     }

            //     if (right != -1)
            //     {
            //         Node rightNode = new Node(right);
            //         currentNode.rchild = rightNode;
            //         rightNode.depth = currentNode.depth + 1;
            //         treeNodes[index] = rightNode;
            //         index++;
            //     }

            // }

            // Console.WriteLine("Inorder Traversal:");
            // tree.Inorder(tree.root);
            // Console.WriteLine("");
            // Console.WriteLine("Depth of Nodes:");
            // foreach (Node node in treeNodes)
            // {
            //     Console.Write(node.depth + " ");
            // }
            // Console.WriteLine("");
            // swap(new int[] { 1, 1 });
        }
        #endregion
        public static void Swap(int[][] indexes, int[] queries, int[][] results)
        {
            for (int i = 0; i < queries.Length; i++)
            {
                Queue<TreeNode> queue = new Queue<TreeNode>();
                queue.Enqueue(tree.root);
                int num = queries[i];
                while (queue.Count > 0)
                {
                    TreeNode temp = queue.Dequeue();
                    if (temp.depth % num == 0)
                    {
                        //swap
                        TreeNode x = temp.lchild;
                        temp.lchild = temp.rchild;
                        temp.rchild = x;
                    }
                    if (temp.lchild != null)
                    {
                        queue.Enqueue(temp.lchild);
                    }
                    if (temp.rchild != null)
                    {
                        queue.Enqueue(temp.rchild);
                    }
                }
                List<int> arr = new List<int>();
                Inorder(tree.root,arr);
                results[i] = arr.ToArray();
            }
        }

        private static void Inorder(TreeNode root, List<int> traversal)
        {
            if (root == null)
            {
                return;
            }
            Inorder(root.lchild,traversal);
            traversal.Add(root.data);
            Inorder(root.rchild,traversal);
        }
        public static void DriverMethod()
        {
            int[][] indexes = new int[3][];
            int[] queries = new int[]{1, 1};
            int[][] result = new int[queries.Length][];
            // for(int indexesRowItr=0; indexesRowItr<3; indexesRowItr++){
            //     indexes[indexesRowItr] = Array.ConvertAll(Console.ReadLine().Split(' '), indexesTemp => Convert.ToInt32(indexesTemp));
            // }
            // int[,] indexes = new int[11, 2] { { 2, 3 }, { 4, -1 }, { 5, -1 }, { 6, -1 }, { 7, 8 }, { -1, 9 }, { -1, -1 }, { 10, 11 }, { -1, -1 }, { -1, -1 }, { -1, -1 } };
            //int[,] indexes = new int[3, 2] { { 2, 3 }, { -1, -1 }, { -1, -1 }};
            indexes[0] = new int[2] { 2, 3 };
            indexes[1] = new int[2] { -1, -1 };
            indexes[2] = new int[2] { -1, -1 };
            //Console.WriteLine(String.Join("\n", indexes.Select(x => String.Join(" ", x))));
            //CreateInitialBinaryTree(indexes);
            result = swapNodes(indexes, queries);
            Console.WriteLine(String.Join("\n", result.Select(x => String.Join(" ", x))));
        }

        #region TreeNode
        public class TreeNode
        {
            public int data;
            public TreeNode lchild;
            public TreeNode rchild;
            public int depth;
            public TreeNode(int nodevalue)
            {
                data = nodevalue;
                lchild = null;
                rchild = null;
            }
        }
        #endregion

        #region BTree
        public class BTree
        {
            public TreeNode root;
            public BTree()
            {
                root = null;
            }

            public void CreateInitialBTree(int[][] indexes)
            {

                TreeNode rootNode = new TreeNode(1);
                rootNode.depth = 1;
                tree.root = rootNode;
                TreeNode currentNode = rootNode;

                TreeNode[] treeNodes = new TreeNode[indexes.GetLength(0)];
                treeNodes[0] = rootNode;
                int index = 1;
                for (int i = 0; i < indexes.GetLength(0); i++)
                {
                    currentNode = treeNodes[i];
                    int left = indexes[i][0];
                    int right = indexes[i][1];

                    if (left != -1)
                    {
                        TreeNode leftNode = new TreeNode(left);
                        currentNode.lchild = leftNode;
                        leftNode.depth = currentNode.depth + 1;
                        treeNodes[index] = leftNode;
                        index++;
                    }

                    if (right != -1)
                    {
                        TreeNode rightNode = new TreeNode(right);
                        currentNode.rchild = rightNode;
                        rightNode.depth = currentNode.depth + 1;
                        treeNodes[index] = rightNode;
                        index++;
                    }

                }
            }
        }
        #endregion
        static int[][] swapNodes(int[][] indexes, int[] queries)
        {
            /*
             * Write your code here.
             */
            int[][] result = new int[queries.Length][];
            tree.CreateInitialBTree(indexes);
            Swap(indexes, queries, result);
            return result;
        }
    }
}