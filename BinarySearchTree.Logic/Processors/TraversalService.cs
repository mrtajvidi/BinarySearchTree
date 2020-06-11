using BinarySearchTree.Logic.Models;
using System.Collections.Generic;

namespace BinarySearchTree.Logic.Processors
{
    public class TraversalService
    {
        public string LevelOrderTraversal(TreeNode node)
        {
            var result = string.Empty;

            var queue = new Queue<TreeNode>();
            queue.Enqueue(node);

            while (queue.Count > 0)
            {
                var firstElement = queue.Peek();
                if (firstElement == null) break;

                queue.Enqueue(firstElement.LeftNode);
                queue.Enqueue(firstElement.RightNode);
                var output = queue.Dequeue();
                result += output?.Value.ToString();
            }

            return result;
        }

        public string PreOrderTraversal(TreeNode node)
        {
            var result = string.Empty;
            if (node == null) 
                return result;

            return $"{node?.Value}{PreOrderTraversal(node.LeftNode)}{PreOrderTraversal(node.RightNode)}";
        }

        public string InOrderTraversal(TreeNode node)
        {
            var result = string.Empty;
            if (node == null)
                return result;

            return $"{InOrderTraversal(node.LeftNode)}{node?.Value}{InOrderTraversal(node.RightNode)}";
        }

        public string PostOrderTraversal(TreeNode node)
        {
            var result = string.Empty;
            if (node == null)
                return result;

            return $"{PostOrderTraversal(node.LeftNode)}{PostOrderTraversal(node.RightNode)}{node?.Value}";
        }
    }
}