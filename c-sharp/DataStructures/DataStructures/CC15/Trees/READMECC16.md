# CC16 Binary Search Tree: Find Maximum Value

This challenge requier implementing the FindMaxValue method for a Binary Search Tree (BST) data structure. The method should find and return the maximum value stored in the binary search tree.

- Inputs : None.
- Outputs: The maximum value found in the binary search tree(integer).

## Approach & Efficiency

- By using the In-Order traversal of the binary search tree and keep traversing to the right until we reach the rightmost node, which holds the maximum value.
- Start with the root node as the current node.
- While the current node has a right child, update the current node to be its right child (i.e., traverse to the right).
- When the current node does not have a right child, return its value as the maximum value.

Time Complexity: O(n) (where n is the number of nodes in the tree)
Space Complexity:  O(h) due to the recursive nature of the function.


## Whiteboard Process
![Whiteboard](./assets/CC16WB.jpg)

## Solution

```
public class Node<T>
  {
    public T Value { get; set; }

    public Node<T>? Left { get; set; }

    public Node<T>? Right { get; set; }

    public Node(T value)
    {
      Value = value;
      Left = null;
      Right = null;
    }
  }

```

```
public class BinaryTree<T>
  {
    public Node<T>? Root { get; set; }

    public BinaryTree()
    {
      Root = null;
    }

    public List<T> PreOrderTraversal()
    {
      List<T> result = new List<T>();
      PreOrderTraversal(Root!, result);
      return result;
    }

    private void PreOrderTraversal(Node<T> node, List<T> result)
    {
      if (node != null)
      {
        result.Add(node.Value);
        PreOrderTraversal(node.Left!, result);
        PreOrderTraversal(node.Right!, result);
      }
    }

    public List<T> InOrderTraversal()
    {
      List<T> result = new List<T>();
      InOrderTraversal(Root!, result);
      return result;
    }

    private void InOrderTraversal(Node<T> node, List<T> result)
    {
      if (node != null)
      {
        InOrderTraversal(node.Left!, result);
        result.Add(node.Value);
        InOrderTraversal(node.Right!, result);
      }
    }

    public List<T> PostOrderTraversal()
    {
      List<T> result = new List<T>();
      PostOrderTraversal(Root!, result);
      return result;
    }

    private void PostOrderTraversal(Node<T> node, List<T> result)
    {
      if (node != null)
      {
        PostOrderTraversal(node.Left!, result);
        PostOrderTraversal(node.Right!, result);
        result.Add(node.Value);
      }
    }

  }

```

```
public class BinarySearchTree<T> : BinaryTree<T> where T : IComparable<T>
  {
    public void Add(T value)
    {
      Root = Add(Root!, value);
    }

    private Node<T> Add(Node<T> node, T value)
    {
      if (node == null)
        return new Node<T>(value);

      int compareResult = value.CompareTo(node.Value);

      if (compareResult < 0)
      {
        node.Left = Add(node.Left!, value);
      }
      else if (compareResult > 0)
      {
        node.Right = Add(node.Right!, value);
      }

      return node;
    }

    public T FindMaxValue()
    {
      if (Root == null)
      {
        throw new InvalidOperationException("Tree is empty!");
      }
      return FindMaxValue(Root);
    }

    private T FindMaxValue(Node<T> node)
    {

      while (node.Right != null)
      {
        return FindMaxValue(node.Right);
      }

      return node.Value;
    }
  }

```

## How to use
To use the Binary Search Tree, follow these steps:

1. Instantiate a new instance of the BinarySearchTree class: `BinarySearchTree<int> tree = new BinarySearchTree<int>();`
2. Add nodes using the Add method
3. Then call the FindMaxValue method to find the maximum value.

Example:

```
BinarySearchTree<int> tree = new BinarySearchTree<int>();
tree.Add(5);
tree.Add(3);
tree.Add(7);
tree.Add(8);
tree.Add(4);
int max = tree.FindMaxValue();
Console.WriteLine("Maximum number in the binary search tree: " + max);
```

## Tests

Go to [UnitTest1.cs](../TreeTests/UnitTest1.cs) to check the tests.

![tests](./assets/CC16tests.PNG)
