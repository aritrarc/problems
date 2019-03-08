using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace nsBinaryTree
{
    public class HuffmanNode
    {
        public int freq;
        public string data;
        public HuffmanNode left;
        public HuffmanNode right;
        public HuffmanNode(string nodevalue)
        {
            data = nodevalue;
            freq = 0;
            left = null;
            right = null;
        }
    }

    public class HuffmanTree
    {
        public HuffmanNode root;
        public HuffmanTree()
        {
            root = null;
        }

        public void ConstructHuffmanTree()
        {

            //rootNode
            HuffmanNode rootNode = new HuffmanNode(null);
            root = rootNode;
            rootNode.freq = 11;

            HuffmanNode node;

            //leftchild
            node = new HuffmanNode("A");
            node.freq = 5;
            rootNode.left = node;

            //rightchild
            node = new HuffmanNode(null);
            node.freq = 6;
            rootNode.right = node;

            node = new HuffmanNode("R");
            node.freq = 2;
            rootNode.right.left = node;

            node = new HuffmanNode(null);
            node.freq = 4;
            rootNode.right.right = node;

            node = new HuffmanNode(null);
            node.freq = 2;
            rootNode.right.right.left = node;

            node = new HuffmanNode("B");
            node.freq = 2;
            rootNode.right.right.right = node;

            node = new HuffmanNode("C");
            node.freq = 1;
            rootNode.right.right.left.left = node;

            node = new HuffmanNode("D");
            node.freq = 1;
            rootNode.right.right.left.right = node;
        }
    }

    
 
    public class HuffManDecoding
    {
        static  HuffmanTree huffTree = new HuffmanTree();
        public static void DriverCode()
        {
           
            huffTree.ConstructHuffmanTree();

            string s = "01111001100011010111100";
            string result = string.Empty;
            for (int i = 0; i < s.Length;)
            {
                HuffmanNode currentNode = huffTree.root;
                while (!(currentNode.left == null && currentNode.right == null))
                {
                    if (s[i].ToString() == "1")
                    {
                        currentNode = currentNode.right;
                        i++;
                    }
                    else
                    {
                        currentNode = currentNode.left;
                        i++;
                    }
                }
                result += currentNode.data;
            }
            Console.WriteLine(result);
        }
    }

}