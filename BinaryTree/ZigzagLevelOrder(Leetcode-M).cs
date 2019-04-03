using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace nsBinaryTree
{
    public class ZigzafLevelOrder
    {
        public static BinaryTree tree = new BinaryTree();
        public static IList<IList<int>> result = new List<IList<int>>();
        public static void DriverMethod()
        {
            Node rootNode = new Node(3);
            tree.root = rootNode;
            CreateBinaryTree(tree.root);
            tree.print2D(rootNode);
            result.Clear();
            ZigZag(rootNode);

        }
        public static void ZigZag(Node root)
        {
            Stack<Node> stack1 = new Stack<Node>();
            Stack<Node> stack2 = new Stack<Node>();
            int curr_stack = 1;
            Node curr_node = null;
            stack1.Push(root);
            List<int> tempList = new List<int>();
            while (stack1.Count > 0 || stack2.Count > 0)
            {
                if (curr_stack == 1)
                {
                    curr_node = stack1.Pop();
                    tempList.Add(curr_node.data);
                    if (curr_node.lchild != null)
                    {
                        stack2.Push(curr_node.lchild);
                    }
                    if (curr_node.rchild != null)
                    {
                        stack2.Push(curr_node.rchild);
                    }
                    if (stack1.Count == 0)
                    {
                        curr_stack = 2;
                        result.Add(tempList);
                        tempList = new List<int>();
                    }
                }
                else
                {
                    curr_node = stack2.Pop();
                    tempList.Add(curr_node.data);
                    if (curr_node.rchild != null)
                    {
                        stack1.Push(curr_node.rchild);
                    }
                    if (curr_node.lchild != null)
                    {
                        stack1.Push(curr_node.lchild);
                    }
                    if (stack2.Count == 0)
                    {
                        curr_stack = 1;
                        result.Add(tempList);
                        tempList = new List<int>();
                    }
                }
            }
        }
        public static void CreateBinaryTree(Node root)
        {
            Node curr_node;
            curr_node = new Node(9);
            root.lchild = curr_node;
            curr_node = new Node(20);
            root.rchild = curr_node;

            curr_node = new Node(10);
            root.lchild.lchild = curr_node;

            curr_node = new Node(15);
            root.rchild.lchild = curr_node;
            curr_node = new Node(7);
            root.rchild.rchild = curr_node;

            curr_node = new Node(20);
            root.rchild.lchild.lchild = curr_node;
            curr_node = new Node(21);
            root.rchild.lchild.rchild = curr_node;

        }
    }

}