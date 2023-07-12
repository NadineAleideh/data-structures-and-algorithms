using System;

namespace DataStructures
{
  public class Queue
  {
    public Node Front { get; set; }
    public Node Back { get; set; }
    public Queue()
    {
      Front = null;
      Back = null;
    }

    public bool IsQueueEmpty()
    {
      return Front == null && Back == null;
    }

    public void Enqueue (int value)
    {
      Node NewNode = new Node(value);

      if (IsQueueEmpty())
      {
        Front = NewNode;
        Back = NewNode;
      }
      Back.Next = NewNode;
      Back = NewNode;
    }

    public int Dequeue()
    {
      if (IsQueueEmpty())
      {
        throw new InvalidOperationException("Queue is empty!");
      }

      int value = Front.Value;
      Front = Front.Next;

      if (Front == null) //if there was just 1 element and I Dequeued it the Queue will be empty
      {
        Back = null;
      }

      return value;
    }

    public int Peek ()
    {
      if (IsQueueEmpty())
      {
        throw new InvalidOperationException("Queue is empty!");
      }
      return Front.Value;
    }
  }
}
