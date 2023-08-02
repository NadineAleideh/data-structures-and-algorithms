

namespace Trees
{
  public class BridthFirstClass
  {
    public List<T> BreadthFirst<T>(BinaryTree<T> tree)
    {
      List<T> result = new List<T>();

      if (tree.Root == null)
      {
        throw new InvalidOperationException("Tree is empty!");
      }

      Queue<Node<T>> breadthQueue = new Queue<Node<T>>();
      breadthQueue.Enqueue(tree.Root);

      while (breadthQueue.Count > 0)
      {
        Node<T> front = breadthQueue.Dequeue();
        result.Add(front.Value);

        if (front.Left != null)
        {
          breadthQueue.Enqueue(front.Left);
        }

        if (front.Right != null)
        {
          breadthQueue.Enqueue(front.Right);
        }
      }

      return result;
    }
  }
}
