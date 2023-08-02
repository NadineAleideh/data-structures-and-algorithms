# CC16 Find Maximum Value Binary Tree

This challenge requier implementing the FindMaxValue method for a Binary Tree data structure. The method should find and return the maximum value stored in the binary tree.

- Inputs : None.
- Outputs: The maximum value found in the binary tree(integer).

## Approach & Efficiency

1. By using the Pre-Order traversal of the binary tree we can visit every node in the binary tree, and by comparing the values during traversal, we can accurately identify the maximum value.
2.  Initialize a variable maxValue with a very small value (negative infinity).
3. Call the FindMaxValue function, passing the root node of the binary tree.
4. In the FindMaxValue function:
   - If the input node is null, return maxValue. This handles the base case.
   - Compare the value of the current node with the maxValue. If the current node's value is greater than maxValue, update maxValue with the 
     current node's value.
   - Recursively call FindMaxValue on the left child of the current node.
   - Recursively call FindMaxValue on the right child of the current node.
5. After the FindMaxValue function returns, the maxValue variable will hold the maximum value in the binary tree.

- Time Complexity: O(n), where n is the number of nodes in the binary tree, as we visit each node once.
- Space Complexity: O(h), due to the recursive nature of the traversal, where h is the height of the binary tree.



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
      T maxValue = node.Value;

      if (node.Left != null)
      {
        T leftMax = FindMaxValue(node.Left);
        if (Comparer<T>.Default.Compare(leftMax, maxValue) > 0)
        {
          maxValue = leftMax;
        }
      }

      if (node.Right != null)
      {
        T rightMax = FindMaxValue(node.Right);
        if (Comparer<T>.Default.Compare(rightMax, maxValue) > 0)
        {
          maxValue = rightMax;
        }
      }

      return maxValue;
    }
  }

```

## How to use
To use the Binary Search Tree, follow these steps:

1. Instantiate a new instance of the BinarySearchTree class: `BinaryTree<int> tree = new BinaryTree<int>();`
2. Add nodes
3. Then call the FindMaxValue method to find the maximum value.

Example:

```
BinaryTree<int> tree = new BinaryTree<int>();
tree.Root = new Node<int>(10);
tree.Root.Left = new Node<int>(5);
tree.Root.Right = new Node<int>(20);
tree.Root.Left.Left = new Node<int>(3);
tree.Root.Left.Right = new Node<int>(8);

int max = tree.FindMaxValue();
Console.WriteLine("Maximum value in the binary tree: " + max);
```

## Tests

Go to [UnitTest1.cs](../TreeTests/UnitTest1.cs) to check the tests.

![tests](./assets/CC16tests.PNG)
