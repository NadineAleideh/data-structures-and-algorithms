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
}
