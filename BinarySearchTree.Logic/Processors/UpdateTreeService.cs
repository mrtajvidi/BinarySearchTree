using BinarySearchTree.Logic.Models;
using System.Collections.Generic;

namespace BinarySearchTree.Logic.Processors
{
    public class UpdateTreeService
    {
        public TreeNode InsertNode(TreeNode root, TreeNode nodeToBeInserted)
        {
            if (root.val == null)
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

                if (firstElement.left == null)
                {
                    firstElement.left = nodeToBeInserted;
                    break;
                }
                else
                {
                    queue.Enqueue(firstElement.left);
                }

                if (firstElement.right == null)
                {
                    firstElement.right = nodeToBeInserted;
                    break;
                }
                else
                {
                    queue.Enqueue(firstElement.right);
                }
                queue.Dequeue();
            }

            return root;
        }

        public TreeNode DeleteNode(TreeNode root, TreeNode nodeToBeInserted)
        {
            if (root.val == null)
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

                if (firstElement.left == null)
                {
                    firstElement.left = nodeToBeInserted;
                    break;
                }
                else
                {
                    queue.Enqueue(firstElement.left);
                }

                if (firstElement.right == null)
                {
                    firstElement.right = nodeToBeInserted;
                    break;
                }
                else
                {
                    queue.Enqueue(firstElement.right);
                }
                queue.Dequeue();
            }

            return root;
        }
    }
}