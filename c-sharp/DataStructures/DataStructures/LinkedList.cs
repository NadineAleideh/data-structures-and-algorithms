using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace DataStructures
{
  public class LinkedList
  {
    public Node Head { get; set; }

    public LinkedList()
    {
      Head = null;//represents the first node
    }

    public void InsertFirst(int value)
    {
      Node newNode = new Node(value);


      if (Head == null)
      {
        Head = newNode;
        newNode.Next = null;
      }

      else
      {
        newNode.Next = Head;
        Head = newNode;
      }
    }


    public bool IsIncludes(int value)
    {
      Node currentNode = Head;


      while (currentNode != null)
      {
        if (currentNode.Value == value)
        {
          return true;

        }
        currentNode = currentNode.Next;

      }
      return false;

    }


    public override string ToString() //override keyword to represent the current Linkened list obj 
    {
      Node currentNode = Head;
      string str = "";

      while (currentNode != null)
      {
        str += $"{{ {currentNode.Value} }} -> ";
        currentNode = currentNode.Next;
      }
      str += "NULL";
      return str;
    }

    // code challenge 6 starts

    public void Append(int value)
    {
      Node newNode = new Node(value);

      if (Head == null)
      {
        Head = newNode;
      }
      else
      {
        Node current = Head;
        while (current.Next != null)
        {
          current = current.Next;
        }
        current.Next = newNode;
      }
    }

    public void InsertBefore(int value, int newValue)
    {
      Node newNode = new Node(newValue);

      if (Head == null)
      {
        throw new InvalidOperationException("Cannot insert before in an empty list.");
      }

      if (Head.Value == value)
      {
        newNode.Next = Head;
        Head = newNode;
      }
      else
      {
        Node current = Head;
        while (current.Next != null)
        {
          if (current.Next.Value == value)
          {
            newNode.Next = current.Next;
            current.Next = newNode;
            return;
          }
          current = current.Next;
        }
        throw new ArgumentException("Value not found in the list to insert before.");
      }
    }


    public void InsertAfter(int value, int newValue)
    {
      Node newNode = new Node(newValue);

      if (Head == null)
      {
        throw new InvalidOperationException("Cannot insert after in an empty list.");
      }

      Node current = Head;
      while (current != null)
      {
        if (current.Value == value)
        {
          newNode.Next = current.Next;
          current.Next = newNode;
          return;
        }
        current = current.Next;
      }
      throw new ArgumentException("Value not found in the list to insert after.");
    }


    public void Delete(int value)
    {
      if (Head == null)
      {
        throw new InvalidOperationException("Cannot delete in an empty list.");
      }

      if (Head.Value == value)
      {
        // If the head node has the specified value, update the head to the next node
        Head = Head.Next;
        return;
      }

      Node current = Head;
      Node previous = null;

      while (current != null)
      {
        if (current.Value == value)
        {
          // Found the node with the specified value, update the previous node's next pointer
          previous.Next = current.Next;
          return;
        }

        previous = current;
        current = current.Next;
      }
      throw new ArgumentException("Value not found in the list to be deleted.");
    }


    public int KthValueFromEnd(int k)
    {
      if (k < 0)
      {
        throw new ArgumentException($"k {k} must be a non-negative integer.");
      }

      Node P1 = Head;
      Node P2 = Head;


      // Move the P1 pointer k nodes ahead of the P2 pointer
      for (int i = 0; i < k; i++)
      {
        if (P1 == null)
        {
          throw new ArgumentException($"k {k} exceeds the length of the linked list.");
        }
        P1 = P1.Next;

        if (P1 == null)
        {
          throw new ArgumentException($"k {k} cannot be the same as the length of the linked list.");
        }
      }

      // Move both pointers until the P1 pointer reaches the end

      while (P1.Next != null)
      {

        P2 = P2.Next;
        P1 = P1.Next;
      }

      return P2.Value;
    }



  }


}
