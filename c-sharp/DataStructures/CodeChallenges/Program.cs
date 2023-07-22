using DataStructures;
using System;

namespace CodeChallenges
{
  class Program
  {
    //CC8
    static void Main(string[] args)
    {
      LinkedList list1 = new LinkedList();
      list1.Append(1);
      list1.Append(3);

      LinkedList list2 = new LinkedList();
      list2.Append(5);
      list2.Append(9);
      list2.Append(4);

      LinkedList zippedList = LinkedLists.ZipLists(list1, list2);
      Console.WriteLine(zippedList.ToString());
    }
  }
}
