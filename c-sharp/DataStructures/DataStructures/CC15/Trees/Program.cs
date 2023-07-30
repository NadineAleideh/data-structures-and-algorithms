using System;
using System.Collections.Generic;
namespace Trees
{
  public class Program
  {
    public static void Main(string[] args)
    {

      BinarySearchTree<int> tree = new BinarySearchTree<int>();
      tree.Add(5);
      tree.Add(3);
      tree.Add(7);
      tree.Add(8);
      tree.Add(4);
      int max = tree.FindMaxValue();
      Console.WriteLine("Maximum number in the binary tree: " + max);
    }
  }
}
