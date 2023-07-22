using System;



namespace DataStructures
{
  public class PseudoQueue
  {
    public Stack stack1;
    public Stack stack2;

    public PseudoQueue()
    {
      stack1 = new Stack();
      stack2 = new Stack();
    }

    public void Enqueue(int value)
    {
      while (!stack1.IsStackEmpty())
      {
        stack2.Push(stack1.Pop());
      }
      stack1.Push(value);

      while (!stack2.IsStackEmpty())
      {
        stack1.Push(stack2.Pop());
      }
    }

    public int Dequeue()
    {
      if (stack1.IsStackEmpty())
      {
        throw new InvalidOperationException("PseudoQueue is empty");
      }

      return stack1.Pop();
    }
  }
}
