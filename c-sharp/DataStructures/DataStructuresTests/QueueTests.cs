using System;
using Xunit;
using DataStructures;

namespace DataStructuresTests
{
  public class QueueTests
  {
    [Fact]
    public void TestEnqueue() // 8. Can successfully enqueue into a queue
    {
      Queue queue = new Queue();

      queue.Enqueue(1);

      Assert.False(queue.IsQueueEmpty());
      Assert.Equal(1, queue.Peek());
    }

    [Fact]
    public void TestEnqueueMultipleValues() // 9. Can successfully enqueue multiple values into a queue
    {
      Queue queue = new Queue();

      queue.Enqueue(1);
      queue.Enqueue(2);
      queue.Enqueue(3);

      Assert.False(queue.IsQueueEmpty());
      Assert.Equal(1, queue.Peek());
    }

    [Fact]
    public void TestDequeue() // 10. Can successfully dequeue out of a queue the expected value
    {
      Queue queue = new Queue();

      queue.Enqueue(1);
      queue.Enqueue(2);
      queue.Enqueue(3);

      int dequeuedValue = queue.Dequeue();

      Assert.Equal(1, dequeuedValue);
      Assert.Equal(2, queue.Peek());
    }

    [Fact]
    public void TestPeek() // 11. Can successfully peek into a queue, seeing the expected value
    {
      Queue queue = new Queue();

      queue.Enqueue(1);
      queue.Enqueue(2);
      queue.Enqueue(3);

      Assert.Equal(1, queue.Peek());
    }

    [Fact]
    public void TestEmptyQueueAfterMultipleDequeues() // 12. Can successfully empty a queue after multiple dequeues
    {
      Queue queue = new Queue();

      queue.Enqueue(1);
      queue.Enqueue(2);
      queue.Enqueue(3);
      queue.Dequeue();
      queue.Dequeue();
      queue.Dequeue();

      Assert.True(queue.IsQueueEmpty());
    }

    [Fact]
    public void TestInstantiateEmptyQueue() // 13. Can successfully instantiate an empty queue
    {
      Queue queue = new Queue();

      bool v = queue.IsQueueEmpty();
      Assert.True(v);
    }

    [Fact]
    public void TestEmptyPeekQueue() // 14. Calling dequeue or peek on empty queue raises exception
    {
      Queue queue = new Queue();

      Assert.Throws<InvalidOperationException>(() => queue.Peek());
    }

    [Fact]
    public void TestEmptyPeekeDqueue() // 14. Calling dequeue or peek on empty queue raises exception
    {
      Queue queue = new Queue();

      Assert.Throws<InvalidOperationException>(() => queue.Dequeue());
    }
  }
}
