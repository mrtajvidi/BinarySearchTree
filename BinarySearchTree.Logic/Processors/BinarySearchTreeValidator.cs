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

            if (node.Value <= lowerValue || node.Value >= upperValue) return false;

            if (!IsWithinRange(node.RightNode, node.Value, upperValue)) return false;

            if (!IsWithinRange(node.LeftNode, lowerValue, node.Value)) return false;

            return true;
        }
    }
}