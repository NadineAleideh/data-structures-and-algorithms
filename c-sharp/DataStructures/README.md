# Hashtable Implementation in C#

## Challenge Title
Implement a Hashtable class in C# with the specified methods Set, Get, Contains, Keys, Hash and write tests for it.


## Approach & Efficiency
### `Set` Method
- To implement the `Set` method, we first calculate the hash of the key using the provided hash function.
- We then check if there is already a value at that hash index in the table.
  - If there is no value, we create a new node and set it at that index.
  - If there is a value, we traverse the linked list at that index and append the new key-value pair to the end.
- This approach has a time complexity of O(1) for average cases and O(n) for worst cases when there are many collisions.

### `Get` Method
- To implement the `Get` method, we calculate the hash of the key and go to that index in the table.
- We then traverse the linked list at that index to find the matching key.
- If found, we return the corresponding value; otherwise, we return null.
- This approach has a time complexity of O(1) for average cases and O(n) for worst cases when there are many collisions.

### `Contains` Method
- The `Contains` method follows a similar approach to the `Get` method. It calculates the hash, goes to the index, and checks if the key exists in the linked list.
- It returns true if the key is found and false otherwise.
- This approach has a time complexity of O(1) for average cases and O(n) for worst cases when there are many collisions.

### `Hash` Method
- The `Hash` method calculates a hash code for a given key by summing up the ASCII values of its characters and applying a modulo operation.
- It uses a prime number multiplier (599) to distribute the keys evenly across the table.
- The method returns an index within the table size (1024).
- This approach has a time complexity of O(n), where n is the length of the key.

## Solution

### Code
```
  public class Node
  {
    public string Key { get; set; }
    public string Value { get; set; }
    public Node Next { get; set; }

    public Node(string key, string value)
    {
      Key = key;
      Value = value;
    }
  }

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

```

### How to Run the Code
1. Clone the repository to your local machine.
2. Open the solution in Visual Studio or your preferred C# IDE.
3. Build and run the project.

### Examples
Here are some examples of how to use the Hashtable:

```csharp
HashTable hashTable = new HashTable(1024);


 hashTable.Set("name", "Nadine");
 hashTable.Set("age", "23");
 hashTable.Set("city", "Irbid");
 hashTable.Set("major", "developer");


 Node nameNode = hashTable.Get("name");
 Node ageNode = hashTable.Get("age");
 Node cityNode = hashTable.Get("city");
 Node majorNode = hashTable.Get("major");


 bool containsName = hashTable.Contains("name");
 bool containsCountry = hashTable.Contains("country");


 Console.WriteLine("Value for 'name': " + nameNode?.Value);
 Console.WriteLine("\nValue for 'age': " + ageNode?.Value);
 Console.WriteLine("\nValue for 'city': " + cityNode?.Value);
 Console.WriteLine("\nValue for 'major': " + majorNode?.Value);
 Console.WriteLine("\nContains 'name': " + containsName);
 Console.WriteLine("\nContains 'country': " + containsCountry);


 List<string> keys = hashTable.Keys();
 Console.WriteLine("\nAll Unique Keys:");
 foreach (var key in keys)
  {
    Console.WriteLine(key);
  }
```

## Test

To see the test go to [hashtableTest](../hashtableTest/UnitTest1.cs)

![test](./CC30test.PNG)
