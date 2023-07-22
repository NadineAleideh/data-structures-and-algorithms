using System;
using CodeChallenges;
using DataStructures;
using Xunit;

namespace CodeChallengesTests
{
  public class UnitTest1
  {
    [Fact]
    public void ZipLists_ReturnsZippedLinkedList()
    {
      LinkedList list1 = new LinkedList();
      list1.Append(1);
      list1.Append(3);

      LinkedList list2 = new LinkedList();
      list2.Append(5);
      list2.Append(9);
      list2.Append(4);

      LinkedList zippedList = LinkedLists.ZipLists(list1, list2);

      Assert.Equal("{ 1 } -> { 5 } -> { 3 } -> { 9 } -> { 4 } -> NULL", zippedList.ToString());
    }

    [Fact]
    public void ZipLists_WhenOneListIsEmpty()
    {
      LinkedList list1 = new LinkedList();
      list1.Append(1);
      list1.Append(3);

      LinkedList list2 = new LinkedList();

      LinkedList zippedList = LinkedLists.ZipLists(list1, list2);

      Assert.Equal("{ 1 } -> { 3 } -> NULL", zippedList.ToString());
    }

    [Fact]
    public void ZipLists_WhenBothListsAreEmpty()
    {
      LinkedList list1 = new LinkedList();
      LinkedList list2 = new LinkedList();

      LinkedList zippedList = LinkedLists.ZipLists(list1, list2);

      Assert.Equal("NULL", zippedList.ToString());
    }

  }
}
