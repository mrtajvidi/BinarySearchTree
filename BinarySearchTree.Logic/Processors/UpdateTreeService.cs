using System;
using System.Collections.Generic;
using System.Text;
using BinarySearchTree.Logic.Models;

namespace BinarySearchTree.Logic.Processors
{
    public class UpdateTreeService
    {
        public TreeNode InsertNode(TreeNode root, TreeNode nodeToBeInserted)
        {
            if (root.Value == null)
            {
                root = nodeToBeInserted;
                return root;
            }

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var firstElement = queue.Peek();
                if (firstElement == null) break;

                if (firstElement.LeftNode == null)
                {
                    firstElement.LeftNode = nodeToBeInserted;
                    break;
                }
                else
                {
                    queue.Enqueue(firstElement.LeftNode);
                }

                if (firstElement.RightNode == null)
                {
                    firstElement.RightNode = nodeToBeInserted;
                    break;
                }
                else
                {
                    queue.Enqueue(firstElement.RightNode);
                }
                queue.Dequeue();
            }

            return root;
        }


        public TreeNode DeleteNode(TreeNode root, TreeNode nodeToBeInserted)
        {
            if (root.Value == null)
            {
                root = nodeToBeInserted;
                return root;
            }

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var firstElement = queue.Peek();
                if (firstElement == null) break;

                if (firstElement.LeftNode == null)
                {
                    firstElement.LeftNode = nodeToBeInserted;
                    break;
                }
                else
                {
                    queue.Enqueue(firstElement.LeftNode);
                }

                if (firstElement.RightNode == null)
                {
                    firstElement.RightNode = nodeToBeInserted;
                    break;
                }
                else
                {
                    queue.Enqueue(firstElement.RightNode);
                }
                queue.Dequeue();
            }

            return root;
        }


    }
}
