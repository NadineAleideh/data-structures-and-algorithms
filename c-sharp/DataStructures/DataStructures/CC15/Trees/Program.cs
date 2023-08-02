using System;
using System.Collections.Generic;
namespace Trees
{
  public class Program
  {
    public static void Main(string[] args)
    {
      BinaryTree<int> tree = new BinaryTree<int>();

      tree.Root = new Node<int>(2);
      tree.Root.Left = new Node<int>(7);
      tree.Root.Right = new Node<int>(5);
      tree.Root.Left.Left = new Node<int>(2);
      tree.Root.Left.Right = new Node<int>(6);
      tree.Root.Right.Left = new Node<int>(9);
      tree.Root.Right.Right = new Node<int>(5);

      //int max = tree.FindMaxValue();
      //Console.WriteLine("Maximum value in the binary tree: " + max);

      BridthFirstClass bridthFirstClass = new BridthFirstClass();
      List<int> breadthFirstResult = bridthFirstClass.BreadthFirst(tree);
      Console.WriteLine("Breadth First Traversal: " + string.Join(", ", breadthFirstResult));

    }
  }
}
