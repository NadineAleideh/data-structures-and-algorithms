using System;
using Xunit;

using DataStructures;

namespace DataStructuresTests
{
  public class LinkedListTests
  {
    [Fact]
    public void Linked_List_Created_With_A_Value_Has_A_Head() //Can successfully instantiate an empty linked list
    {
      LinkedList linkedList = new LinkedList();
      Assert.Null(linkedList.Head);
    }

    [Fact]
    public void LinkedList_InsertFirstOnce() //Can properly insert into the linked list
    {
      LinkedList linkedList = new LinkedList();
      linkedList.InsertFirst(1);

      Assert.NotNull(linkedList.Head);
      Assert.Equal(1, linkedList.Head.Value);
    }

    [Fact]
    public void LinkedList_InsertFirstMultiple() //Can properly insert multiple nodes into the linked list
    {
      LinkedList linkedList = new LinkedList();

      linkedList.InsertFirst(2);
      linkedList.InsertFirst(3);
      linkedList.InsertFirst(4);

      Assert.NotNull(linkedList.Head);
      Assert.Equal(4, linkedList.Head.Value);
      Assert.NotNull(linkedList.Head.Next);
      Assert.Equal(3, linkedList.Head.Next.Value);
      Assert.NotNull(linkedList.Head.Next.Next);
      Assert.Equal(2, linkedList.Head.Next.Next.Value);
    }


    [Theory]
    [InlineData(1, true)] //Will return true when finding a value within the linked list that exists
    [InlineData(2, true)]//Will return true when finding a value within the linked list that exists
    [InlineData(3, true)]//Will return true when finding a value within the linked list that exists
    [InlineData(4, true)]//Will return true when finding a value within the linked list that exists
    [InlineData(5, false)]//Will return false when searching for a value in the linked list that does not exist
    [InlineData(6, false)]//Will return false when searching for a value in the linked list that does not exist
    public void LinkedList_IncludesValue(int value, bool expected)
    {
      LinkedList linkedList = new LinkedList();
      linkedList.InsertFirst(1);
      linkedList.InsertFirst(2);
      linkedList.InsertFirst(3);
      linkedList.InsertFirst(4);

      bool result = linkedList.IsIncludes(value);

      Assert.Equal(expected, result);
    }

    [Fact]
    public void LinkedList_ToString() //Can properly return a collection of all the values that exist in the linked list
    {
      LinkedList linkedList = new LinkedList();
      linkedList.InsertFirst(4);
      linkedList.InsertFirst(3);
      linkedList.InsertFirst(2);
      linkedList.InsertFirst(1);

      string expected = "{ 1 } -> { 2 } -> { 3 } -> { 4 } -> NULL";
      string result = linkedList.ToString();

      Assert.Equal(expected, result);
    }

  }
}
