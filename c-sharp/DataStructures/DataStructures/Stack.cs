using System;


namespace DataStructures
{
  public class Stack
  {
    public Node Top { get; set; }
    public Stack()
    {
      Top = null;
    }

    public bool IsStackEmpty()
    {
      return Top == null;
    }

    public void Push(int value)
    {
      Node NewNode = new Node(value);

      if (Top == null)
      {
        Top = NewNode;
      }
      else
      {

        NewNode.Next = Top;
        Top = NewNode;
      }
    }
    public int Pop()
    {
      if (IsStackEmpty())
      {
        throw new InvalidOperationException("Stack is empty!");
      }

      int value;
      value = Top.Value;
      Top = Top.Next;

      return value;
    }

    public int Peek()
    {
      if (IsStackEmpty())
      {
        throw new InvalidOperationException("Stack is empty!");
      }
      return Top.Value;
    }

  }

}
