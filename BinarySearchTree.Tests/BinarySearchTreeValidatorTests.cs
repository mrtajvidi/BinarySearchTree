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
            var root = new TreeNode { val = 5 };
            root.left = new TreeNode { val = 4 };
            root.right = new TreeNode { val = 7 };
            var isValid = _binarySearchTreeValidator.IsValidBst(root);
            Assert.True(isValid);
        }

        [Fact]
        public void BSTValidator_ValidComplexBST_ReturnTrue()
        {
            var root = new TreeNode { val = 5 };
            var node1 = new TreeNode { val = 1 };
            var node6 = new TreeNode { val = 6 };
            var node7 = new TreeNode { val = 7 };
            var node8 = new TreeNode { val = 8 };
            root.left = node1;
            root.right = node7;

            node7.left = node6;
            node7.right = node8;

            var isValid = _binarySearchTreeValidator.IsValidBst(root);
            Assert.True(isValid);
        }

        [Fact]
        public void BSTValidator_InvalidBST_ReturnFalse()
        {
            var root = new TreeNode { val = 5 };
            root.left = new TreeNode { val = 7 };
            root.right = new TreeNode { val = 4 };
            var isValid = _binarySearchTreeValidator.IsValidBst(root);
            Assert.False(isValid);
        }

        [Fact]
        public void BSTValidator_InvalidComplexBST_ReturnTrue()
        {
            var root = new TreeNode { val = 5 };
            var node1 = new TreeNode { val = 1 };
            var node6 = new TreeNode { val = 6 };
            var node7 = new TreeNode { val = 7 };
            var node4 = new TreeNode { val = 4 };
            root.left = node1;
            root.right = node6;

            node6.left = node4;
            node6.right = node7;

            var isValid = _binarySearchTreeValidator.IsValidBst(root);
            Assert.False(isValid);
        }
    }
}