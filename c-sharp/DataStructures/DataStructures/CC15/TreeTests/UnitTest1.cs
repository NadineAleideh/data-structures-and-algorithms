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
  }
}


