using System;
using System.Collections.Generic;
namespace Trees
{
  public class Program
  {
    public static void Main(string[] args)
    {
      BinaryTree<int> tree = new BinaryTree<int>();
      tree.Root = new Node<int>(10);
      tree.Root.Left = new Node<int>(5);
      tree.Root.Right = new Node<int>(20);
      tree.Root.Left.Left = new Node<int>(3);
      tree.Root.Left.Right = new Node<int>(8);

      int max = tree.FindMaxValue();
      Console.WriteLine("Maximum value in the binary tree: " + max);
    }
  }
}
