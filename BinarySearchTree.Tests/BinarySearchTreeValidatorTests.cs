using BinarySearchTree.Logic.Models;
using BinarySearchTree.Logic.Processors;
using Xunit;

namespace BinarySearchTree.Tests
{
    public class BinarySearchTreeValidatorTests
    {
        private readonly BinarySearchTreeValidator _binarySearchTreeValidator;

        public BinarySearchTreeValidatorTests()
        {
            _binarySearchTreeValidator = new BinarySearchTreeValidator();
        }

        [Fact]
        public void BSTValidator_ValidBST_ReturnTrue()
        {
            var root = new TreeNode { Value = 5 };
            root.LeftNode = new TreeNode { Value = 4 };
            root.RightNode = new TreeNode { Value = 7 };
            var isValid = _binarySearchTreeValidator.IsValidBst(root);
            Assert.True(isValid);
        }

        [Fact]
        public void BSTValidator_ValidComplexBST_ReturnTrue()
        {
            var root = new TreeNode { Value = 5 };
            var node1 = new TreeNode { Value = 1 };
            var node6 = new TreeNode { Value = 6 };
            var node7 = new TreeNode { Value = 7 };
            var node8 = new TreeNode { Value = 8 };
            root.LeftNode = node1;
            root.RightNode = node7;

            node7.LeftNode = node6;
            node7.RightNode = node8;

            var isValid = _binarySearchTreeValidator.IsValidBst(root);
            Assert.True(isValid);
        }

        [Fact]
        public void BSTValidator_InvalidBST_ReturnFalse()
        {
            var root = new TreeNode { Value = 5 };
            root.LeftNode = new TreeNode { Value = 7 };
            root.RightNode = new TreeNode { Value = 4 };
            var isValid = _binarySearchTreeValidator.IsValidBst(root);
            Assert.False(isValid);
        }

        [Fact]
        public void BSTValidator_InvalidComplexBST_ReturnTrue()
        {
            var root = new TreeNode { Value = 5 };
            var node1 = new TreeNode { Value = 1 };
            var node6 = new TreeNode { Value = 6 };
            var node7 = new TreeNode { Value = 7 };
            var node4 = new TreeNode { Value = 4 };
            root.LeftNode = node1;
            root.RightNode = node6;

            node6.LeftNode = node4;
            node6.RightNode = node7;

            var isValid = _binarySearchTreeValidator.IsValidBst(root);
            Assert.False(isValid);
        }
    }
}