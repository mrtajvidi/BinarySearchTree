using BinarySearchTree.Logic;
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

            var nodeToBeInserted = new TreeNode { Value = 140 };

            var result = _updateTreeService.InsertNode(root, nodeToBeInserted);
            var actual = _traversalService.LevelOrderTraversal(result);
            Assert.Equal("140", actual);
        }



        [Fact]
        public void BT_InsertIntoBT_ReturnTrue()
        {
            var root = new TreeNode { Value = 20 };
            var node100 = new TreeNode { Value = 100 };
            var node50 = new TreeNode { Value = 50 };
            var node222 = new TreeNode {Value = 222};
            var node15 = new TreeNode { Value = 15 };
            var node3 = new TreeNode { Value = 3 };
            var node250 = new TreeNode { Value = 250 };
            var node35 = new TreeNode { Value = 35 };

            root.LeftNode = node100;
            root.RightNode = node3;

            node3.LeftNode = node250;
            node3.RightNode = node35;

            node100.LeftNode = node50;
            node100.RightNode = node15;

            node50.LeftNode = node222;

            var nodeToBeInserted = new TreeNode { Value = 140 };

            var result = _updateTreeService.InsertNode(root, nodeToBeInserted);
            var actual = _traversalService.LevelOrderTraversal(result);
            Assert.Equal("201003501525035222140", actual);
        }



    }
}