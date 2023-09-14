using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace hashtable
{
  public class HashTable
  {
    private static int tableSize;
    private Node[] Table { get; set; }

    public HashTable(int size)
    {
      tableSize = size;
      Table = new Node[tableSize];
    }


    public void Set(string key, string value)
    {
      if (key == null || value == null)
      {
        throw new ArgumentNullException("Key and value cannot be null.");
      }

      int index = Hash(key);
      Node newNode = new Node(key, value);

      if (Table[index] == null)
      {
        Table[index] = newNode;
      }
      else
      {
        Node current = Table[index];
        while (current.Next != null)
        {
          current = current.Next;
        }
        current.Next = new Node(key, value);
      }
    }


    public Node Get(string key)
    {
      if (key == null)
      {
        throw new ArgumentNullException("Key cannot be null.");
      }

      int index = Hash(key);
      Node current = Table[index];

      while (current != null)
      {
        if (current.Key == key)
        {
          return current;
        }
        current = current.Next;
      }

      return null;
    }

    public bool Contains(string key)
    {
      if (key == null)
      {
        throw new ArgumentNullException("Key cannot be null.");
      }

      int index = Hash(key);
      Node current = Table[index];

      while (current != null)
      {
        if (current.Key == key)
        {
          return true;
        }
        current = current.Next;
      }

      return false;
    }

    public List<string> Keys()
    {
      List<string> keys = new List<string>();

      foreach (var node in Table)
      {
        Node current = node;

        while (current != null)
        {
          keys.Add(current.Key);
          current = current.Next;
        }
      }

      return keys;
    }

    public int Hash(string key)
    {
      int hash = 0;

      foreach (int character in key)
      {
        hash += character;
      }

      return hash * 599 % 1024;
    }

  }
}
