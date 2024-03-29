using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
  public class BinaryTree<T>
  {
    public Node<T>? Root { get; set; }

    public BinaryTree()
    {
      Root = null;
    }

    //CC15
    // DFT PreOrder
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


    // DFT InOrder
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

    // DFT PostOrder
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


    //CC16
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

}

