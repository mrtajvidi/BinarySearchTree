using BinarySearchTree.Logic.Models;
using BinarySearchTree.Logic.Processors;
using Xunit;

namespace BinarySearchTree.Tests
{
    public class UpdateTreeServiceTests
    {
        private readonly UpdateTreeService _updateTreeService;
        private readonly TraversalService _traversalService;

        public UpdateTreeServiceTests()
        {
            _updateTreeService = new UpdateTreeService();
            _traversalService = new TraversalService();
        }

        [Fact]
        public void BT_InsertIntoEmptyBT_ReturnTrue()
        {
            var root = new TreeNode();

            var nodeToBeInserted = new TreeNode { val = 140 };

            var result = _updateTreeService.InsertNode(root, nodeToBeInserted);
            var actual = _traversalService.LevelOrderTraversal(result);
            Assert.Equal("140", actual);
        }

        [Fact]
        public void BT_InsertIntoBT_ReturnTrue()
        {
            var root = new TreeNode { val = 20 };
            var node100 = new TreeNode { val = 100 };
            var node50 = new TreeNode { val = 50 };
            var node222 = new TreeNode { val = 222 };
            var node15 = new TreeNode { val = 15 };
            var node3 = new TreeNode { val = 3 };
            var node250 = new TreeNode { val = 250 };
            var node35 = new TreeNode { val = 35 };

            root.left = node100;
            root.right = node3;

            node3.left = node250;
            node3.right = node35;

            node100.left = node50;
            node100.right = node15;

            node50.left = node222;

            var nodeToBeInserted = new TreeNode { val = 140 };

            var result = _updateTreeService.InsertNode(root, nodeToBeInserted);
            var actual = _traversalService.LevelOrderTraversal(result);
            Assert.Equal("201003501525035222140", actual);
        }
    }
}