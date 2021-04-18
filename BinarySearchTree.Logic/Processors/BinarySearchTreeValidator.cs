using BinarySearchTree.Logic.Models;

namespace BinarySearchTree.Logic.Processors
{
    public class BinarySearchTreeValidator
    {
        public bool IsValidBst(TreeNode root)
        {
            return IsWithinRange(root, int.MinValue, int.MaxValue);
        }

        private bool IsWithinRange(TreeNode node, int? lowerValue, int? upperValue)
        {
            if (node == null) return true;

            if (node.val <= lowerValue || node.val >= upperValue) return false;

            if (!IsWithinRange(node.right, node.val, upperValue)) return false;

            if (!IsWithinRange(node.left, lowerValue, node.val)) return false;

            return true;
        }
    }
}