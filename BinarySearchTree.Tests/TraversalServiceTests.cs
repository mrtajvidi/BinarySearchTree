using BinarySearchTree.Logic.Models;
using BinarySearchTree.Logic.Processors;
using System.Collections.Generic;
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

            var actual = _traversalService.LevelOrderTraversal(root);
            Assert.Equal("201003501525035222", actual);
        }

        [Fact]
        public void BT_ZigzagLevelOrderTraversal_ReturnTrue()
        {
            var root = new TreeNode { val = 3 };
            var node9 = new TreeNode { val = 9 };
            var node20 = new TreeNode { val = 20 };
            var node15 = new TreeNode { val = 15 };
            var node7 = new TreeNode { val = 7 };;

            root.left = node9;
            root.right = node20;

            node20.left = node15;
            node20.right = node7;

            var actual = _traversalService.ZigzagLevelOrder(root);
            var expected = new List<List<int>>(){ new List<int>(){ 3 }, new List<int>() { 20, 9 }, new List<int>() { 15, 7 } };

            Assert.Equal(expected.Count, actual.Count);
        }

        [Fact]
        public void BT_ZigzagLevelOrderTraversal_ReturnTrue2()
        {
            var root = new TreeNode { val = 1 };
            var node2 = new TreeNode { val = 2 };
            var node3 = new TreeNode { val = 3 };
            var node4 = new TreeNode { val = 4 };
            var node5 = new TreeNode { val = 5 }; ;

            root.left = node2;
            root.right = node3;

            node2.left = node4;
            node3.right = node5;

            var actual = _traversalService.ZigzagLevelOrder(root);
            var expected = new List<List<int>>() { new List<int>() { 3 }, new List<int>() { 20, 9 }, new List<int>() { 15, 7 } };

            Assert.Equal(expected.Count, actual.Count);
        }


        [Fact]
        public void BT_PreOrderTraversal_ReturnTrue()
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

            var actual = _traversalService.PreOrderTraversal(root);
            Assert.Equal("201005022215325035", actual);
        }

        [Fact]
        public void BT_InOrderTraversal_ReturnTrue()
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

            var actual = _traversalService.InOrderTraversal(root);
            Assert.Equal("222501001520250335", actual);
        }

        [Fact]
        public void BT_PostOrderTraversal_ReturnTrue()
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

            var actual = _traversalService.PostOrderTraversal(root);
            Assert.Equal("222501510025035320", actual);
        }

        [Fact]
        public void BT_InorderSuccessor_Success()
        {
            var root = new TreeNode { val = 5 };
            var node3 = new TreeNode { val = 3 };
            var node2 = new TreeNode { val = 2 };
            var node1 = new TreeNode { val = 1 };
            var node4 = new TreeNode { val = 4 };
            var node6 = new TreeNode { val = 6 };

            root.left = node3;
            root.right = node6;

            node3.left = node2;
            node3.right = node4;

            node2.left = node1;

            var p = new TreeNode { val = 4 };

            var actual = _traversalService.InorderSuccessorBst(root, p);
            Assert.Equal(root.val, actual.val);
        }

        [Fact]
        public void SuccessorBst_ReturnTrue()
        {
            var root = new TreeNode { val = 4 };
            var node2 = new TreeNode { val = 2 };
            var node1 = new TreeNode { val = 1 };
            var node7 = new TreeNode { val = 7 };
            var node3 = new TreeNode { val = 3 };
            var node5 = new TreeNode { val = 5 };

            root.left = node2;
            root.right = node7;

            node2.left = node1;
            node2.right = node3;

            node7.left = node5;

            var result = _traversalService.SuccessorBst(root);
            Assert.Equal(5, result.val);
        }
    }
}