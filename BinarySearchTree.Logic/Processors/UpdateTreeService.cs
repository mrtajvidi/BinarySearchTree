using BinarySearchTree.Logic.Models;
using System.Collections.Generic;

namespace BinarySearchTree.Logic.Processors
{
    public class UpdateTreeService
    {
        public TreeNode InorderSuccessor(TreeNode root, TreeNode p)
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

        public TreeNode InsertIntoBSTRecursive(TreeNode root, int val)
        {
            if (root == null)
            {
                return new TreeNode { val = val };
            }
            if (root.val < val)
            {           // insert to the right subtree if val > root->val
                root.right = InsertIntoBSTRecursive(root.right, val);
            }
            else
            {                        // insert to the left subtree if val <= root->val
                root.left = InsertIntoBSTRecursive(root.left, val);
            }
            return root;
        }

        public TreeNode InsertIntoBstIteration(TreeNode root, int val)
        {
            if (root == null)
            {
                return new TreeNode { val = val };
            }

            var curr = root;
            while (curr != null)
            {
                var firstElement = curr;

                if (firstElement.val > val)
                {
                    if (firstElement.left == null)
                    {
                        firstElement.left = new TreeNode { val = val };
                        break;
                    }
                    else
                    {
                        curr = firstElement.left;
                    }
                }
                else
                {
                    if (firstElement.right == null)
                    {
                        firstElement.right = new TreeNode { val = val };
                        break;
                    }
                    else
                    {
                        curr = firstElement.right;
                    }
                }
            }
            return root;
        }

        public TreeNode InsertNodeIteration(TreeNode root, TreeNode nodeToBeInserted)
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

        public TreeNode DeleteNode(TreeNode root, int key)
        {
            if (root == null) return null;

            if (root.val > key)
            {
                root.right = DeleteNode(root.left, key);
            }
            else if (root.val < key)
            {
                root.left = DeleteNode(root.right, key);
            }
            else
            {
                // node is a leaf
                if (root.left == null && root.right == null)
                {
                    root = null;
                }
                else if (root.right != null)
                {
                    root.val = SuccessorBst(root).val;
                    root.right = DeleteNode(root.right, root.val ?? 0);
                }
                else
                {
                    root.val = PredecessorBst(root).val;
                    root.left = DeleteNode(root.left, root.val ?? 0);
                }
            }

            return root;
        }
    }
}