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

    // code challenge 6 tests starts //

    [Fact]
    public void LinkedList_Append() //Can successfully add a node to the end of the linked list
    {
      // Arrange
      LinkedList linkedList = new LinkedList();

      // Act
      linkedList.Append(5);
      // Assert
      string expected = "{ 5 } -> NULL";
      string result = linkedList.ToString();

      Assert.Equal(expected, result);
    }

    [Fact]
    public void LinkedList_AppendMultiple() //Can successfully add multiple nodes to the end of a linked list
    {
      LinkedList linkedList = new LinkedList();

      linkedList.Append(5);
      linkedList.Append(6);
      linkedList.Append(7);

      Assert.NotNull(linkedList.Head);
      Assert.Equal(5, linkedList.Head.Value);
      Assert.NotNull(linkedList.Head.Next);
      Assert.Equal(6, linkedList.Head.Next.Value);
      Assert.NotNull(linkedList.Head.Next.Next);
      Assert.Equal(7, linkedList.Head.Next.Next.Value);
    }

    [Fact]
    public void LinkedList_InsertBeforeMiddle() //Can successfully insert a node before a node located in the middle of a linked list
    {
      // Arrange
      LinkedList linkedList = new LinkedList();
      linkedList.Append(1);
      linkedList.Append(2);
      linkedList.Append(4);
      linkedList.Append(5);

      // Act
      linkedList.InsertBefore(4, 3);

      // Assert
      string expected = "{ 1 } -> { 2 } -> { 3 } -> { 4 } -> { 5 } -> NULL";
      string result = linkedList.ToString();

      Assert.Equal(expected, result);
    }

    [Fact]
    public void LinkedList_InsertBeforeFirst() //Can successfully insert a node before the first node of a linked list
    {
      // Arrange
      LinkedList linkedList = new LinkedList();
      linkedList.Append(1);
      linkedList.Append(2);
      linkedList.Append(3);
      linkedList.Append(4);
      linkedList.Append(5);

      // Act
      linkedList.InsertBefore(1, 0);

      // Assert
      string expected = "{ 0 } -> { 1 } -> { 2 } -> { 3 } -> { 4 } -> { 5 } -> NULL";
      string result = linkedList.ToString();

      Assert.Equal(expected, result);
    }

    [Fact]
    public void LinkedList_InsertAfterMiddle() //Can successfully insert after a node in the middle of the linked list
    {
      // Arrange
      LinkedList linkedList = new LinkedList();
      linkedList.Append(1);
      linkedList.Append(2);
      linkedList.Append(3);
      linkedList.Append(5);

      // Act
      linkedList.InsertAfter(3, 4);

      // Assert
      string expected = "{ 1 } -> { 2 } -> { 3 } -> { 4 } -> { 5 } -> NULL";
      string result = linkedList.ToString();

      Assert.Equal(expected, result);
    }

    [Fact]
    public void LinkedList_InsertAfterLast() //Can successfully insert a node after the last node of the linked list
    {
      // Arrange
      LinkedList linkedList = new LinkedList();
      linkedList.Append(1);
      linkedList.Append(2);
      linkedList.Append(3);
      linkedList.Append(4);

      // Act
      linkedList.InsertAfter(4, 5);

      // Assert
      string expected = "{ 1 } -> { 2 } -> { 3 } -> { 4 } -> { 5 } -> NULL";
      string result = linkedList.ToString();

      Assert.Equal(expected, result);
    }

    [Fact]
    public void LinkedList_Delete() // test delete
    {
      // Arrange
      LinkedList linkedList = new LinkedList();
      linkedList.Append(1);
      linkedList.Append(3);
      linkedList.Append(2);
      linkedList.Append(5);

      // Act
      linkedList.Delete(3);

      // Assert
      Assert.NotNull(linkedList.Head);
      Assert.Equal(1, linkedList.Head.Value);
      Assert.NotNull(linkedList.Head.Next);
      Assert.Equal(2, linkedList.Head.Next.Value);
      Assert.NotNull(linkedList.Head.Next.Next);
      Assert.Equal(5, linkedList.Head.Next.Next.Value);
      Assert.Null(linkedList.Head.Next.Next.Next);
    }

    ///////////////////////////////////////////////////////////////////////////CC7 Tests/////////////////////////////////////////////////////////////////////////

    [Fact]
    public void KthValueFromEnd_WhenKExceedsLength() //Where k is greater than the length of the linked list
    {
      LinkedList linkedList = new LinkedList();
      linkedList.Append(1);
      linkedList.Append(3);
      linkedList.Append(8);
      linkedList.Append(2);

      Assert.Throws<ArgumentException>(() => linkedList.KthValueFromEnd(6));
    }

    [Fact]
    public void KthValueFromEnd_WhenKEqulasLinkedListSize() //Where k and the length of the list are the same
    {
      LinkedList linkedList = new LinkedList();
      linkedList.Append(1);
      linkedList.Append(3);
      linkedList.Append(8);
      linkedList.Append(2);

      Assert.Throws<ArgumentException>(() => linkedList.KthValueFromEnd(4));
    }

    [Fact]
    public void KthValueFromEnd_WhenKIsNegative() //Where k is not a positive integer
    {
      LinkedList linkedList = new LinkedList();
      linkedList.Append(1);
      linkedList.Append(3);
      linkedList.Append(8);
      linkedList.Append(2);

      Assert.Throws<ArgumentException>(() => linkedList.KthValueFromEnd(-1));
    }

    [Fact]
    public void KthValueFromEnd_WhenLinkedListSizeIs1() //Where the linked list is of a size 1
    {
      LinkedList linkedList = new LinkedList();
      linkedList.Append(5);

      Assert.Equal(5, linkedList.KthValueFromEnd(0));
    }

    [Fact]
    public void KthValueFromEnd() //“Happy Path” where k is not at the end, but somewhere in the middle of the linked list
    {
      LinkedList linkedList = new LinkedList();
      linkedList.Append(1);
      linkedList.Append(3);
      linkedList.Append(8);
      linkedList.Append(2);

      Assert.Equal(2, linkedList.KthValueFromEnd(0));
      Assert.Equal(3, linkedList.KthValueFromEnd(2));
    }


  }
}
