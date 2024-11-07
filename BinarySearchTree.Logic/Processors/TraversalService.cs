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

                queue.Enqueue(firstElement.left);
                queue.Enqueue(firstElement.right);
                var output = queue.Dequeue();
                result += output?.val.ToString();
            }

            return result;
        }

        public string PreOrderTraversal(TreeNode node)
        {
            var result = string.Empty;
            if (node == null)
                return result;

            return $"{node?.val}{PreOrderTraversal(node.left)}{PreOrderTraversal(node.right)}";
        }

        public string InOrderTraversal(TreeNode node)
        {
            var result = string.Empty;
            if (node == null)
                return result;

            return $"{InOrderTraversal(node.left)}{node?.val}{InOrderTraversal(node.right)}";
        }

        public string PostOrderTraversal(TreeNode node)
        {
            var result = string.Empty;
            if (node == null)
                return result;

            return $"{PostOrderTraversal(node.left)}{PostOrderTraversal(node.right)}{node?.val}";
        }

        public TreeNode InorderSuccessorBst(TreeNode root, TreeNode p)
        {
            TreeNode successor = null;

            while (root != null)
            {
                if (p.val >= root.val)
                {
                    root = root.right;
                }
                else
                {
                    successor = root;
                    root = root.left;
                }
            }

            return successor;
        }

        public TreeNode SearchBstRecursion(TreeNode root, int val)
        {
            if (root == null)
                return null;

            if (root.val == val) return root;

            if (root.val > val)
            {
                return SearchBstRecursion(root.left, val);
            }
            else
            {
                return SearchBstRecursion(root.right, val);
            }
        }

        public TreeNode SearchBstIteration(TreeNode root, int val)
        {
            while (root != null && val != root.val)
            {
                root = root.val > val ? root.left : root.right;
            }
            return root;
        }

        public TreeNode SuccessorBst(TreeNode root)
        {
            root = root.right;
            while (root.left != null)
            {
                root = root.left;
            }
            return root;
        }

        public TreeNode PredecessorBst(TreeNode root)
        {
            root = root.left;
            while (root.right != null)
            {
                root = root.right;
            }
            return root;
        }

        public TreeNode InsertIntoBST(TreeNode root, int val)
        {
            var node = root;
            while (node != null)
            {
                if (node.val < val)
                {
                    if (node.right != null)
                    {
                        node = node.right;
                    }
                    else
                    {
                        var newNode = new TreeNode();
                        newNode.val = val;
                        node.right = newNode;
                        return root;
                    }
                }
                else
                {
                    if (node.left != null)
                    {
                        node = node.left;
                    }
                    else
                    {
                        var newNode = new TreeNode();
                        newNode.val = val;
                        node.left = newNode;
                        return root;
                    }
                }
            }
            return new TreeNode();
        }

        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            var q = new Queue<TreeNode>();

            var output = new List<IList<int>>();

            var level = 0;
            q.Enqueue(root);

            while (q.Count != 0)
            {
                var currentList = new List<int>();
                var length = q.Count;

                for (int i = 0; i < length; i++)
                {
                    var node = q.Dequeue();

                    currentList.Add(node.val ?? 0);

                    if (level % 2 == 0)
                    {
                        if (node.left != null)
                        {
                            q.Enqueue(node.left);
                        }

                        if (node.right != null)
                        {
                            q.Enqueue(node.right);
                        }
                    }
                    else
                    {
                        if (node.right != null)
                        {
                            q.Enqueue(node.right);
                        }

                        if (node.left != null)
                        {
                            q.Enqueue(node.left);
                        }
                    }
                }
                level++;
                output.Add(currentList);
            }

            return output;
        }

    }
}