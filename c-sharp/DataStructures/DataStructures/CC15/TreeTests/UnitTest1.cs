using Trees;

namespace TreeTests
{
  public class UnitTest1
  {

    [Fact]
    public void Test_InstantiateEmptyTree() //Can successfully instantiate an empty tree
    {
      BinarySearchTree<int> tree = new BinarySearchTree<int>();
      Assert.Null(tree.Root);
    }

    [Fact]
    public void Test_InstantiateTreeWithSingleRootNode() //Can successfully instantiate a tree with a single root node
    {
      BinarySearchTree<int> tree = new BinarySearchTree<int>();
      tree.Add(5);
      Assert.Equal(5, tree.Root.Value);
    }

    [Fact]
    public void Test_AddToLeftAndRightChildren() //can successfully add a left child and right child properly to a node
    {
      BinarySearchTree<int> tree = new BinarySearchTree<int>();
      tree.Add(5);
      tree.Add(3);
      tree.Add(7);

      Assert.Equal(3, tree.Root.Left.Value);
      Assert.Equal(7, tree.Root.Right.Value);
    }

    [Fact]
    public void Test_PreOrderTraversal() //Can successfully return a collection from a pre-order traversal
    {
      BinarySearchTree<int> tree = new BinarySearchTree<int>();
      tree.Add(5);
      tree.Add(3);
      tree.Add(7);
      tree.Add(2);
      tree.Add(4);
      tree.Add(6);
      tree.Add(8);

      List<int> expected = new List<int> { 5, 3, 2, 4, 7, 6, 8 };
      Assert.Equal(expected, tree.PreOrderTraversal());
    }

    [Fact]
    public void Test_InOrderTraversal()//Can successfully return a collection from an in-order traversal
    {
      BinarySearchTree<int> tree = new BinarySearchTree<int>();
      tree.Add(5);
      tree.Add(3);
      tree.Add(7);
      tree.Add(2);
      tree.Add(4);
      tree.Add(6);
      tree.Add(8);

      List<int> expected = new List<int> { 2, 3, 4, 5, 6, 7, 8 };
      Assert.Equal(expected, tree.InOrderTraversal());
    }

    [Fact]
    public void Test_PostOrderTraversal() //Can successfully return a collection from a post-order traversal
    {
      BinarySearchTree<int> tree = new BinarySearchTree<int>();
      tree.Add(5);
      tree.Add(3);
      tree.Add(7);
      tree.Add(2);
      tree.Add(4);
      tree.Add(6);
      tree.Add(8);

      List<int> expected = new List<int> { 2, 4, 3, 6, 8, 7, 5 };
      Assert.Equal(expected, tree.PostOrderTraversal());
    }

    //Returns true	false for the contains method, given an existing or non-existing node value
    [Fact]
    public void Test_ContainsExistingNodeValue()
    {
      BinarySearchTree<int> tree = new BinarySearchTree<int>();
      tree.Add(5);
      tree.Add(3);
      tree.Add(7);

      Assert.True(tree.Contains(3));
    }

    [Fact]
    public void Test_ContainsNonExistingNodeValue()
    {
      BinarySearchTree<int> tree = new BinarySearchTree<int>();
      tree.Add(5);
      tree.Add(3);
      tree.Add(7);

      Assert.False(tree.Contains(6));
    }

    ////////// CC16

    [Fact]
    public void Test_EmptyTree()
    {
      BinarySearchTree<int> tree = new BinarySearchTree<int>();

      // Assert that trying to find the max value in an empty tree throws an exception
      Assert.Throws<InvalidOperationException>(() => tree.FindMaxValue());
    }

    [Fact]
    public void Test_SingleNodeTree()
    {
      BinarySearchTree<int> tree = new BinarySearchTree<int>();
      tree.Add(5);

      // The tree only has one node with value 5, which should be the maximum value
      int max = tree.FindMaxValue();
      Assert.Equal(5, max);
    }

    [Fact]
    public void Test_LeftSkewedTree()
    {
      BinarySearchTree<int> tree = new BinarySearchTree<int>();
      tree.Add(8);
      tree.Add(7);
      tree.Add(6);
      tree.Add(5);
      tree.Add(4);

      // The left-skewed tree has the maximum value 8 at the root
      int max = tree.FindMaxValue();
      Assert.Equal(8, max);
    }

    [Fact]
    public void Test_RightSkewedTree()
    {
      BinarySearchTree<int> tree = new BinarySearchTree<int>();
      tree.Add(1);
      tree.Add(2);
      tree.Add(3);
      tree.Add(4);
      tree.Add(5);

      // The right-skewed tree has the maximum value 5 at the rightmost node
      int max = tree.FindMaxValue();
      Assert.Equal(5, max);
    }

    [Fact]
    public void Test_BalancedTree()
    {
      BinarySearchTree<int> tree = new BinarySearchTree<int>();
      tree.Add(4);
      tree.Add(2);
      tree.Add(6);
      tree.Add(1);
      tree.Add(3);
      tree.Add(5);
      tree.Add(7);

      // The balanced tree has the maximum value 7 at the rightmost node
      int max = tree.FindMaxValue();
      Assert.Equal(7, max);
    }

    [Fact]
    public void Test_CustomTree()
    {
      BinarySearchTree<int> tree = new BinarySearchTree<int>();
      tree.Add(7);
      tree.Add(3);
      tree.Add(9);
      tree.Add(1);
      tree.Add(5);
      tree.Add(8);
      tree.Add(10);
      tree.Add(2);
      tree.Add(11);

      // The custom tree has the maximum value 11 at the rightmost node
      int max = tree.FindMaxValue();
      Assert.Equal(11, max);
    }
  }
}


