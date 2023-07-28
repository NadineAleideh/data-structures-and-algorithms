using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
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

    public bool Contains(T value)
    {
      return Contains(Root!, value);
    }

    private bool Contains(Node<T> node, T value)
    {
      if (node == null)
        return false;

      int compareResult = value.CompareTo(node.Value);

      if (compareResult == 0)
        return true;
      else if (compareResult < 0)
        return Contains(node.Left!, value);
      else
        return Contains(node.Right!, value);
    }
  }

}
