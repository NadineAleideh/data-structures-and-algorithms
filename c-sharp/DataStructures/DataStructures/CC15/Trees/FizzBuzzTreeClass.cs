using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
  public class FizzBuzzTreeClass
  {
    public KaryTree<string> FizzBuzzTree(KaryTree<int> tree)
    {
      if (tree.Root == null)
      {
        throw new InvalidOperationException("Tree is empty!");
      }

      KaryTree<string> resultTree = new KaryTree<string>();
      resultTree.Root = new TreeNode<string>(FizzBuzzValue(tree.Root.Value));

      FizzBuzzTree(tree.Root, resultTree.Root);

      return resultTree;
    }

    public static void FizzBuzzTree(TreeNode<int> sourceNode, TreeNode<string> destinationNode)
    {
      foreach (var childNode in sourceNode.Children)
      {
        TreeNode<string> newChild = new TreeNode<string>(FizzBuzzValue(childNode.Value));
        destinationNode.Children.Add(newChild);

        FizzBuzzTree(childNode, newChild);
      }
    }

    public static string FizzBuzzValue(int value)
    {
      if (value % 3 == 0 && value % 5 == 0)
      {
        return "FizzBuzz";
      }
      else if (value % 3 == 0)
      {
        return "Fizz";
      }
      else if (value % 5 == 0)
      {
        return "Buzz";
      }
      else
      {
        return value.ToString();
      }
    }
  }
}
