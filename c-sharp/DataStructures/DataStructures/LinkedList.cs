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

    public void InsertFirst (int value)
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

      while ( currentNode != null)
      {
        str += $"{{ {currentNode.Value} }} -> ";
        currentNode = currentNode.Next;
      }
      str += "NULL";
      return str;
    }

  }

 
}
