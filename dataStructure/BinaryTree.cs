using System;
using System.Collections.Generic;
using System.Text;

namespace dataStructure
{
    // Binary Tree Class
    public class BinaryTree<T>
    {
        public BinaryTreeNode<T> Root { get; set; }

        
        public void PreOrderTraversal(BinaryTreeNode<T> node)
        {
            if (node == null) return;

            Console.WriteLine(node.Data);
            PreOrderTraversal(node.Left);
            PreOrderTraversal(node.Right);
        }
    }

    // Binary Tree Node
    public class BinaryTreeNode<T>
    {
        public T Data { get; set; }
        public BinaryTreeNode<T> Left { get; set; }
        public BinaryTreeNode<T> Right { get; set; }

        public BinaryTreeNode(T data)
        {
            this.Data = data;
        }
    }
}
