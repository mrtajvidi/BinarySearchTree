using BinarySearchTree.Logic.Models;
using BinarySearchTree.Logic.Processors;
using Xunit;

namespace BinarySearchTree.Tests
{
    public class TraversalServiceTests
    {
        private readonly TraversalService _traversalService;

        public TraversalServiceTests()
        {
            _traversalService = new TraversalService();
        }

        [Fact]
        public void BT_LevelOrderTraversal_ReturnTrue()
        {
            var root = new TreeNode { Value = 20 };
            var node100 = new TreeNode { Value = 100 };
            var node50 = new TreeNode { Value = 50 };
            var node222 = new TreeNode { Value = 222 };
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

            var actual = _traversalService.LevelOrderTraversal(root);
            Assert.Equal("201003501525035222", actual);
        }

        [Fact]
        public void BT_PreOrderTraversal_ReturnTrue()
        {
            var root = new TreeNode { Value = 20 };
            var node100 = new TreeNode { Value = 100 };
            var node50 = new TreeNode { Value = 50 };
            var node222 = new TreeNode { Value = 222 };
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

            var actual = _traversalService.PreOrderTraversal(root);
            Assert.Equal("201005022215325035", actual);
        }

        [Fact]
        public void BT_InOrderTraversal_ReturnTrue()
        {
            var root = new TreeNode { Value = 20 };
            var node100 = new TreeNode { Value = 100 };
            var node50 = new TreeNode { Value = 50 };
            var node222 = new TreeNode { Value = 222 };
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

            var actual = _traversalService.InOrderTraversal(root);
            Assert.Equal("222501001520250335", actual);
        }

        [Fact]
        public void BT_PostOrderTraversal_ReturnTrue()
        {
            var root = new TreeNode { Value = 20 };
            var node100 = new TreeNode { Value = 100 };
            var node50 = new TreeNode { Value = 50 };
            var node222 = new TreeNode { Value = 222 };
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

            var actual = _traversalService.PostOrderTraversal(root);
            Assert.Equal("222501510025035320", actual);
        }
    }
}