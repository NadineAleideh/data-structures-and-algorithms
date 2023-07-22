using System;
using System.Collections.Generic;

namespace DataStructures
{
  public class Program
  {
    public static void Main(string[] args)
    {
      try
      {
        //// Create a new linked list
        //LinkedList linkedList = new LinkedList();

        //// Insert nodes
        //linkedList.InsertFirst(4);
        //linkedList.InsertFirst(3);
        //linkedList.InsertFirst(2);
        //linkedList.InsertFirst(1);
        //linkedList.Append(5);
        //linkedList.Append(6);

        //linkedList.InsertBefore(1, 0);
        //linkedList.InsertAfter(6, 7);
        //linkedList.Delete(3);

        //// Generate string representation
        //string listString = linkedList.ToString();
        //Console.WriteLine($"LinkedList: {listString}");

        //// Search for a value
        //bool containsValue2 = linkedList.IsIncludes(2);
        //bool containsValue10 = linkedList.IsIncludes(10);
        //Console.WriteLine($"Contains value 2: {containsValue2}");
        //Console.WriteLine($"Contains value 10: {containsValue10}");


        //  for (int i =0; i< 7; i++)
        //  {
        //    Console.WriteLine($"{i}th value from end: {linkedList.KthValueFromEnd(i)}");
        //  }

        //  Console.WriteLine($"-4th value from end: {linkedList.KthValueFromEnd(-4)}");
        //  //Console.WriteLine($"7th value from end: {linkedList.KthValueFromEnd(7)}");
        //  //Console.WriteLine($"10th value from end: {linkedList.KthValueFromEnd(10)}");


        //// Stack 
        //Stack stack = new Stack ();

        //stack.Push(10);
        //stack.Push(20);
        //stack.Push(30);

        //Console.WriteLine(stack.Peek()); // Output: 30

        //Console.WriteLine(stack.Pop()); // Output: 30
        //Console.WriteLine(stack.Pop()); // Output: 20

        //Console.WriteLine(stack.IsStackEmpty()); // Output: False

        //Console.WriteLine(stack.Pop()); // Output: 10

        //Console.WriteLine(stack.IsStackEmpty()); // Output: True

        //// Queue 
        //Queue queue = new Queue ();

        //queue.Enqueue(1);
        //queue.Enqueue(2);
        //queue.Enqueue(3);

        //Console.WriteLine(queue.Peek()); // Output: 1

        //Console.WriteLine(queue.Dequeue()); // Output: 1
        //Console.WriteLine(queue.Dequeue()); // Output: 2

        //Console.WriteLine(queue.IsQueueEmpty()); // Output: False

        //Console.WriteLine(queue.Dequeue()); // Output: 3

        //Console.WriteLine(queue.IsQueueEmpty()); // Output: True

        //PseudoQueue pseudoQueue = new PseudoQueue();

        //pseudoQueue.Enqueue(10);
        //pseudoQueue.Enqueue(15);
        //pseudoQueue.Enqueue(20);

        //Console.WriteLine(pseudoQueue.Dequeue()); // Output: 10
        //Console.WriteLine(pseudoQueue.Dequeue()); // Output: 15

        AnimalShelter shelter = new AnimalShelter();

        // Enqueue dogs and cats
        shelter.Enqueue(new Animal("dog", "Buddy"));
        shelter.Enqueue(new Animal("cat", "Whiskers"));
        shelter.Enqueue(new Animal("dog", "Max"));
        shelter.Enqueue(new Animal("cat", "Fluffy"));

        // Dequeue a specific preference
        Console.WriteLine(shelter.Dequeue("dog").Name); // Output: Buddy

        // Dequeue another specific preference
        Console.WriteLine(shelter.Dequeue("cat").Name); // Output: Whiskers

        // Dequeue any animal
        Console.WriteLine(shelter.DequeueAny().Name); // Output: Max

        // Dequeue any animal again
        Console.WriteLine(shelter.DequeueAny().Name); // Output: Fluffy
      }
      catch (InvalidOperationException ex)
      {
        Console.WriteLine($"InvalidOperationException: {ex.Message}");

      }
      catch (ArgumentException ex)
      {
        Console.WriteLine($"ArgumentException: {ex.Message}");
      }

      finally
      {
        Console.WriteLine("Program done");
      }

    }
  }
}
