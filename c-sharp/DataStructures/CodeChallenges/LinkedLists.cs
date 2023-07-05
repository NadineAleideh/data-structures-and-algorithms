using System;
using DataStructures;

namespace CodeChallenges
{
  public class LinkedLists
  {
    //CC8//
    public static LinkedList ZipLists(LinkedList list1, LinkedList list2)
    {
      if (list1.Head == null)
      {
        return list2;
      }
      else if (list2.Head == null)
      {
        return list1;
      }

      Node current1 = list1.Head;
      Node current2 = list2.Head;
      Node next1, next2;

      while (current1 != null && current2 != null)
      {
        next1 = current1.Next;
        next2 = current2.Next;

        current2.Next = next1;
        current1.Next = current2;

        current1 = next1;
        current2 = next2;
      }

      if (current2 != null)
      {
        current1 = list1.Head;
        while (current1.Next != null)
        {
          current1 = current1.Next;
        }
        current1.Next = current2;
      }

      return list1;
    }

  }
}
