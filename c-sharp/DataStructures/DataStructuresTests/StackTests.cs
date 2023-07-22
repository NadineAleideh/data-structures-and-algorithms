using Xunit;
using DataStructures;
using System;

namespace DataStructuresTests
{
  public class StackTests
  {
    [Fact]
    public void TestPush() // 1. Can successfully push onto a stack
    {
      Stack stack = new Stack();

      stack.Push(1);

      Assert.False(stack.IsStackEmpty());
      Assert.Equal(1, stack.Peek());
    }

    [Fact]
    public void TestPushMultipleValues() // 2. Can successfully push multiple values onto a stack
    {
      Stack stack = new Stack();

      stack.Push(1);
      stack.Push(2);
      stack.Push(3);

      Assert.False(stack.IsStackEmpty());
      Assert.Equal(3, stack.Peek());
    }

    [Fact]
    public void TestPop() // 3. Can successfully pop off the stack
    {
      Stack stack = new Stack();

      stack.Push(1);
      stack.Push(2);
      stack.Push(3);

      int poppedValue = stack.Pop();

      Assert.Equal(3, poppedValue);
      Assert.Equal(2, stack.Peek());
    }

    [Fact]
    public void TestEmptyStackAfterMultiplePops() // 4. Can successfully empty a stack after multiple pops
    {
      Stack stack = new Stack();

      stack.Push(1);
      stack.Push(2);
      stack.Push(3);
      stack.Pop();
      stack.Pop();
      stack.Pop();

      Assert.True(stack.IsStackEmpty());
    }

    [Fact]
    public void TestPeek() // 5. Can successfully peek the next item on the stack
    {
      Stack stack = new Stack();

      stack.Push(1);
      stack.Push(2);
      stack.Push(3);

      Assert.Equal(3, stack.Peek());
    }

    [Fact]
    public void TestInstantiateEmptyStack() // 6. Can successfully instantiate an empty stack
    {
      Stack stack = new Stack();

      bool v = stack.IsStackEmpty();
      Assert.True(v);
    }


    [Fact]
    public void TestPeekEmptyStack() // 7. Calling pop or peek on empty stack raises exception
    {
      Stack stack = new Stack();

      Assert.Throws<InvalidOperationException>(() => stack.Peek());
    }


    [Fact]
    public void TestPopEmptyStack() // 7. Calling pop or peek on empty stack raises exception
    {
      Stack stack = new Stack();

      Assert.Throws<InvalidOperationException>(() => stack.Pop());
    }
  }
}
