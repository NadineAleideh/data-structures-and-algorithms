using System;
using System.Collections.Generic;
namespace Trees
{
  public class Program
  {
    public static void Main(string[] args)
    {
      //BinaryTree<int> tree = new BinaryTree<int>();

      //tree.Root = new Node<int>(2);
      //tree.Root.Left = new Node<int>(7);
      //tree.Root.Right = new Node<int>(5);
      //tree.Root.Left.Left = new Node<int>(2);
      //tree.Root.Left.Right = new Node<int>(6);
      //tree.Root.Right.Left = new Node<int>(9);
      //tree.Root.Right.Right = new Node<int>(5);

      //CC16
      //int max = tree.FindMaxValue();
      //Console.WriteLine("Maximum value in the binary tree: " + max);

      //CC17
      //BridthFirstClass bridthFirstClass = new BridthFirstClass();
      //List<int> breadthFirstResult = bridthFirstClass.BreadthFirst(tree);
      //Console.WriteLine("Breadth First Traversal: " + string.Join(", ", breadthFirstResult));


      //CC18
      // Create a k-ary tree with some sample values
      FizzBuzzTreeClass fizzBuzzTreeClass = new FizzBuzzTreeClass();
      KaryTree<int> multiLevelTree = new KaryTree<int>();
      multiLevelTree.Root = new TreeNode<int>(10);
      var root = multiLevelTree.Root;
      root.Children.Add(new TreeNode<int>(9));
      root.Children.Add(new TreeNode<int>(12));
      root.Children[0].Children.Add(new TreeNode<int>(15));
      root.Children[0].Children[0].Children.Add(new TreeNode<int>(7));
      root.Children[1].Children.Add(new TreeNode<int>(30));
      root.Children[1].Children[0].Children.Add(new TreeNode<int>(22));

      // Perform FizzBuzz transformation

      KaryTree<string> fizzBuzzTree = fizzBuzzTreeClass.FizzBuzzTree(multiLevelTree);

      //  original tree values
      Console.WriteLine("Original Tree:");
      PrintTreeValues(multiLevelTree.Root);

      //  FizzBuzz tree values
      Console.WriteLine("\nFizzBuzz Tree:");
      PrintTreeValues(fizzBuzzTree.Root);
    }

    static void PrintTreeValues<T>(TreeNode<T> node)
    {
      Console.WriteLine(node.Value);

      foreach (var child in node.Children)
      {
        PrintTreeValues(child);
      }
    }

  }

}
