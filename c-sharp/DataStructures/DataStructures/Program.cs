using System;
namespace DataStructures
{
  public class Program
  {
    public static void Main(string[] args) 
    {
      // Create a new linked list
      LinkedList linkedList = new LinkedList();

      // Insert nodes
      linkedList.InsertFirst(4);
      linkedList.InsertFirst(3);
      linkedList.InsertFirst(2);
      linkedList.InsertFirst(1);

      // Generate string representation
      string listString = linkedList.ToString();
      Console.WriteLine($"LinkedList: {listString}");

      // Search for a value
      bool containsValue2 = linkedList.IsIncludes(2);
      bool containsValue10 = linkedList.IsIncludes(10);
      Console.WriteLine($"Contains value 2: {containsValue2}");
      Console.WriteLine($"Contains value 10: {containsValue10}");



    }
  }
}
